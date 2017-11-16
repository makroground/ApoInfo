Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_delete.Enabled = False


        lbx_result.Items.Add(My.Settings.WasserstandInL)

        My.Settings.WasserstandInL = 190

        My.Settings.Save()



    End Sub

    Private Sub btn_fill_Click(sender As Object, e As EventArgs) Handles btn_fill.Click

        Dim einkaufsListe As New List(Of String) From {"Schwarzbrot", "Butter", "Salami", "Käse", "Nutella", "Tomaten", "Wasser"}


        Dim btn1 As Button = New Button()
        btn1.Text = "NeuerButton"
        btn1.Location = New Point(0, 0)
        btn1.Size = New Size(50, 50)

        Me.Controls.Add(btn1)

        Dim btn2 As Button = New Button()
        Dim btn3 As Button = New Button()
        Dim btn4 As Button = New Button()

        Dim listeButton As New List(Of Button) From {btn1, btn2, btn3, btn4}

        For Each str As String In einkaufsListe
            lbx_result.Items.Add(str)
        Next

        lbx_result.SelectedIndex = 0

        btn_delete.Enabled = True

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        lbx_result.Items.Remove(lbx_result.SelectedItem.ToString)

        If (lbx_result.Items.Count < 1) Then

            btn_delete.Enabled = False
        Else

            lbx_result.SelectedIndex = 0
        End If


    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Form2.ShowDialog()

        If (lbx_result.Items.Count < 1) Then

            btn_delete.Enabled = False
        Else

            btn_delete.Enabled = True

            lbx_result.SelectedIndex = 0
        End If

    End Sub
End Class
