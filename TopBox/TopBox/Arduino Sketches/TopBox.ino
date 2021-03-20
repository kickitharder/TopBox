#define VERSION "TopBox V1.210307 by keithrickard@hotmail.com"
#include <SoftwareSerial.h>
#include <EEPROM.h>

/*
  Work started 28 Dec 2020 for Arduino Nano.
  Receives commands via Serial or Bluetooth control an array of 8 relays.

  Three relays are used to control a Meade Focuser - two speeds and direction.
  The focuser can be controlled by the Meade LX200 Classic hand box via the 
  LX200 control panel focuser socket via Panel Dongle and Bluetooth so making
  its control wireless.
*/ 

#define OUT           OUTPUT
#define IN            INPUT
#define HALT          2
#define DONE          3
#define GOTO          4
#define HOME          5
#define SLOT          6

#define STOP          INPUT
#define GO            1
#define SLOW          INPUT
#define FAST          OUTPUT

#define ON            INPUT
#define OFF           OUTPUT
#define SPEED_ADJ     2.5
#define SERIAL        1
#define BLUETOOTH     0
#define RES_ADJ       10

#define R_CCDCAMERA   0   // Relay 0
#define R_VOLTS       1   // Relay 1
#define R_DIR1        2   // Relay 2
#define R_DIR2        3   // Relay 3  
#define R_EXTRA       4   // Relay 4 (not used)
#define R_MYFOCUSER   5   // Relay 5
#define R_DEW_SCOPE   6   // Relay 6
#define R_DEW_GUIDER  7   // Relay 7
#define PIN           2
#define btTXD         11
#define btRXD         12
#define LED           A2
#define SWITCH_IN     A3
#define SWITCH_GND    A4
#define SWITCH_OUT    A5
#define SERIAL        1
#define BLUETOOTH     0

SoftwareSerial btSerial(btTXD, btRXD);    // btRXD -> Arduino's receive pin
const long MAX_LIMIT = 800000;
byte currDir   = STOP;
byte currSpeed = STOP;
byte relays[] = {0, 0, 0, 0, 0, 0, 0, 0};
char cmd;
byte serial;
bool isMoving, sw, ascom;
unsigned long focTimer, focStart;
long focPos, focTarg, maxLimit, tempPos;
float focSpeed;
struct ee{
  long preset[10];
  char name[10][32];
} ee;

void setup() {
  pinMode(R_CCDCAMERA + PIN,  INPUT);   // 0 CCD Camera power relay - GND line
  pinMode(R_VOLTS + PIN,      INPUT);   // 1 Meade Focuser power line select +12V / +5V
  pinMode(R_DIR1 + PIN,       INPUT);   // 2 DIR Relays flip the power line polarity
  pinMode(R_DIR2 + PIN,       INPUT);   // 3 for the Meade Focuser
  pinMode(R_EXTRA + PIN,      INPUT);   // 4 Spare relay
  pinMode(R_MYFOCUSER + PIN,  INPUT);   // 5 myFocuserPro2 +12V stepper motor power source
  pinMode(R_DEW_SCOPE + PIN,  INPUT);   // 6 Dew heater power relay for the telescope
  pinMode(R_DEW_GUIDER + PIN, INPUT);   // 7 Dew heater power relay for the guidescope
  pinMode(ASCOM, OUTPUT);
  pinMode(SWITCH_IN, INPUT_PULLUP);     // Button to stop focuser
  pinMode(SWITCH_OUT, INPUT_PULLUP);
  pinMode(SWITCH_GND, OUTPUT);
  digitalWrite(SWITCH_GND, LOW);
  digitalWrite(ASCOM, LOW);
  Serial.begin(9600);
  btSerial.begin(38400);
  Serial.setTimeout(100);
  btSerial.setTimeout(100);
  Serial.println(VERSION);
  isMoving = STOP;
  tempPos = 0;
  sw = 0;
  ascom = 0;
  eepromSetUp();
}

