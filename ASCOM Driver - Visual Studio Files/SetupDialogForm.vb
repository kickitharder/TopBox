Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.IO.Ports
Imports ASCOM.TopBox
Imports ASCOM.Utilities
Imports System.Math

<ComVisible(False)>
Public Class SetupDialogForm
    Dim serialError As Boolean = True
    Dim resp(25) As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click ' OK button event handler
        ' Persist new values of user settings to the ASCOM profile
        Dim backlash As Decimal = nudBacklash.Value
        If radBacklashDisabled.Checked = True Then backlash = 0
        If radInward.Checked Then backlash = -backlash
        Focuser.backlashInfo = CStr(backlash)
        Focuser.absoluteMode = radAbsolute.Checked
        Focuser.comPort = ComboBoxComPort.SelectedItem ' Update the state variables with results from the dialogue
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click 'Cancel button event handler
        SerialCmd("a")
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowAscomWebPage(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick, PictureBox1.Click
        ' Click on ASCOM logo event handler
        Try
            System.Diagnostics.Process.Start("http://ascom-standards.org/")
        Catch noBrowser As System.ComponentModel.Win32Exception
            If noBrowser.ErrorCode = -2147467259 Then
                MessageBox.Show(noBrowser.Message)
            End If
        Catch other As System.Exception
            MessageBox.Show(other.Message)
        End Try
    End Sub

    Private Sub SetupDialogForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load ' Form load event handler
        ' Retrieve current values of user settings from the ASCOM Profile
        InitUI()
    End Sub

    Private Sub InitUI()
        Dim backlash As Integer = Val(Focuser.backlashInfo)
        DisableControls()
        radAbsolute.Checked = Focuser.absoluteMode
        radRelative.Checked = Not (Focuser.absoluteMode)
        Select Case backlash
            Case 0
                radBacklashDisabled.Checked = True
            Case Is < 0
                radInward.Checked = True
            Case Is > 0
                radOutward.Checked = True
        End Select
        nudBacklash.Value = Abs(backlash)
        ' set the list of com ports to those that are currently available
        ComboBoxComPort.Items.Clear()
        ComboBoxComPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames())       ' use System.IO because it's static
        ' select the current port if possible
        If ComboBoxComPort.Items.Contains(Focuser.comPort) Then
            ComboBoxComPort.SelectedItem = Focuser.comPort
        End If
    End Sub
    Private Function SerialCmd(cmdStr As String) As String
        If serialError Then Return ""
        Dim retStr As String = ""
        Dim objSerial As New SerialPort
        cmdStr += vbCrLf

        Try
            With objSerial
                .PortName = ComboBoxComPort.SelectedItem.ToString
                .BaudRate = 9600
                .ReadTimeout = 1000
                .WriteTimeout = 1000
                .Open()
                .Write(cmdStr)
            End With
            retStr = objSerial.ReadTo(vbCrLf)
        Catch ex As Exception
            lstDetails.Items.Clear()
            lstDetails.Items.Add("TopBox driver is unable to open" + objSerial.PortName)
            retStr = ""
            serialError = True
            DisableControls()
        End Try

        Try
            objSerial.Close()
        Catch ex As Exception
        End Try

        Return retStr

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ServiceTimer()

    End Sub

    Sub ServiceTimer()
        nudCurrPos.Enabled = False
        btnFastGoto.Enabled = False
        btnSlowGoto.Enabled = False
        btnFastIn.Enabled = False
        btnFastOut.Enabled = False
        btnSlowIn.Enabled = False
        btnSlowOut.Enabled = False
        lblMoving.Visible = (SerialCmd("I") = "1")
        lblCurrPos.Visible = Not (lblMoving.Visible)
        If lblMoving.Visible = False Then
            Timer1.Stop()
            nudCurrPos.Enabled = True
            btnFastGoto.Enabled = True
            btnSlowGoto.Enabled = True
            btnFastIn.Enabled = True
            btnFastOut.Enabled = True
            btnSlowIn.Enabled = True
            btnSlowOut.Enabled = True
        End If
        txtCurrPos.Text = SerialCmd("P")
        nudCurrPos.Value = txtCurrPos.Text

    End Sub
    Private Sub DisableControls()
        SerialCmd("a")
        grpFocuserPresets.Enabled = False
        grpSwitches.Enabled = False
        btnRetrieve.Enabled = False
        btnUpdate.Enabled = False
        Timer1.Stop()
    End Sub

    Private Sub EnableControls()
        SerialCmd("A")
        grpFocuserPresets.Enabled = True
        grpSwitches.Enabled = True
        btnRetrieve.Enabled = True
        btnUpdate.Enabled = False
        ServiceTimer()
    End Sub

    Private Sub updateArduino()
        If btnUpdate.Enabled = False Then Return
        lblUpdating.Visible = True
        If CDec(resp(0)) <> nudPreset0.Value Then SerialCmd("z" + CStr(nudPreset0.Value) + "e0")
        If CDec(resp(1)) <> nudPreset1.Value Then SerialCmd("z" + CStr(nudPreset1.Value) + "e1")
        If CDec(resp(2)) <> nudPreset2.Value Then SerialCmd("z" + CStr(nudPreset2.Value) + "e2")
        If CDec(resp(3)) <> nudPreset3.Value Then SerialCmd("z" + CStr(nudPreset3.Value) + "e3")
        If CDec(resp(4)) <> nudPreset4.Value Then SerialCmd("z" + CStr(nudPreset4.Value) + "e4")
        If CDec(resp(5)) <> nudPreset5.Value Then SerialCmd("z" + CStr(nudPreset5.Value) + "e5")
        If CDec(resp(6)) <> nudPreset6.Value Then SerialCmd("z" + CStr(nudPreset6.Value) + "e6")
        If CDec(resp(7)) <> nudPreset7.Value Then SerialCmd("z" + CStr(nudPreset7.Value) + "e7")
        If CDec(resp(8)) <> nudPreset8.Value Then SerialCmd("z" + CStr(nudPreset8.Value) + "e8")
        If CDec(resp(9)) <> nudPreset9.Value Then SerialCmd("z" + CStr(nudPreset9.Value) + "e9")
        If CDec(resp(20)) <> nudCurrPos.Value Then SerialCmd("p" + CStr(nudCurrPos.Value))
        If resp(11) <> txtName1.Text Then SerialCmd("n1" + txtName1.Text + "#")
        If resp(12) <> txtName2.Text Then SerialCmd("n2" + txtName2.Text + "#")
        If resp(13) <> txtName3.Text Then SerialCmd("n3" + txtName3.Text + "#")
        If resp(14) <> txtName4.Text Then SerialCmd("n4" + txtName4.Text + "#")
        If resp(15) <> txtName5.Text Then SerialCmd("n5" + txtName5.Text + "#")
        If resp(16) <> txtName6.Text Then SerialCmd("n6" + txtName6.Text + "#")
        If resp(17) <> txtName7.Text Then SerialCmd("n7" + txtName7.Text + "#")
        If resp(18) <> txtName8.Text Then SerialCmd("n8" + txtName8.Text + "#")
        btnUpdate.Enabled = False
        lblUpdating.Visible = False

    End Sub
    Private Sub retrieve()
        Do Until SerialCmd("A") = "A"
            If serialError = True Then Return
        Loop
        lblRetrieve.Visible = True
        resp(0) = SerialCmd("E0")
        resp(1) = SerialCmd("E1")
        resp(2) = SerialCmd("E2")
        resp(3) = SerialCmd("E3")
        resp(4) = SerialCmd("E4")
        resp(5) = SerialCmd("E5")
        resp(6) = SerialCmd("E6")
        resp(7) = SerialCmd("E7")
        resp(8) = SerialCmd("E8")
        resp(9) = SerialCmd("E9")
        resp(10) = SerialCmd("N0")
        resp(11) = SerialCmd("N1")
        resp(12) = SerialCmd("N2")
        resp(13) = SerialCmd("N3")
        resp(14) = SerialCmd("N4")
        resp(15) = SerialCmd("N5")
        resp(16) = SerialCmd("N6")
        resp(17) = SerialCmd("N7")
        resp(18) = SerialCmd("N8")
        resp(19) = SerialCmd("N9")
        resp(20) = SerialCmd("P")
        resp(21) = SerialCmd("=C")
        resp(22) = SerialCmd("=T")
        resp(23) = SerialCmd("=L")
        resp(24) = SerialCmd("=M")
        resp(25) = SerialCmd("=X")
        resp(25) = SerialCmd("=X")
        lblRetrieve.Visible = False
        If serialError Then Return
        btnUpdate.Enabled = False
        nudPreset9.Maximum = 100000
        nudPreset9.Value = CDec(resp(9))
        PresetRanges()
        nudPreset0.Value = CDec(resp(0))
        nudPreset1.Value = CDec(resp(1))
        nudPreset2.Value = CDec(resp(2))
        nudPreset3.Value = CDec(resp(3))
        nudPreset4.Value = CDec(resp(4))
        nudPreset5.Value = CDec(resp(5))
        nudPreset6.Value = CDec(resp(6))
        nudPreset7.Value = CDec(resp(7))
        nudPreset8.Value = CDec(resp(8))
        txtName0.Text = resp(10)
        txtName1.Text = resp(11)
        txtName2.Text = resp(12)
        txtName3.Text = resp(13)
        txtName4.Text = resp(14)
        txtName5.Text = resp(15)
        txtName6.Text = resp(16)
        txtName7.Text = resp(17)
        txtName8.Text = resp(18)
        txtName9.Text = resp(19)
        txtCurrPos.Text = resp(20)
        nudTarget.Value = CDec(resp(20))
        radTarget.Checked = True

        If resp(21) = "0" Then btnCCD.Text = "OFF"
        If resp(21) = "1" Then btnCCD.Text = "ON"
        If resp(22) = "0" Then btnDew1.Text = "OFF"
        If resp(22) = "1" Then btnDew1.Text = "ON"
        If resp(23) = "0" Then btnDew2.Text = "OFF"
        If resp(23) = "1" Then btnDew2.Text = "ON"
        If resp(24) = "0" Then btnMFP.Text = "OFF"
        If resp(24) = "1" Then btnMFP.Text = "ON"
        If resp(25) = "0" Then btnSpare.Text = "OFF"
        If resp(25) = "1" Then btnSpare.Text = "ON"

    End Sub
    Private Sub PresetRanges()
        nudCurrPos.Minimum = 1
        nudPreset0.Minimum = 1
        nudPreset1.Minimum = 1
        nudPreset2.Minimum = 1
        nudPreset3.Minimum = 1
        nudPreset4.Minimum = 1
        nudPreset5.Minimum = 1
        nudPreset6.Minimum = 1
        nudPreset7.Minimum = 1
        nudPreset8.Minimum = 1
        nudPreset9.Minimum = 1
        nudTarget.Minimum = 1
        nudCurrPos.Maximum = nudPreset9.Value
        nudPreset0.Maximum = nudPreset9.Value
        nudPreset1.Maximum = nudPreset9.Value
        nudPreset2.Maximum = nudPreset9.Value
        nudPreset3.Maximum = nudPreset9.Value
        nudPreset4.Maximum = nudPreset9.Value
        nudPreset5.Maximum = nudPreset9.Value
        nudPreset6.Maximum = nudPreset9.Value
        nudPreset7.Maximum = nudPreset9.Value
        nudPreset8.Maximum = nudPreset9.Value
        nudPreset9.Maximum = 100000
        nudTarget.Maximum = nudPreset9.Value

    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim respStr As String = ""
        Dim i As Integer
        serialError = False
        lstDetails.Items.Clear()
        For i = 1 To 10
            respStr = SerialCmd("V")
            If serialError = 1 Then Exit Sub
        Next

        If respStr.StartsWith("TopBox") Then
            lstDetails.Items.Add(respStr)
            lstDetails.Items.Add("TopBox is OK")
            retrieve()
            EnableControls()
        Else
            lstDetails.Items.Add("TopBox not responding - check connection")
        End If

    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click
        retrieve()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateArduino()

    End Sub

    Private Sub btnCCD_Click(sender As Object, e As EventArgs) Handles btnCCD.Click
        If btnCCD.Text = "OFF" Then
            btnCCD.Text = "ON"
            SerialCmd("C")
        Else
            btnCCD.Text = "OFF"
            SerialCmd("c")
        End If

    End Sub

    Private Sub btnDew1_Click(sender As Object, e As EventArgs) Handles btnDew1.Click
        If btnDew1.Text = "OFF" Then
            btnDew1.Text = "ON"
            SerialCmd("T")
        Else
            btnDew1.Text = "OFF"
            SerialCmd("t")
        End If

    End Sub

    Private Sub btnDew2_Click(sender As Object, e As EventArgs) Handles btnDew2.Click
        If btnDew2.Text = "OFF" Then
            btnDew2.Text = "ON"
            SerialCmd("L")
        Else
            btnDew2.Text = "OFF"
            SerialCmd("l")
        End If

    End Sub

    Private Sub btnMFP_Click(sender As Object, e As EventArgs) Handles btnMFP.Click
        If btnMFP.Text = "OFF" Then
            btnMFP.Text = "ON"
            SerialCmd("M")
        Else
            btnMFP.Text = "OFF"
            SerialCmd("m")
        End If

    End Sub

    Private Sub btnSpare_Click(sender As Object, e As EventArgs) Handles btnSpare.Click
        If btnSpare.Text = "OFF" Then
            btnSpare.Text = "ON"
            SerialCmd("X")
        Else
            btnSpare.Text = "OFF"
            SerialCmd("x")
        End If

    End Sub

    Private Sub btnFastGoto_Click(sender As Object, e As EventArgs) Handles btnFastGoto.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("G" + getPreset())

    End Sub

    Private Sub btnSlowGoto_Click(sender As Object, e As EventArgs) Handles btnSlowGoto.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("g" + getPreset())

    End Sub
    Private Function getPreset() As String
        Dim preset As Decimal = nudCurrPos.Value
        If radMoveIn.Checked Then preset -= nudMoveIn.Value
        If radMoveOut.Checked Then preset += nudMoveOut.Value
        If radTarget.Checked Then preset = nudTarget.Value
        If radPreset0.Checked Then preset = nudPreset0.Value
        If radPreset1.Checked Then preset = nudPreset1.Value
        If radPreset2.Checked Then preset = nudPreset2.Value
        If radPreset3.Checked Then preset = nudPreset3.Value
        If radPreset4.Checked Then preset = nudPreset4.Value
        If radPreset5.Checked Then preset = nudPreset5.Value
        If radPreset6.Checked Then preset = nudPreset6.Value
        If radPreset7.Checked Then preset = nudPreset7.Value
        If radPreset8.Checked Then preset = nudPreset8.Value
        If radPreset9.Checked Then preset = nudPreset9.Value
        If preset < 1 Then preset = 1
        If preset > nudPreset9.Value Then preset = nudPreset9.Value
        Return preset

    End Function

    Private Sub btnFastIn_Click(sender As Object, e As EventArgs) Handles btnFastIn.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("f")

    End Sub

    Private Sub btnFastOut_Click(sender As Object, e As EventArgs) Handles btnFastOut.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("F")

    End Sub

    Private Sub btnSlowIn_Click(sender As Object, e As EventArgs) Handles btnSlowIn.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("s")

    End Sub

    Private Sub btnSlowOut_Click(sender As Object, e As EventArgs) Handles btnSlowOut.Click
        ServiceTimer()
        Timer1.Start()
        SerialCmd("S")

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        SerialCmd("Q")
        ServiceTimer()

    End Sub

    Private Sub txtName1_TextChanged(sender As Object, e As EventArgs) Handles txtName1.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName2_TextChanged(sender As Object, e As EventArgs) Handles txtName2.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName3_TextChanged(sender As Object, e As EventArgs) Handles txtName3.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName4_TextChanged(sender As Object, e As EventArgs) Handles txtName4.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName5_TextChanged(sender As Object, e As EventArgs) Handles txtName5.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName6_TextChanged(sender As Object, e As EventArgs) Handles txtName6.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName7_TextChanged(sender As Object, e As EventArgs) Handles txtName7.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub txtName8_TextChanged(sender As Object, e As EventArgs) Handles txtName8.TextChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudCurrPos_ValueChanged(sender As Object, e As EventArgs) Handles nudCurrPos.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset0_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset0.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset1_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset1.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset2_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset2.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset3_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset3.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset4_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset4.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset5_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset5.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset6_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset6.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset7_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset7.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset8_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset8.ValueChanged
        btnUpdate.Enabled = True

    End Sub

    Private Sub nudPreset9_ValueChanged(sender As Object, e As EventArgs) Handles nudPreset9.ValueChanged
        btnUpdate.Enabled = True

    End Sub
End Class
