Public Class Form1
    ' === Variables ===
    Dim firstNumber As Double = 0
    Dim secondNumber As Double = 0
    Dim operation As String = ""
    Dim resultCalculated As Boolean = False
    Dim lastInputIsNumber As Boolean = False
    Dim lastInputIsOperator As Boolean = False ' NEW

    ' === Form Load (enable keyboard support) ===
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    ' === Number and Decimal Buttons (0–9, .) ===
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click,
        btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDecimal.Click

        Dim btn As Button = CType(sender, Button)

        ' Prevent multiple decimals in the current number
        If btn.Text = "." Then
            Dim parts() As String = txtDisplay.Text.Split(" "c)
            Dim currentPart As String = If(parts.Length > 0, parts(parts.Length - 1), "")
            If currentPart.Contains(".") OrElse currentPart = "" Then Exit Sub
        End If

        txtDisplay.Text &= btn.Text
        lastInputIsNumber = True
        lastInputIsOperator = False
        resultCalculated = False ' Always allow chaining/appending
    End Sub

    ' === Operator Buttons (+ - * /) ===
    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        Dim btn As Button = CType(sender, Button)

        If txtDisplay.Text = "" OrElse Not lastInputIsNumber Then
            MessageBox.Show("Operator must follow a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' If first number, operator, AND second number exist, calculate first
        Dim parts() As String = txtDisplay.Text.Split(" "c)
        If parts.Length = 3 Then
            btnEquals.PerformClick()
            parts = txtDisplay.Text.Split(" "c)
            If txtDisplay.Text = "" Then Exit Sub
        End If

        operation = btn.Text
        txtDisplay.Text &= " " & operation & " "
        lastInputIsNumber = False
        lastInputIsOperator = True
        resultCalculated = False ' Allow chaining
    End Sub

    ' Helper to normalize display for parsing
    Private Function NormalizeDisplay(text As String) As String
        ' Add spaces around operators for consistent splitting
        Dim ops As String() = {"+", "-", "*", "/"}
        For Each op In ops
            text = text.Replace(op, " " & op & " ")
        Next
        ' Replace multiple spaces with single space
        Return System.Text.RegularExpressions.Regex.Replace(text, "\s+", " ").Trim()
    End Function

    ' === Equals Button (=) ===
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        ' Only proceed if the display contains a valid expression: number operator number
        Dim normalized As String = NormalizeDisplay(txtDisplay.Text)
        Dim parts() As String = normalized.Split(" "c)
        If parts.Length < 3 Then Exit Sub

        Dim op As String = parts(1)
        Dim num1 As Double, num2 As Double

        If Not Double.TryParse(parts(0), num1) Then Exit Sub
        If Not Double.TryParse(parts(2), num2) Then Exit Sub

        Dim result As Double

        Try
            Select Case op
                Case "+" : result = num1 + num2
                Case "-" : result = num1 - num2
                Case "*" : result = num1 * num2
                Case "/"
                    If num2 = 0 Then
                        MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    result = num1 / num2
                Case Else
                    Exit Sub
            End Select

            txtDisplay.Text = FormatResult(result)
            firstNumber = result
            resultCalculated = False ' Allow appending after result
            operation = ""
            lastInputIsNumber = True
            lastInputIsOperator = False
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Helper to format result, trimming trailing zeros
    Private Function FormatResult(value As Double) As String
        Dim formatted As String = value.ToString("0.##########")
        Return formatted
    End Function

    ' === All Clear (AC) ===
    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txtDisplay.Clear()
        firstNumber = 0
        secondNumber = 0
        operation = ""
        resultCalculated = False
        lastInputIsNumber = False
    End Sub

    ' === Backspace (⌫) ===
    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1)
            If txtDisplay.Text.Length > 0 Then
                Dim lastChar As Char = txtDisplay.Text(txtDisplay.Text.Length - 1)
                lastInputIsNumber = Char.IsDigit(lastChar) Or lastChar = "."
            Else
                lastInputIsNumber = False
            End If
        End If
    End Sub

    ' === Keyboard Input Support ===
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            ' Numbers
            Case Keys.D0, Keys.NumPad0 : btn0.PerformClick()
            Case Keys.D1, Keys.NumPad1 : btn1.PerformClick()
            Case Keys.D2, Keys.NumPad2 : btn2.PerformClick()
            Case Keys.D3, Keys.NumPad3 : btn3.PerformClick()
            Case Keys.D4, Keys.NumPad4 : btn4.PerformClick()
            Case Keys.D5, Keys.NumPad5 : btn5.PerformClick()
            Case Keys.D6, Keys.NumPad6 : btn6.PerformClick()
            Case Keys.D7, Keys.NumPad7 : btn7.PerformClick()
            Case Keys.D8
                If e.Shift Then
                    btnMultiply.PerformClick() ' Shift+8 is *
                Else
                    btn8.PerformClick()
                End If
            Case Keys.NumPad8 : btn8.PerformClick()
            Case Keys.D9, Keys.NumPad9 : btn9.PerformClick()

            ' Decimal
            Case Keys.Decimal, Keys.OemPeriod : btnDecimal.PerformClick()

            ' Operators
            Case Keys.Add, Keys.Oemplus : btnAdd.PerformClick()
            Case Keys.Subtract, Keys.OemMinus : btnSubtract.PerformClick()
            Case Keys.Multiply : btnMultiply.PerformClick() ' Numpad *
            Case Keys.Divide, Keys.OemQuestion : btnDivide.PerformClick()

            ' Equals (Enter/Return)
            Case Keys.Enter, Keys.Return
                btnEquals.PerformClick()
                e.Handled = True
                e.SuppressKeyPress = True

            ' Clear and Backspace
            Case Keys.Delete : btnAC.PerformClick()
            Case Keys.Back : btnBackspace.PerformClick()
        End Select
    End Sub
End Class