// ==============================================================================================
void command(byte s) {
  digitalWrite(LED, HIGH);
  serial = s;
  cmd = 0;
  if (serial) if(Serial.available()) cmd = Serial.read();
  if (!serial) if(btSerial.available()) cmd = btSerial.read();
  if (!cmd) return;
  
  switch (cmd) {                                    // Process the command
    case 'V': version();                    break;
    case 'A': ascom = 1;                    break;  // Returns 'A' to confirm ASCOM connection
    case 'a': ascom = 0;                    break;  // Returns 'a' to confirm ASCOM disconnection
    case '=': relayGet();                   break;  // Return a relay setting
    case '+': relaySet(ON);                 break;  // '\ ' Set a relay to close position
    case '-': relaySet(OFF);                break;  // ' /' Set a relay to open position
    case 'R': getRelays();                  break;  // Return string of all relay settings
    case 'r': getRelays();                  break;
    case 'C': ccdCamera(ON);                break;  // Power on  CCD camera
    case 'c': ccdCamera(OFF);               break;  // Power off CCD camera
    case 'M': myFocuser(ON);                break;  // Power on  myFocuserPro2 stepper motor
    case 'm': myFocuser(OFF);               break;  // Power off myFocuserPro2 stepper motor
    case 'X': extra(ON);                    break;  // '\ ' Set spare relay to close position
    case 'x': extra(OFF);                   break;  // ' /' Set spare relay to open postion
    case 'T': dewHeater(1, ON);             break;  // Power on  telescope dew heater (1)
    case 't': dewHeater(1, OFF);            break;  // Power off telescope dew heater (1)
    case 'L': dewHeater(2, ON);             break;  // Power on  guidescope dew heater (2)
    case 'l': dewHeater(2, OFF);            break;  // Power off guidescope dew heater (2)

    case 'S': focuser(OUT,  SLOW);          break;  // Send focuser outwards slowly
    case 's': focuser(IN,   SLOW);          break;  // Send focuser inwards slowly
    case 'F': focuser(OUT,  FAST);          break;  // Send focuser outwards quickly
    case 'f': focuser(IN,   FAST);          break;  // Send focuser inwards quickly
    case 'Q': focuser(HALT, HALT);          break;  // Stop focuser immediately
    case 'q': focuser(HALT, HALT);          break;  // Stop focuser immediately
    case 'G': focuser(GOTO, FAST);          break;  // Go fast to given postion
    case 'g': focuser(GOTO, SLOW);          break;  // Go slow to given position
    case 'H': focuser(HOME, FAST);          break;  // Go fast to home (preset 0)
    case 'h': focuser(HOME, SLOW);          break;  // Go slow to home (preset 0)
    case 'P': focuserGetPos();              break;  // Get focuser's postion
    case 'p': focuserSetPos();              break;  // Set focuser's postion
    case 'n': eepromSetName();              break;  // Set name for given preset
    case 'N': eepromGetName();              break;  // Get name for given preset
    case 'e': eepromSetPreset();            break;  // Store current focuser position in preset 0 - 9
    case 'E': eepromGetPreset();            break;  // Get stored focuser position in preset 0 - 9
    case 'd': eepromPresets();              break;  // Get all preset values
    case 'Z': eepromGotoPreset();           break;  // Goto a stored focuser position in preset 0 - 9
    case 'z': eepromTempPos();              break;  // Temporary store for set a EERPROM preset
    case 'W': eepromWipe();                 break;  // Format EEPROM storage
    case 'w': eepromSetUp();                break;  // Setup EPROM storage structure
    case 'D': eepromDisp();                 break;  // Send complete contents of the EEPROM
    case 'I': cmd = (isMoving == GO) + '0'; break;  // Returns 1 if focuser is moving, 0 is not
    default: cmd = 0;                       break;  // Command is not valid so no action
  }
  if (cmd) serial ? Serial.println(cmd) : btSerial.println(cmd);  // Echo the command
}

// ==============================================================================================
void loop() {
  command(SERIAL);                      // Look to see if a command has been received
  command(BLUETOOTH);
  if (isMoving == GO) if (focTimer) if (millis() >= focTimer) focuser(DONE, HALT);
  
  byte sw_in = !digitalRead(SWITCH_IN);
  byte sw_out = !digitalRead(SWITCH_OUT);
  if (sw_in || sw_out) {
    if (!sw) {
      focuser(sw_in ? IN : OUT, FAST);   // Move the focuser depending on switch selection
      sw = 1;
    }
  }
  else {
    if(sw) {
      if(isMoving == GO) focuser(HALT, HALT); // Stop focuser if moving
      sw = 0;
    }
  }
}
 
