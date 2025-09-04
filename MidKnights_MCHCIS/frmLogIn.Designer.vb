<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
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
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(321, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 16)
        Label1.TabIndex = 0
        Label1.Text = "Username / Email Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(321, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 16)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(475, 181)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(111, 16)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(321, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 22)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(321, 153)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(265, 22)
        TextBox2.TabIndex = 4
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(321, 181)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(84, 20)
        CheckBox1.TabIndex = 5
        CheckBox1.Text = "Save Info"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(321, 231)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 28)
        Button1.TabIndex = 6
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(321, 361)
        Button2.Name = "Button2"
        Button2.Size = New Size(265, 28)
        Button2.TabIndex = 7
        Button2.Text = "Email"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(321, 327)
        Button3.Name = "Button3"
        Button3.Size = New Size(265, 28)
        Button3.TabIndex = 8
        Button3.Text = "Google"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(414, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 16)
        Label3.TabIndex = 9
        Label3.Text = "Signing Up?"
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(914, 480)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmLogIn"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label

End Class
