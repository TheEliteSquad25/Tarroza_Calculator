<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAC = New Button()
        txtDisplay = New TextBox()
        btnBackspace = New Button()
        btnDivide = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnMultiply = New Button()
        btn4 = New Button()
        btn1 = New Button()
        btn5 = New Button()
        btn2 = New Button()
        btn0 = New Button()
        btn6 = New Button()
        btnDecimal = New Button()
        btn3 = New Button()
        btnEquals = New Button()
        btnSubtract = New Button()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' btnAC
        ' 
        btnAC.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAC.Location = New Point(7, 96)
        btnAC.Name = "btnAC"
        btnAC.Size = New Size(146, 50)
        btnAC.TabIndex = 0
        btnAC.Text = "AC"
        btnAC.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(7, 10)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(290, 80)
        txtDisplay.TabIndex = 1
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnBackspace
        ' 
        btnBackspace.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBackspace.Location = New Point(153, 96)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(72, 50)
        btnBackspace.TabIndex = 2
        btnBackspace.Text = "⌫"
        btnBackspace.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDivide.Location = New Point(225, 96)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(72, 50)
        btnDivide.TabIndex = 3
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(7, 152)
        btn7.Name = "btn7"
        btn7.Size = New Size(73, 50)
        btn7.TabIndex = 4
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(80, 152)
        btn8.Name = "btn8"
        btn8.Size = New Size(73, 50)
        btn8.TabIndex = 5
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(153, 152)
        btn9.Name = "btn9"
        btn9.Size = New Size(72, 50)
        btn9.TabIndex = 6
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMultiply.Location = New Point(225, 152)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(72, 50)
        btnMultiply.TabIndex = 7
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(7, 208)
        btn4.Name = "btn4"
        btn4.Size = New Size(73, 50)
        btn4.TabIndex = 8
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(7, 264)
        btn1.Name = "btn1"
        btn1.Size = New Size(73, 50)
        btn1.TabIndex = 9
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(80, 208)
        btn5.Name = "btn5"
        btn5.Size = New Size(73, 50)
        btn5.TabIndex = 11
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(80, 264)
        btn2.Name = "btn2"
        btn2.Size = New Size(73, 50)
        btn2.TabIndex = 12
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn0.Location = New Point(7, 320)
        btn0.Name = "btn0"
        btn0.Size = New Size(146, 50)
        btn0.TabIndex = 13
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(153, 208)
        btn6.Name = "btn6"
        btn6.Size = New Size(72, 50)
        btn6.TabIndex = 14
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btnDecimal
        ' 
        btnDecimal.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDecimal.Location = New Point(153, 320)
        btnDecimal.Name = "btnDecimal"
        btnDecimal.Size = New Size(72, 50)
        btnDecimal.TabIndex = 15
        btnDecimal.Text = "."
        btnDecimal.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(153, 264)
        btn3.Name = "btn3"
        btn3.Size = New Size(72, 50)
        btn3.TabIndex = 15
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btnEquals
        ' 
        btnEquals.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEquals.Location = New Point(225, 320)
        btnEquals.Name = "btnEquals"
        btnEquals.Size = New Size(72, 50)
        btnEquals.TabIndex = 16
        btnEquals.Text = "="
        btnEquals.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubtract.Location = New Point(225, 208)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(72, 50)
        btnSubtract.TabIndex = 16
        btnSubtract.Text = "-"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(225, 264)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(72, 50)
        btnAdd.TabIndex = 17
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = btnEquals
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(304, 381)
        Controls.Add(btnAdd)
        Controls.Add(btnSubtract)
        Controls.Add(btnEquals)
        Controls.Add(btn3)
        Controls.Add(btnDecimal)
        Controls.Add(btn6)
        Controls.Add(btn0)
        Controls.Add(btn2)
        Controls.Add(btn5)
        Controls.Add(btn1)
        Controls.Add(btn4)
        Controls.Add(btnMultiply)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btnDivide)
        Controls.Add(btnBackspace)
        Controls.Add(txtDisplay)
        Controls.Add(btnAC)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAC As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnBackspace As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnDecimal As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button

End Class
