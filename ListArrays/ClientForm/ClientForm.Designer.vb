<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbx_chat = New System.Windows.Forms.ListBox()
        Me.txt_message = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_title1 = New System.Windows.Forms.Label()
        Me.lbl_title2 = New System.Windows.Forms.Label()
        Me.lbl_title3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbx_chat
        '
        Me.lbx_chat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_chat.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbx_chat.FormattingEnabled = True
        Me.lbx_chat.Location = New System.Drawing.Point(46, 85)
        Me.lbx_chat.Name = "lbx_chat"
        Me.lbx_chat.Size = New System.Drawing.Size(352, 134)
        Me.lbx_chat.TabIndex = 0
        '
        'txt_message
        '
        Me.txt_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_message.Location = New System.Drawing.Point(46, 244)
        Me.txt_message.Multiline = True
        Me.txt_message.Name = "txt_message"
        Me.txt_message.Size = New System.Drawing.Size(352, 91)
        Me.txt_message.TabIndex = 1
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_send.FlatAppearance.BorderSize = 0
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.White
        Me.btn_send.Location = New System.Drawing.Point(404, 244)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(104, 91)
        Me.btn_send.TabIndex = 2
        Me.btn_send.Text = "Senden"
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(46, 30)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(352, 22)
        Me.txt_name.TabIndex = 3
        '
        'lbl_title1
        '
        Me.lbl_title1.AutoSize = True
        Me.lbl_title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title1.Location = New System.Drawing.Point(30, 12)
        Me.lbl_title1.Name = "lbl_title1"
        Me.lbl_title1.Size = New System.Drawing.Size(103, 15)
        Me.lbl_title1.TabIndex = 4
        Me.lbl_title1.Text = "Eigener Name:"
        '
        'lbl_title2
        '
        Me.lbl_title2.AutoSize = True
        Me.lbl_title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title2.Location = New System.Drawing.Point(29, 62)
        Me.lbl_title2.Name = "lbl_title2"
        Me.lbl_title2.Size = New System.Drawing.Size(104, 20)
        Me.lbl_title2.TabIndex = 5
        Me.lbl_title2.Text = "Chatfenster"
        '
        'lbl_title3
        '
        Me.lbl_title3.AutoSize = True
        Me.lbl_title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title3.Location = New System.Drawing.Point(30, 226)
        Me.lbl_title3.Name = "lbl_title3"
        Me.lbl_title3.Size = New System.Drawing.Size(72, 15)
        Me.lbl_title3.TabIndex = 6
        Me.lbl_title3.Text = "Nachricht:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 355)
        Me.Controls.Add(Me.lbl_title3)
        Me.Controls.Add(Me.lbl_title2)
        Me.Controls.Add(Me.lbl_title1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_message)
        Me.Controls.Add(Me.lbx_chat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbx_chat As ListBox
    Friend WithEvents txt_message As TextBox
    Friend WithEvents btn_send As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_title1 As Label
    Friend WithEvents lbl_title2 As Label
    Friend WithEvents lbl_title3 As Label
End Class