// ==============================================================================================
void focuser(byte action, long speed) {
  if (sw == 1 && action != DONE && action != HALT) return; // Quit if switch move and action is not to stop
  pinMode(R_DIR1 + PIN, STOP);                                // Stop the focuser motor by disconnecting power
  pinMode(R_DIR2 + PIN, STOP);
  relays[R_DIR1] = STOP;
  relays[R_DIR2] = STOP;
  focTimer = 0;
  
// UPDATING FOCUSER POSITION
  float focDist = (millis() - focStart) / focSpeed;
  if (isMoving == GO) focPos += (long)focDist * ((focTarg > focPos) ? 1 : -1);
  isMoving = STOP;
  if (action == DONE) focPos = focTarg;                 // Planned Stop
  if (action == HALT || action == DONE) return;         // Quit if aborted move or planned stop
  eepromFocPos();

// DETERMINE HOW MOVE TO THE FOCUSER
  focTarg = ee.preset[0];
  if (action == SLOT) focTarg = speed;
  if (action != HOME && action != SLOT){
    if (serial) focTarg = Serial.parseInt();
    else focTarg = btSerial.parseInt();
    focTarg *= RES_ADJ;
    if (action == IN || action == OUT) {                                    // Act if relative move
      if (focTarg) focTarg = focPos + (action == IN ? -focTarg : focTarg);  // Convert target to absolute position if not 0
      else focTarg = action == IN ? 0 : maxLimit;                           // Else select limit
    }
    if (focTarg < 1) focTarg = 1;                                           // Make sure target is within limits
    if (focTarg > maxLimit) focTarg = maxLimit;
    if (focTarg == focPos) return;                                          // Quit if target is same as current postion
  }
  focSpeed = ((speed == SLOW) ? SPEED_ADJ : 1.0);
  action = focTarg < focPos;                                              // Figure out which direction to send the motor
  focTimer = 1.0 * abs(focTarg - focPos) * focSpeed;                      // Figure out how time of travel
  focTimer += focStart = millis();

// GET FOCUSER MOVING
  relays[R_VOLTS] = speed;                        // Remember relay settings
  relays[R_DIR1] = action;
  relays[R_DIR2] = action ^ 1;
  pinMode(R_VOLTS + PIN, speed);                  // Select speed (SLOW = 5V, FAST = 12V)
  pinMode(R_DIR1 + PIN, action ? OUTPUT : INPUT); // Set the relays to select polarity and therefore
  pinMode(R_DIR2 + PIN, action ? INPUT : OUTPUT); // the direction of the motor
  isMoving = GO;                                  // Focuser is moving
}

// ==============================================================================================
void focuserGetPos(){
  cmd = 0;
  float position = focPos;
  if (isMoving == GO) position += 1.0 * (millis() - focStart) / focSpeed * (focTarg < focPos ? -1 : 1);
  position /= RES_ADJ;
  serial ? Serial.println(position, 0) : btSerial.println(position, 0);
}

// ==============================================================================================
void focuserSetPos() {
  long pos;
  delay(50);
  if (serial) pos = Serial.parseInt();
  else pos = btSerial.parseInt();
  pos *= 10;
  if (pos > maxLimit) pos = maxLimit;
  if (pos > 0) {
    focPos = pos;
    eepromFocPos();
  }
}

// ==============================================================================================
void eepromTempPos() {
  long pos;
  delay(50);
  if (serial) pos = Serial.parseInt();
  else pos = btSerial.parseInt();
  pos *= 10;
//  if (pos > maxLimit) pos = maxLimit;
  if (pos > 0) tempPos = pos;
}

// ==============================================================================================
void ccdCamera(byte state) {
  relays[R_CCDCAMERA] = state;
  pinMode(R_CCDCAMERA + PIN, state);
}

// ==============================================================================================
void myFocuser(byte state) {
  relays[R_MYFOCUSER] = state;
  pinMode(R_MYFOCUSER + PIN, state);
}

// ==============================================================================================
void extra(byte state) {
  relays[R_EXTRA];
  pinMode(R_EXTRA + PIN, state);
}

// ==============================================================================================
void dewHeater(byte heater, byte state){
  if (heater == 1){
    relays[R_DEW_SCOPE] = state;
    pinMode(R_DEW_SCOPE + PIN, state);
  }
  if (heater == 2){
    relays[R_DEW_GUIDER] = state;
    pinMode(R_DEW_GUIDER + PIN, state);
  }
}

