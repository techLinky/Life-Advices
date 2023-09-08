<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnShowMessage = New Button()
        btnCancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtMessage1 = New TextBox()
        txtxMessage2 = New TextBox()
        txtMessage3 = New TextBox()
        txtTitle = New TextBox()
        SuspendLayout()
        ' 
        ' btnShowMessage
        ' 
        btnShowMessage.Location = New Point(249, 379)
        btnShowMessage.Name = "btnShowMessage"
        btnShowMessage.Size = New Size(178, 48)
        btnShowMessage.TabIndex = 0
        btnShowMessage.Text = "Show message"
        btnShowMessage.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(621, 393)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(129, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 25)
        Label1.TabIndex = 2
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(119, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 3
        Label2.Text = "Message1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(119, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 25)
        Label3.TabIndex = 4
        Label3.Text = "Message2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(119, 252)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 25)
        Label4.TabIndex = 5
        Label4.Text = "Message3"
        ' 
        ' txtMessage1
        ' 
        txtMessage1.Location = New Point(358, 95)
        txtMessage1.Name = "txtMessage1"
        txtMessage1.Size = New Size(150, 31)
        txtMessage1.TabIndex = 6
        ' 
        ' txtxMessage2
        ' 
        txtxMessage2.Location = New Point(358, 176)
        txtxMessage2.Name = "txtxMessage2"
        txtxMessage2.Size = New Size(150, 31)
        txtxMessage2.TabIndex = 7
        ' 
        ' txtMessage3
        ' 
        txtMessage3.Location = New Point(358, 246)
        txtMessage3.Name = "txtMessage3"
        txtMessage3.Size = New Size(150, 31)
        txtMessage3.TabIndex = 8
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(358, 28)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(150, 31)
        txtTitle.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTitle)
        Controls.Add(txtMessage3)
        Controls.Add(txtxMessage2)
        Controls.Add(txtMessage1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnShowMessage)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnShowMessage As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMessage1 As TextBox
    Friend WithEvents txtxMessage2 As TextBox
    Friend WithEvents txtMessage3 As TextBox
    Friend WithEvents txtTitle As TextBox
End Class
