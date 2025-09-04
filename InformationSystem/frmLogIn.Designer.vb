<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(329, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(258, 22)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(329, 164)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(258, 22)
        TextBox2.TabIndex = 1
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(329, 192)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(123, 20)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Remember Info"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(329, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 16)
        Label1.TabIndex = 3
        Label1.Text = "Username / Email Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(329, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 16)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(470, 145)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(117, 16)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(407, 291)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 16)
        Label3.TabIndex = 6
        Label3.Text = "Create Account"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(329, 230)
        Button1.Name = "Button1"
        Button1.Size = New Size(80, 31)
        Button1.TabIndex = 7
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(329, 320)
        Button2.Name = "Button2"
        Button2.Size = New Size(258, 34)
        Button2.TabIndex = 8
        Button2.Text = "Google Account"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(329, 360)
        Button3.Name = "Button3"
        Button3.Size = New Size(258, 34)
        Button3.TabIndex = 9
        Button3.Text = "Internal Account"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(914, 480)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