// ==============================================================================================
void relayGet() {
  int relay;
  delay (50);
  char c = serial ? Serial.peek() : btSerial.peek();
  if (isdigit(c)) relay = relayNo();
  else {
    serial ? Serial.read() : btSerial.read();
    switch (c){                                   // See if relay code has been given - use it if so
      case 'C': relay = R_CCDCAMERA;  break;
      case 'T': relay = R_DEW_SCOPE;  break;
      case 'L': relay = R_DEW_GUIDER; break;
      case 'M': relay = R_MYFOCUSER;  break;
      case 'X': relay = R_EXTRA;      break;
      default: relay = -1;
    }
  }
  cmd = '%';
  if (relay < 0) return;
  cmd = 0;
  relay = relays[relay] ^1;
  serial ? Serial.println(relay): btSerial.println(relay);
}
 
// ==============================================================================================
void relaySet(byte state) {
  int relay = relayNo();
  if (relay < 0 || relay > 7) {
    cmd = '%';
    return;
  }
  relays[relay] = state;
  pinMode(relay + PIN, state);
}

// ==============================================================================================
int relayNo() {
  long value = serial ? Serial.parseInt() : btSerial.parseInt();
  if (value < 0 || value > 7) return -1;
  return value;
}

// ==============================================================================================
void getRelays() {
  for(byte i = 0; i <= 7; i++) serial ? Serial.print(relays[i] ^1) : btSerial.print(relays[i] ^1);
  cmd = '\n';
}

// ==============================================================================================
void eepromGotoPreset(){
  byte e;
  long pos;
  delay(50);
  if (serial) e = Serial.read();
  else btSerial.read();
  e -= '0';
  if (e <= 9){
    EEPROM.get(4, ee);
    pos = (ee.preset[e]);
    focuser(SLOT, pos);
  }
  else cmd = '%';
}

// ==============================================================================================
void eepromGetPreset(){
  byte e;
  long pos;
  delay(50);
  cmd = 0;
  if (serial) e = Serial.read();
  else btSerial.read();
  e -= '0';
  if (e <= 9){
    EEPROM.get(6, ee);
    pos = (ee.preset[e]) / 10;
    serial ? Serial.println(pos) : btSerial.println(pos);      
  }
  else cmd = '%';
}

// ==============================================================================================
void eepromSetPreset() {
  byte e;
  delay(50);
  if (serial) e = Serial.read();
  else btSerial.read();
  if (!tempPos) tempPos = focPos;
  e -= '0';
  if (isMoving == STOP) {
    if (e <= 9){
      Serial.println(tempPos);
      EEPROM.get(6, ee);
      ee.preset[e] = tempPos;
      EEPROM.put(6, ee);
      tempPos = 0;
    }
  }
  else cmd = '%';
}

// ==============================================================================================
void eepromGetName() {
  byte e;
  delay(50);
  if (serial) e = Serial.read();
  else btSerial.read();
  e -= '0';
  if (e <= 9) {
    EEPROM.get(6, ee);
    cmd = 0;
    serial ? Serial.println(ee.name[e]) : btSerial.println(ee.name[e]);
  }
  else cmd = '%';
}

// ==============================================================================================
void eepromSetName() {
  byte e;
  delay(50);
  if (serial) e = Serial.read();
  else btSerial.read();
  e -= '0';
  if (e > 0 && e <= 8) {
    String name = Serial.readStringUntil('#');
    EEPROM.get(6, ee);
    for (byte i = 0; i <= 30; i++) {      // Only accept 31 chars for the preset name
      ee.name[e][i] = '\0';
      ee.name[e][i + 1] = '\0';
      if (i == name.length() || name.charAt(i) == '\r' || name.charAt(i) == '\n') break;
      ee.name[e][i] = name.charAt(i);
    }
    EEPROM.put(6, ee);
  }
  else {
    cmd = '%';
    if (serial) while (Serial.available()) Serial.read(); //Clear the applicable serial buffer
    else while(btSerial.available()) btSerial.read();
  }
}

