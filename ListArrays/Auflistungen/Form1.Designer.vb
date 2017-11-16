<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbx_result = New System.Windows.Forms.ListBox()
        Me.btn_fill = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbx_result
        '
        Me.lbx_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_result.FormattingEnabled = True
        Me.lbx_result.ItemHeight = 25
        Me.lbx_result.Location = New System.Drawing.Point(101, 69)
        Me.lbx_result.Name = "lbx_result"
        Me.lbx_result.Size = New System.Drawing.Size(365, 304)
        Me.lbx_result.TabIndex = 0
        '
        'btn_fill
        '
        Me.btn_fill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fill.Location = New System.Drawing.Point(507, 337)
        Me.btn_fill.Name = "btn_fill"
        Me.btn_fill.Size = New System.Drawing.Size(190, 36)
        Me.btn_fill.TabIndex = 1
        Me.btn_fill.Text = "Liste auffüllen"
        Me.btn_fill.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(507, 274)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(190, 36)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Position löschen"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(507, 213)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(190, 36)
        Me.btn_add.TabIndex = 3
        Me.btn_add.Text = "Position hinzufügen"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 468)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_fill)
        Me.Controls.Add(Me.lbx_result)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbx_result As ListBox
    Friend WithEvents btn_fill As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
End Class
