<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupDialogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupDialogForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkTrace = New System.Windows.Forms.CheckBox()
        Me.ComboBoxComPort = New System.Windows.Forms.ComboBox()
        Me.grpFocuserPresets = New System.Windows.Forms.GroupBox()
        Me.lblCurrPos = New System.Windows.Forms.Label()
        Me.radMoveOut = New System.Windows.Forms.RadioButton()
        Me.radMoveIn = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.nudMoveOut = New System.Windows.Forms.NumericUpDown()
        Me.nudMoveIn = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset9 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset8 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset7 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset6 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset5 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset4 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset3 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset2 = New System.Windows.Forms.NumericUpDown()
        Me.lblMoving = New System.Windows.Forms.Label()
        Me.nudPreset1 = New System.Windows.Forms.NumericUpDown()
        Me.nudPreset0 = New System.Windows.Forms.NumericUpDown()
        Me.nudCurrPos = New System.Windows.Forms.NumericUpDown()
        Me.nudTarget = New System.Windows.Forms.NumericUpDown()
        Me.radTarget = New System.Windows.Forms.RadioButton()
        Me.btnSlowOut = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnFastOut = New System.Windows.Forms.Button()
        Me.btnSlowIn = New System.Windows.Forms.Button()
        Me.txtCurrPos = New System.Windows.Forms.TextBox()
        Me.btnFastIn = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnSlowGoto = New System.Windows.Forms.Button()
        Me.btnFastGoto = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.radPreset9 = New System.Windows.Forms.RadioButton()
        Me.radPreset8 = New System.Windows.Forms.RadioButton()
        Me.radPreset7 = New System.Windows.Forms.RadioButton()
        Me.radPreset6 = New System.Windows.Forms.RadioButton()
        Me.radPreset5 = New System.Windows.Forms.RadioButton()
        Me.radPreset4 = New System.Windows.Forms.RadioButton()
        Me.radPreset3 = New System.Windows.Forms.RadioButton()
        Me.radPreset2 = New System.Windows.Forms.RadioButton()
        Me.radPreset1 = New System.Windows.Forms.RadioButton()
        Me.radPreset0 = New System.Windows.Forms.RadioButton()
        Me.txtName9 = New System.Windows.Forms.TextBox()
        Me.txtName8 = New System.Windows.Forms.TextBox()
        Me.txtName7 = New System.Windows.Forms.TextBox()
        Me.txtName6 = New System.Windows.Forms.TextBox()
        Me.txtName5 = New System.Windows.Forms.TextBox()
        Me.txtName4 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName0 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.grpMode = New System.Windows.Forms.GroupBox()
        Me.radRelative = New System.Windows.Forms.RadioButton()
        Me.radAbsolute = New System.Windows.Forms.RadioButton()
        Me.grpSwitches = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSpare = New System.Windows.Forms.Button()
        Me.btnMFP = New System.Windows.Forms.Button()
        Me.btnDew2 = New System.Windows.Forms.Button()
        Me.btnDew1 = New System.Windows.Forms.Button()
        Me.btnCCD = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpBacklash = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.nudBacklash = New System.Windows.Forms.NumericUpDown()
        Me.radInward = New System.Windows.Forms.RadioButton()
        Me.radOutward = New System.Windows.Forms.RadioButton()
        Me.radBacklashDisabled = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblRetrieve = New System.Windows.Forms.Label()
        Me.lblUpdating = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFocuserPresets.SuspendLayout()
        CType(Me.nudMoveOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMoveIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPreset0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCurrPos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMode.SuspendLayout()
        Me.grpSwitches.SuspendLayout()
        Me.grpBacklash.SuspendLayout()
        CType(Me.nudBacklash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 382)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'chkTrace
        '
        Me.chkTrace.AutoSize = True
        Me.chkTrace.Location = New System.Drawing.Point(608, 2)
        Me.chkTrace.Name = "chkTrace"
        Me.chkTrace.Size = New System.Drawing.Size(69, 17)
        Me.chkTrace.TabIndex = 8
        Me.chkTrace.Text = "Trace on"
        Me.chkTrace.UseVisualStyleBackColor = True
        '
        'ComboBoxComPort
        '
        Me.ComboBoxComPort.FormattingEnabled = True
        Me.ComboBoxComPort.Location = New System.Drawing.Point(179, 63)
        Me.ComboBoxComPort.Name = "ComboBoxComPort"
        Me.ComboBoxComPort.Size = New System.Drawing.Size(84, 21)
        Me.ComboBoxComPort.TabIndex = 9
        '
        'grpFocuserPresets
        '
        Me.grpFocuserPresets.Controls.Add(Me.lblCurrPos)
        Me.grpFocuserPresets.Controls.Add(Me.radMoveOut)
        Me.grpFocuserPresets.Controls.Add(Me.radMoveIn)
        Me.grpFocuserPresets.Controls.Add(Me.Label27)
        Me.grpFocuserPresets.Controls.Add(Me.Label26)
        Me.grpFocuserPresets.Controls.Add(Me.nudMoveOut)
        Me.grpFocuserPresets.Controls.Add(Me.nudMoveIn)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset9)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset8)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset7)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset6)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset5)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset4)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset3)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset2)
        Me.grpFocuserPresets.Controls.Add(Me.lblMoving)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset1)
        Me.grpFocuserPresets.Controls.Add(Me.nudPreset0)
        Me.grpFocuserPresets.Controls.Add(Me.nudCurrPos)
        Me.grpFocuserPresets.Controls.Add(Me.nudTarget)
        Me.grpFocuserPresets.Controls.Add(Me.radTarget)
        Me.grpFocuserPresets.Controls.Add(Me.btnSlowOut)
        Me.grpFocuserPresets.Controls.Add(Me.Label21)
        Me.grpFocuserPresets.Controls.Add(Me.btnFastOut)
        Me.grpFocuserPresets.Controls.Add(Me.btnSlowIn)
        Me.grpFocuserPresets.Controls.Add(Me.txtCurrPos)
        Me.grpFocuserPresets.Controls.Add(Me.btnFastIn)
        Me.grpFocuserPresets.Controls.Add(Me.btnStop)
        Me.grpFocuserPresets.Controls.Add(Me.btnSlowGoto)
        Me.grpFocuserPresets.Controls.Add(Me.btnFastGoto)
        Me.grpFocuserPresets.Controls.Add(Me.Label17)
        Me.grpFocuserPresets.Controls.Add(Me.Label16)
        Me.grpFocuserPresets.Controls.Add(Me.Label15)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset9)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset8)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset7)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset6)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset5)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset4)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset3)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset2)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset1)
        Me.grpFocuserPresets.Controls.Add(Me.radPreset0)
        Me.grpFocuserPresets.Controls.Add(Me.txtName9)
        Me.grpFocuserPresets.Controls.Add(Me.txtName8)
        Me.grpFocuserPresets.Controls.Add(Me.txtName7)
        Me.grpFocuserPresets.Controls.Add(Me.txtName6)
        Me.grpFocuserPresets.Controls.Add(Me.txtName5)
        Me.grpFocuserPresets.Controls.Add(Me.txtName4)
        Me.grpFocuserPresets.Controls.Add(Me.txtName3)
        Me.grpFocuserPresets.Controls.Add(Me.txtName2)
        Me.grpFocuserPresets.Controls.Add(Me.txtName1)
        Me.grpFocuserPresets.Controls.Add(Me.txtName0)
        Me.grpFocuserPresets.Controls.Add(Me.Label13)
        Me.grpFocuserPresets.Controls.Add(Me.Label12)
        Me.grpFocuserPresets.Controls.Add(Me.Label11)
        Me.grpFocuserPresets.Controls.Add(Me.Label10)
        Me.grpFocuserPresets.Controls.Add(Me.Label9)
        Me.grpFocuserPresets.Controls.Add(Me.Label8)
        Me.grpFocuserPresets.Controls.Add(Me.Label7)
        Me.grpFocuserPresets.Controls.Add(Me.Label6)
        Me.grpFocuserPresets.Controls.Add(Me.Label5)
        Me.grpFocuserPresets.Controls.Add(Me.Label4)
        Me.grpFocuserPresets.Controls.Add(Me.Label3)
        Me.grpFocuserPresets.Enabled = False
        Me.grpFocuserPresets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFocuserPresets.Location = New System.Drawing.Point(355, 25)
        Me.grpFocuserPresets.Name = "grpFocuserPresets"
        Me.grpFocuserPresets.Size = New System.Drawing.Size(362, 393)
        Me.grpFocuserPresets.TabIndex = 15
        Me.grpFocuserPresets.TabStop = False
        Me.grpFocuserPresets.Text = "Focuser Position Presets"
        '
        'lblCurrPos
        '
        Me.lblCurrPos.AutoSize = True
        Me.lblCurrPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrPos.Location = New System.Drawing.Point(15, 282)
        Me.lblCurrPos.Name = "lblCurrPos"
        Me.lblCurrPos.Size = New System.Drawing.Size(97, 13)
        Me.lblCurrPos.TabIndex = 27
        Me.lblCurrPos.Text = "Current Position"
        '
        'radMoveOut
        '
        Me.radMoveOut.AutoSize = True
        Me.radMoveOut.Location = New System.Drawing.Point(336, 305)
        Me.radMoveOut.Name = "radMoveOut"
        Me.radMoveOut.Size = New System.Drawing.Size(14, 13)
        Me.radMoveOut.TabIndex = 94
        Me.radMoveOut.TabStop = True
        Me.radMoveOut.UseVisualStyleBackColor = True
        '
        'radMoveIn
        '
        Me.radMoveIn.AutoSize = True
        Me.radMoveIn.Location = New System.Drawing.Point(336, 286)
        Me.radMoveIn.Name = "radMoveIn"
        Me.radMoveIn.Size = New System.Drawing.Size(14, 13)
        Me.radMoveIn.TabIndex = 93
        Me.radMoveIn.TabStop = True
        Me.radMoveIn.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(171, 304)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 13)
        Me.Label27.TabIndex = 92
        Me.Label27.Text = "Outward Move"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(179, 284)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 91
        Me.Label26.Text = "Inward Move"
        '
        'nudMoveOut
        '
        Me.nudMoveOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMoveOut.Location = New System.Drawing.Point(253, 302)
        Me.nudMoveOut.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.nudMoveOut.Name = "nudMoveOut"
        Me.nudMoveOut.Size = New System.Drawing.Size(68, 20)
        Me.nudMoveOut.TabIndex = 90
        '
        'nudMoveIn
        '
        Me.nudMoveIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMoveIn.Location = New System.Drawing.Point(253, 282)
        Me.nudMoveIn.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.nudMoveIn.Name = "nudMoveIn"
        Me.nudMoveIn.Size = New System.Drawing.Size(68, 20)
        Me.nudMoveIn.TabIndex = 89
        '
        'nudPreset9
        '
        Me.nudPreset9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset9.Location = New System.Drawing.Point(253, 236)
        Me.nudPreset9.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudPreset9.Name = "nudPreset9"
        Me.nudPreset9.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset9.TabIndex = 88
        '
        'nudPreset8
        '
        Me.nudPreset8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset8.Location = New System.Drawing.Point(253, 216)
        Me.nudPreset8.Name = "nudPreset8"
        Me.nudPreset8.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset8.TabIndex = 87
        '
        'nudPreset7
        '
        Me.nudPreset7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset7.Location = New System.Drawing.Point(253, 196)
        Me.nudPreset7.Name = "nudPreset7"
        Me.nudPreset7.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset7.TabIndex = 86
        '
        'nudPreset6
        '
        Me.nudPreset6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset6.Location = New System.Drawing.Point(254, 176)
        Me.nudPreset6.Name = "nudPreset6"
        Me.nudPreset6.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset6.TabIndex = 85
        '
        'nudPreset5
        '
        Me.nudPreset5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset5.Location = New System.Drawing.Point(253, 156)
        Me.nudPreset5.Name = "nudPreset5"
        Me.nudPreset5.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset5.TabIndex = 84
        '
        'nudPreset4
        '
        Me.nudPreset4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset4.Location = New System.Drawing.Point(253, 136)
        Me.nudPreset4.Name = "nudPreset4"
        Me.nudPreset4.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset4.TabIndex = 83
        '
        'nudPreset3
        '
        Me.nudPreset3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset3.Location = New System.Drawing.Point(253, 116)
        Me.nudPreset3.Name = "nudPreset3"
        Me.nudPreset3.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset3.TabIndex = 82
        '
        'nudPreset2
        '
        Me.nudPreset2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset2.Location = New System.Drawing.Point(253, 96)
        Me.nudPreset2.Name = "nudPreset2"
        Me.nudPreset2.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset2.TabIndex = 81
        '
        'lblMoving
        '
        Me.lblMoving.AutoSize = True
        Me.lblMoving.Enabled = False
        Me.lblMoving.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoving.Location = New System.Drawing.Point(13, 266)
        Me.lblMoving.Name = "lblMoving"
        Me.lblMoving.Size = New System.Drawing.Size(92, 24)
        Me.lblMoving.TabIndex = 76
        Me.lblMoving.Text = "MOVING"
        Me.lblMoving.Visible = False
        '
        'nudPreset1
        '
        Me.nudPreset1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset1.Location = New System.Drawing.Point(253, 76)
        Me.nudPreset1.Name = "nudPreset1"
        Me.nudPreset1.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset1.TabIndex = 80
        '
        'nudPreset0
        '
        Me.nudPreset0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPreset0.Location = New System.Drawing.Point(253, 56)
        Me.nudPreset0.Name = "nudPreset0"
        Me.nudPreset0.Size = New System.Drawing.Size(68, 20)
        Me.nudPreset0.TabIndex = 79
        '
        'nudCurrPos
        '
        Me.nudCurrPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudCurrPos.Location = New System.Drawing.Point(253, 36)
        Me.nudCurrPos.Name = "nudCurrPos"
        Me.nudCurrPos.Size = New System.Drawing.Size(68, 20)
        Me.nudCurrPos.TabIndex = 78
        '
        'nudTarget
        '
        Me.nudTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudTarget.Location = New System.Drawing.Point(253, 262)
        Me.nudTarget.Maximum = New Decimal(New Integer() {80000, 0, 0, 0})
        Me.nudTarget.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTarget.Name = "nudTarget"
        Me.nudTarget.Size = New System.Drawing.Size(68, 20)
        Me.nudTarget.TabIndex = 77
        Me.nudTarget.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'radTarget
        '
        Me.radTarget.AutoSize = True
        Me.radTarget.Location = New System.Drawing.Point(336, 267)
        Me.radTarget.Name = "radTarget"
        Me.radTarget.Size = New System.Drawing.Size(14, 13)
        Me.radTarget.TabIndex = 72
        Me.radTarget.TabStop = True
        Me.radTarget.UseVisualStyleBackColor = True
        '
        'btnSlowOut
        '
        Me.btnSlowOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlowOut.Location = New System.Drawing.Point(160, 362)
        Me.btnSlowOut.Name = "btnSlowOut"
        Me.btnSlowOut.Size = New System.Drawing.Size(65, 24)
        Me.btnSlowOut.TabIndex = 71
        Me.btnSlowOut.Text = "Slow Out"
        Me.btnSlowOut.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(206, 266)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Target"
        '
        'btnFastOut
        '
        Me.btnFastOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastOut.Location = New System.Drawing.Point(160, 330)
        Me.btnFastOut.Name = "btnFastOut"
        Me.btnFastOut.Size = New System.Drawing.Size(65, 24)
        Me.btnFastOut.TabIndex = 70
        Me.btnFastOut.Text = "Fast Out"
        Me.btnFastOut.UseVisualStyleBackColor = True
        '
        'btnSlowIn
        '
        Me.btnSlowIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlowIn.Location = New System.Drawing.Point(89, 362)
        Me.btnSlowIn.Name = "btnSlowIn"
        Me.btnSlowIn.Size = New System.Drawing.Size(65, 24)
        Me.btnSlowIn.TabIndex = 69
        Me.btnSlowIn.Text = "Slow In"
        Me.btnSlowIn.UseVisualStyleBackColor = True
        '
        'txtCurrPos
        '
        Me.txtCurrPos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtCurrPos.Enabled = False
        Me.txtCurrPos.Location = New System.Drawing.Point(16, 299)
        Me.txtCurrPos.Name = "txtCurrPos"
        Me.txtCurrPos.Size = New System.Drawing.Size(96, 20)
        Me.txtCurrPos.TabIndex = 72
        Me.txtCurrPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnFastIn
        '
        Me.btnFastIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastIn.Location = New System.Drawing.Point(89, 330)
        Me.btnFastIn.Name = "btnFastIn"
        Me.btnFastIn.Size = New System.Drawing.Size(65, 24)
        Me.btnFastIn.TabIndex = 68
        Me.btnFastIn.Text = "Fast In"
        Me.btnFastIn.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(231, 330)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(90, 56)
        Me.btnStop.TabIndex = 67
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnSlowGoto
        '
        Me.btnSlowGoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSlowGoto.Location = New System.Drawing.Point(18, 362)
        Me.btnSlowGoto.Name = "btnSlowGoto"
        Me.btnSlowGoto.Size = New System.Drawing.Size(65, 24)
        Me.btnSlowGoto.TabIndex = 66
        Me.btnSlowGoto.Text = "Goto Slow"
        Me.btnSlowGoto.UseVisualStyleBackColor = True
        '
        'btnFastGoto
        '
        Me.btnFastGoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFastGoto.Location = New System.Drawing.Point(18, 330)
        Me.btnFastGoto.Name = "btnFastGoto"
        Me.btnFastGoto.Size = New System.Drawing.Size(65, 24)
        Me.btnFastGoto.TabIndex = 65
        Me.btnFastGoto.Text = "Goto Fast"
        Me.btnFastGoto.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(319, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Select"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(254, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Position"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(95, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Name"
        '
        'radPreset9
        '
        Me.radPreset9.AutoSize = True
        Me.radPreset9.Location = New System.Drawing.Point(336, 239)
        Me.radPreset9.Name = "radPreset9"
        Me.radPreset9.Size = New System.Drawing.Size(14, 13)
        Me.radPreset9.TabIndex = 60
        Me.radPreset9.TabStop = True
        Me.radPreset9.UseVisualStyleBackColor = True
        '
        'radPreset8
        '
        Me.radPreset8.AutoSize = True
        Me.radPreset8.Location = New System.Drawing.Point(336, 219)
        Me.radPreset8.Name = "radPreset8"
        Me.radPreset8.Size = New System.Drawing.Size(14, 13)
        Me.radPreset8.TabIndex = 59
        Me.radPreset8.TabStop = True
        Me.radPreset8.UseVisualStyleBackColor = True
        '
        'radPreset7
        '
        Me.radPreset7.AutoSize = True
        Me.radPreset7.Location = New System.Drawing.Point(336, 199)
        Me.radPreset7.Name = "radPreset7"
        Me.radPreset7.Size = New System.Drawing.Size(14, 13)
        Me.radPreset7.TabIndex = 58
        Me.radPreset7.TabStop = True
        Me.radPreset7.UseVisualStyleBackColor = True
        '
        'radPreset6
        '
        Me.radPreset6.AutoSize = True
        Me.radPreset6.Location = New System.Drawing.Point(336, 179)
        Me.radPreset6.Name = "radPreset6"
        Me.radPreset6.Size = New System.Drawing.Size(14, 13)
        Me.radPreset6.TabIndex = 57
        Me.radPreset6.TabStop = True
        Me.radPreset6.UseVisualStyleBackColor = True
        '
        'radPreset5
        '
        Me.radPreset5.AutoSize = True
        Me.radPreset5.Location = New System.Drawing.Point(336, 159)
        Me.radPreset5.Name = "radPreset5"
        Me.radPreset5.Size = New System.Drawing.Size(14, 13)
        Me.radPreset5.TabIndex = 56
        Me.radPreset5.TabStop = True
        Me.radPreset5.UseVisualStyleBackColor = True
        '
        'radPreset4
        '
        Me.radPreset4.AutoSize = True
        Me.radPreset4.Location = New System.Drawing.Point(336, 139)
        Me.radPreset4.Name = "radPreset4"
        Me.radPreset4.Size = New System.Drawing.Size(14, 13)
        Me.radPreset4.TabIndex = 55
        Me.radPreset4.TabStop = True
        Me.radPreset4.UseVisualStyleBackColor = True
        '
        'radPreset3
        '
        Me.radPreset3.AutoSize = True
        Me.radPreset3.Location = New System.Drawing.Point(336, 119)
        Me.radPreset3.Name = "radPreset3"
        Me.radPreset3.Size = New System.Drawing.Size(14, 13)
        Me.radPreset3.TabIndex = 54
        Me.radPreset3.TabStop = True
        Me.radPreset3.UseVisualStyleBackColor = True
        '
        'radPreset2
        '
        Me.radPreset2.AutoSize = True
        Me.radPreset2.Location = New System.Drawing.Point(336, 99)
        Me.radPreset2.Name = "radPreset2"
        Me.radPreset2.Size = New System.Drawing.Size(14, 13)
        Me.radPreset2.TabIndex = 53
        Me.radPreset2.TabStop = True
        Me.radPreset2.UseVisualStyleBackColor = True
        '
        'radPreset1
        '
        Me.radPreset1.AutoSize = True
        Me.radPreset1.Location = New System.Drawing.Point(336, 79)
        Me.radPreset1.Name = "radPreset1"
        Me.radPreset1.Size = New System.Drawing.Size(14, 13)
        Me.radPreset1.TabIndex = 52
        Me.radPreset1.TabStop = True
        Me.radPreset1.UseVisualStyleBackColor = True
        '
        'radPreset0
        '
        Me.radPreset0.AutoSize = True
        Me.radPreset0.Location = New System.Drawing.Point(336, 59)
        Me.radPreset0.Name = "radPreset0"
        Me.radPreset0.Size = New System.Drawing.Size(14, 13)
        Me.radPreset0.TabIndex = 51
        Me.radPreset0.UseVisualStyleBackColor = True
        '
        'txtName9
        '
        Me.txtName9.BackColor = System.Drawing.SystemColors.Info
        Me.txtName9.Enabled = False
        Me.txtName9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName9.Location = New System.Drawing.Point(65, 237)
        Me.txtName9.Name = "txtName9"
        Me.txtName9.Size = New System.Drawing.Size(183, 20)
        Me.txtName9.TabIndex = 35
        Me.txtName9.Text = "Upper Limit"
        '
        'txtName8
        '
        Me.txtName8.BackColor = System.Drawing.SystemColors.Window
        Me.txtName8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName8.Location = New System.Drawing.Point(65, 217)
        Me.txtName8.Name = "txtName8"
        Me.txtName8.Size = New System.Drawing.Size(183, 20)
        Me.txtName8.TabIndex = 34
        Me.txtName8.Text = "Position 8"
        '
        'txtName7
        '
        Me.txtName7.BackColor = System.Drawing.SystemColors.Window
        Me.txtName7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName7.Location = New System.Drawing.Point(65, 197)
        Me.txtName7.Name = "txtName7"
        Me.txtName7.Size = New System.Drawing.Size(183, 20)
        Me.txtName7.TabIndex = 33
        Me.txtName7.Text = "Position 7"
        '
        'txtName6
        '
        Me.txtName6.BackColor = System.Drawing.SystemColors.Window
        Me.txtName6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName6.Location = New System.Drawing.Point(65, 177)
        Me.txtName6.Name = "txtName6"
        Me.txtName6.Size = New System.Drawing.Size(183, 20)
        Me.txtName6.TabIndex = 32
        Me.txtName6.Text = "Position 6"
        '
        'txtName5
        '
        Me.txtName5.BackColor = System.Drawing.SystemColors.Window
        Me.txtName5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName5.Location = New System.Drawing.Point(65, 157)
        Me.txtName5.Name = "txtName5"
        Me.txtName5.Size = New System.Drawing.Size(183, 20)
        Me.txtName5.TabIndex = 31
        Me.txtName5.Text = "Position 5"
        '
        'txtName4
        '
        Me.txtName4.BackColor = System.Drawing.SystemColors.Window
        Me.txtName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName4.Location = New System.Drawing.Point(65, 137)
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(183, 20)
        Me.txtName4.TabIndex = 30
        Me.txtName4.Text = "Position 4"
        '
        'txtName3
        '
        Me.txtName3.BackColor = System.Drawing.SystemColors.Window
        Me.txtName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName3.Location = New System.Drawing.Point(65, 117)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(183, 20)
        Me.txtName3.TabIndex = 29
        Me.txtName3.Text = "Position 3"
        '
        'txtName2
        '
        Me.txtName2.BackColor = System.Drawing.SystemColors.Window
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName2.Location = New System.Drawing.Point(65, 97)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(183, 20)
        Me.txtName2.TabIndex = 28
        Me.txtName2.Text = "Position 2"
        '
        'txtName1
        '
        Me.txtName1.BackColor = System.Drawing.SystemColors.Window
        Me.txtName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName1.Location = New System.Drawing.Point(65, 77)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(183, 20)
        Me.txtName1.TabIndex = 27
        Me.txtName1.Text = "Position 1"
        '
        'txtName0
        '
        Me.txtName0.BackColor = System.Drawing.SystemColors.Info
        Me.txtName0.Enabled = False
        Me.txtName0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName0.Location = New System.Drawing.Point(65, 57)
        Me.txtName0.Name = "txtName0"
        Me.txtName0.Size = New System.Drawing.Size(183, 20)
        Me.txtName0.TabIndex = 26
        Me.txtName0.Text = "Home"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Preset 9"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Preset 8"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Preset 7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Preset 6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Preset 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Preset 4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Preset 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Preset 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Preset 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Preset 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current Position"
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(269, 57)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(72, 33)
        Me.btnCheck.TabIndex = 19
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 34)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "TopBox Buddy"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(14, 66)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(140, 13)
        Me.label2.TabIndex = 21
        Me.label2.Text = "Select COM port for TopBox"
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.Location = New System.Drawing.Point(17, 99)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(324, 30)
        Me.lstDetails.TabIndex = 22
        '
        'grpMode
        '
        Me.grpMode.Controls.Add(Me.radRelative)
        Me.grpMode.Controls.Add(Me.radAbsolute)
        Me.grpMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMode.Location = New System.Drawing.Point(188, 138)
        Me.grpMode.Name = "grpMode"
        Me.grpMode.Size = New System.Drawing.Size(153, 66)
        Me.grpMode.TabIndex = 23
        Me.grpMode.TabStop = False
        Me.grpMode.Text = "Focuser Mode"
        '
        'radRelative
        '
        Me.radRelative.AutoSize = True
        Me.radRelative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRelative.Location = New System.Drawing.Point(6, 20)
        Me.radRelative.Name = "radRelative"
        Me.radRelative.Size = New System.Drawing.Size(64, 17)
        Me.radRelative.TabIndex = 10
        Me.radRelative.TabStop = True
        Me.radRelative.Text = "Relative"
        Me.radRelative.UseVisualStyleBackColor = True
        '
        'radAbsolute
        '
        Me.radAbsolute.AutoSize = True
        Me.radAbsolute.Checked = True
        Me.radAbsolute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAbsolute.Location = New System.Drawing.Point(6, 40)
        Me.radAbsolute.Name = "radAbsolute"
        Me.radAbsolute.Size = New System.Drawing.Size(66, 17)
        Me.radAbsolute.TabIndex = 11
        Me.radAbsolute.TabStop = True
        Me.radAbsolute.Text = "Absolute"
        Me.radAbsolute.UseVisualStyleBackColor = True
        '
        'grpSwitches
        '
        Me.grpSwitches.Controls.Add(Me.Label23)
        Me.grpSwitches.Controls.Add(Me.Label22)
        Me.grpSwitches.Controls.Add(Me.Label19)
        Me.grpSwitches.Controls.Add(Me.Label18)
        Me.grpSwitches.Controls.Add(Me.Label14)
        Me.grpSwitches.Controls.Add(Me.btnSpare)
        Me.grpSwitches.Controls.Add(Me.btnMFP)
        Me.grpSwitches.Controls.Add(Me.btnDew2)
        Me.grpSwitches.Controls.Add(Me.btnDew1)
        Me.grpSwitches.Controls.Add(Me.btnCCD)
        Me.grpSwitches.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpSwitches.Enabled = False
        Me.grpSwitches.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSwitches.Location = New System.Drawing.Point(17, 138)
        Me.grpSwitches.Name = "grpSwitches"
        Me.grpSwitches.Size = New System.Drawing.Size(165, 170)
        Me.grpSwitches.TabIndex = 24
        Me.grpSwitches.TabStop = False
        Me.grpSwitches.Text = "Power Switches"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Spare"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(18, 111)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "myFocuserPro"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 83)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Dew Heater 2"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Dew Heater 1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "CCD Power"
        '
        'btnSpare
        '
        Me.btnSpare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSpare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpare.Location = New System.Drawing.Point(111, 134)
        Me.btnSpare.Name = "btnSpare"
        Me.btnSpare.Size = New System.Drawing.Size(43, 22)
        Me.btnSpare.TabIndex = 4
        Me.btnSpare.UseVisualStyleBackColor = True
        '
        'btnMFP
        '
        Me.btnMFP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMFP.Location = New System.Drawing.Point(111, 106)
        Me.btnMFP.Name = "btnMFP"
        Me.btnMFP.Size = New System.Drawing.Size(43, 22)
        Me.btnMFP.TabIndex = 3
        Me.btnMFP.UseVisualStyleBackColor = True
        '
        'btnDew2
        '
        Me.btnDew2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDew2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDew2.Location = New System.Drawing.Point(111, 78)
        Me.btnDew2.Name = "btnDew2"
        Me.btnDew2.Size = New System.Drawing.Size(43, 22)
        Me.btnDew2.TabIndex = 2
        Me.btnDew2.UseVisualStyleBackColor = True
        '
        'btnDew1
        '
        Me.btnDew1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDew1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDew1.Location = New System.Drawing.Point(111, 49)
        Me.btnDew1.Name = "btnDew1"
        Me.btnDew1.Size = New System.Drawing.Size(43, 22)
        Me.btnDew1.TabIndex = 1
        Me.btnDew1.UseVisualStyleBackColor = True
        '
        'btnCCD
        '
        Me.btnCCD.BackColor = System.Drawing.SystemColors.Control
        Me.btnCCD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCCD.Location = New System.Drawing.Point(111, 22)
        Me.btnCCD.Name = "btnCCD"
        Me.btnCCD.Size = New System.Drawing.Size(43, 22)
        Me.btnCCD.TabIndex = 0
        Me.btnCCD.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRetrieve.Location = New System.Drawing.Point(163, 385)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(67, 23)
        Me.btnRetrieve.TabIndex = 24
        Me.btnRetrieve.Text = "Retrieve"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(236, 385)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(67, 23)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'grpBacklash
        '
        Me.grpBacklash.Controls.Add(Me.Label24)
        Me.grpBacklash.Controls.Add(Me.nudBacklash)
        Me.grpBacklash.Controls.Add(Me.radInward)
        Me.grpBacklash.Controls.Add(Me.radOutward)
        Me.grpBacklash.Controls.Add(Me.radBacklashDisabled)
        Me.grpBacklash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBacklash.Location = New System.Drawing.Point(188, 211)
        Me.grpBacklash.Name = "grpBacklash"
        Me.grpBacklash.Size = New System.Drawing.Size(153, 140)
        Me.grpBacklash.TabIndex = 25
        Me.grpBacklash.TabStop = False
        Me.grpBacklash.Text = "Backlash Allowance"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Steps (centiseconds)"
        '
        'nudBacklash
        '
        Me.nudBacklash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBacklash.Location = New System.Drawing.Point(6, 107)
        Me.nudBacklash.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudBacklash.Name = "nudBacklash"
        Me.nudBacklash.Size = New System.Drawing.Size(120, 20)
        Me.nudBacklash.TabIndex = 4
        '
        'radInward
        '
        Me.radInward.AutoSize = True
        Me.radInward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInward.Location = New System.Drawing.Point(6, 60)
        Me.radInward.Name = "radInward"
        Me.radInward.Size = New System.Drawing.Size(109, 17)
        Me.radInward.TabIndex = 3
        Me.radInward.Text = "On Inward Moves"
        Me.radInward.UseVisualStyleBackColor = True
        '
        'radOutward
        '
        Me.radOutward.AutoSize = True
        Me.radOutward.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOutward.Location = New System.Drawing.Point(6, 40)
        Me.radOutward.Name = "radOutward"
        Me.radOutward.Size = New System.Drawing.Size(117, 17)
        Me.radOutward.TabIndex = 2
        Me.radOutward.Text = "On Outward Moves"
        Me.radOutward.UseVisualStyleBackColor = True
        '
        'radBacklashDisabled
        '
        Me.radBacklashDisabled.AutoSize = True
        Me.radBacklashDisabled.Checked = True
        Me.radBacklashDisabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBacklashDisabled.Location = New System.Drawing.Point(6, 20)
        Me.radBacklashDisabled.Name = "radBacklashDisabled"
        Me.radBacklashDisabled.Size = New System.Drawing.Size(66, 17)
        Me.radBacklashDisabled.TabIndex = 1
        Me.radBacklashDisabled.TabStop = True
        Me.radBacklashDisabled.Text = "Disabled"
        Me.radBacklashDisabled.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(275, 13)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "By Keith Rickard - keithrickard@hotmail.com  V0.210214"
        '
        'lblRetrieve
        '
        Me.lblRetrieve.AutoSize = True
        Me.lblRetrieve.Enabled = False
        Me.lblRetrieve.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetrieve.Location = New System.Drawing.Point(162, 353)
        Me.lblRetrieve.Name = "lblRetrieve"
        Me.lblRetrieve.Size = New System.Drawing.Size(151, 24)
        Me.lblRetrieve.TabIndex = 77
        Me.lblRetrieve.Text = "Retrieving Data"
        Me.lblRetrieve.Visible = False
        '
        'lblUpdating
        '
        Me.lblUpdating.AutoSize = True
        Me.lblUpdating.Enabled = False
        Me.lblUpdating.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdating.Location = New System.Drawing.Point(162, 353)
        Me.lblUpdating.Name = "lblUpdating"
        Me.lblUpdating.Size = New System.Drawing.Size(140, 24)
        Me.lblUpdating.TabIndex = 78
        Me.lblUpdating.Text = "Updating Data"
        Me.lblUpdating.Visible = False
        '
        'SetupDialogForm
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(735, 424)
        Me.Controls.Add(Me.lblUpdating)
        Me.Controls.Add(Me.lblRetrieve)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.grpBacklash)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.grpSwitches)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.grpMode)
        Me.Controls.Add(Me.lstDetails)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.grpFocuserPresets)
        Me.Controls.Add(Me.ComboBoxComPort)
        Me.Controls.Add(Me.chkTrace)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupDialogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TopBox Buddy Setup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFocuserPresets.ResumeLayout(False)
        Me.grpFocuserPresets.PerformLayout()
        CType(Me.nudMoveOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMoveIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPreset0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCurrPos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMode.ResumeLayout(False)
        Me.grpMode.PerformLayout()
        Me.grpSwitches.ResumeLayout(False)
        Me.grpSwitches.PerformLayout()
        Me.grpBacklash.ResumeLayout(False)
        Me.grpBacklash.PerformLayout()
        CType(Me.nudBacklash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkTrace As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBoxComPort As System.Windows.Forms.ComboBox
    Friend WithEvents grpFocuserPresets As GroupBox
    Friend WithEvents lblMoving As Label
    Friend WithEvents radTarget As RadioButton
    Friend WithEvents btnSlowOut As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btnFastOut As Button
    Friend WithEvents btnSlowIn As Button
    Friend WithEvents txtCurrPos As TextBox
    Friend WithEvents btnFastIn As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnSlowGoto As Button
    Friend WithEvents btnFastGoto As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents radPreset9 As RadioButton
    Friend WithEvents radPreset8 As RadioButton
    Friend WithEvents radPreset7 As RadioButton
    Friend WithEvents radPreset6 As RadioButton
    Friend WithEvents radPreset5 As RadioButton
    Friend WithEvents radPreset4 As RadioButton
    Friend WithEvents radPreset3 As RadioButton
    Friend WithEvents radPreset2 As RadioButton
    Friend WithEvents radPreset1 As RadioButton
    Friend WithEvents radPreset0 As RadioButton
    Friend WithEvents txtName9 As TextBox
    Friend WithEvents txtName8 As TextBox
    Friend WithEvents txtName7 As TextBox
    Friend WithEvents txtName6 As TextBox
    Friend WithEvents txtName5 As TextBox
    Friend WithEvents txtName4 As TextBox
    Friend WithEvents txtName3 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName0 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents Label1 As Label
    Private WithEvents label2 As Label
    Friend WithEvents lstDetails As ListBox
    Friend WithEvents grpMode As GroupBox
    Friend WithEvents radRelative As RadioButton
    Friend WithEvents radAbsolute As RadioButton
    Friend WithEvents grpSwitches As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSpare As Button
    Friend WithEvents btnMFP As Button
    Friend WithEvents btnDew2 As Button
    Friend WithEvents btnDew1 As Button
    Friend WithEvents btnCCD As Button
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents nudTarget As NumericUpDown
    Friend WithEvents grpBacklash As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents nudBacklash As NumericUpDown
    Friend WithEvents radInward As RadioButton
    Friend WithEvents radOutward As RadioButton
    Friend WithEvents radBacklashDisabled As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents nudPreset9 As NumericUpDown
    Friend WithEvents nudPreset8 As NumericUpDown
    Friend WithEvents nudPreset7 As NumericUpDown
    Friend WithEvents nudPreset6 As NumericUpDown
    Friend WithEvents nudPreset5 As NumericUpDown
    Friend WithEvents nudPreset4 As NumericUpDown
    Friend WithEvents nudPreset3 As NumericUpDown
    Friend WithEvents nudPreset2 As NumericUpDown
    Friend WithEvents nudPreset1 As NumericUpDown
    Friend WithEvents nudPreset0 As NumericUpDown
    Friend WithEvents nudCurrPos As NumericUpDown
    Friend WithEvents radMoveOut As RadioButton
    Friend WithEvents radMoveIn As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents nudMoveOut As NumericUpDown
    Friend WithEvents nudMoveIn As NumericUpDown
    Friend WithEvents lblCurrPos As Label
    Friend WithEvents lblRetrieve As Label
    Friend WithEvents lblUpdating As Label
End Class
