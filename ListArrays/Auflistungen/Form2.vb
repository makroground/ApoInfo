Public Class Form2

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Form1.lbx_result.Items.Add(txt_value.Text)

        txt_value.Clear()

        Me.Close()

    End Sub

    Private Sub txt_value_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_value.KeyDown
        If (e.KeyData = Keys.Enter) Then

            Me.btn_ok.PerformClick()

        End If
    End Sub
End Class