// ==============================================================================================
void eepromSetUp() {
  unsigned long check;
  int a;
  EEPROM.get(4, a);
  EEPROM.get(6, ee);
  EEPROM.get(a, focPos);
  EEPROM.get(0, check);             // See if EEPROM has been formatted
  maxLimit = ee.preset[9];

  if (check == 0x0D6015EE) return;  // EE(PROM) IS GOOD i.e. already set up - so quit
  Serial.print("Formating EEPROM... ");
  delay(1000);
  
  eepromWipe();                                         // Start with a clean slate
  EEPROM.put(0, (unsigned long)0x0D6015EE);             // Format the EERPOM
  focPos = MAX_LIMIT / 2;                               // Set-up the 10 focus position presets
  for (byte i = 0; i <= 8; i++) ee.preset[i] = focPos;  // Initialise the preset slots
  ee.preset[9] = MAX_LIMIT;
  strcpy(ee.name[0], "Home");
  strcpy(ee.name[1], "Preset 1");
  strcpy(ee.name[2], "Preset 2");
  strcpy(ee.name[3], "Preset 3");
  strcpy(ee.name[4], "Preset 4");
  strcpy(ee.name[5], "Preset 5");
  strcpy(ee.name[6], "Preset 6");
  strcpy(ee.name[7], "Preset 7");
  strcpy(ee.name[8], "Preset 8");
  strcpy(ee.name[9], "Upper Limit");
  EEPROM.put(6, ee);                                  // Save them to the EEPROM
  EEPROM.put(4, (int)366);                            // Save pointer for the current focuser position
  eepromFocPos();                                     // Save the focuser position
  Serial.println("done");
}
// ==============================================================================================
void eepromWipe() {
  for (int i = 0; i <= 1023; i++) EEPROM.put(i, (byte)0xFF);
}

// ==============================================================================================
void eepromDisp() {
  int a = 0;
  for (int i = 0; i <= 1023; i += 8) {
    hexDigits(i >> 8);
    hexDigits(i & 0xFF);
    serial ? Serial.print(" ") : btSerial.print(" ");
    for (int j = 0; j <= 7; j++){
      hexDigits(EEPROM.read(i + j));
      serial ? Serial.print(" ") : Serial.print(" ");
    }
    serial ? Serial.println() : btSerial.println();
    cmd = 0;
  }  
}
// ==============================================================================================
void hexDigits(byte b){
  if (b < 16) serial ? Serial.print('0') :btSerial.print('0');
  serial ? Serial.print(b, HEX) : btSerial.print(b, HEX);
}

// ==============================================================================================
void eepromPresets() {
  if(serial){
    Serial.print('P');
    Serial.print(' ');
    Serial.print(focPos);
    Serial.println(" Current Position");
  } else {
    btSerial.print('P');
    btSerial.print(' ');
    btSerial.print(focPos);
    btSerial.println(" Current Position");
  }
  for (byte i = 0; i <=9; i++) {
    if (serial) {
      Serial.print(i);
      Serial.print(' ');
      Serial.print(ee.preset[i]);
      Serial.print(' ');
      Serial.println(ee.name[i]);
    } else {
      btSerial.print(i);
      btSerial.print(' ');
      btSerial.print(ee.preset[i]);
      btSerial.print(' ');
      btSerial.println(ee.name[i]);
    }
  }
  cmd = 0;
}

// ==============================================================================================
void eepromFocPos() {
  int eeAddr;
  long n;
  do {
    EEPROM.get(4, eeAddr);      // Get location pointer for storing focus position
    EEPROM.put(eeAddr, focPos); // Store the focuser position
    EEPROM.get(eeAddr, n);      // See if it was stored OK
    if(focPos == n) return;     // Quit if it has
    eeAddr ++;                  // Otherwise move long to the next location
    EEPROM.put(4, eeAddr);      // Save the new pointer value
  } while (eeAddr <= 1020);     // Try saving the focus position again until space runs out

/*
  The EEPROM can only be re-written to about 100,000 times.  The focus position is written everytime
  a move is completed, or aborted, to the EEPROM to remember the focuser's postion.
  
  If focPos is not stored correctly, then the storage pointer is moved along one. Logically, it should
  be moved along 4 bytes as 4 bytes are required to save focPos, but the EEPROM may still be able to 
  save it from the next byte rather in the next 4 along, so extending the life of the EEPROM.
  
  Theorectically, focPos should be able to be written to EEPROM about 21 million times before it gives up!
*/
}

// ==============================================================================================
void version() {
  cmd = 0;
  serial ? Serial.println(VERSION) : btSerial.println(VERSION);
}
