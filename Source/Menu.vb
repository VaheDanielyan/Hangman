Public Class Menu

    Private Sub Exit_btn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Help_btn_Click(sender As Object, e As EventArgs)
        AboutBox1.Show()
    End Sub

    Private Sub About_btn_Click(sender As Object, e As EventArgs) Handles About_btn.Click
        AboutBox1.Show()
    End Sub

    Private Sub Exit_btn_Click_1(sender As Object, e As EventArgs) Handles Exit_btn.Click
        If MessageBox.Show("Are You Sure You Want to close application", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Help.Close()
            Game.Close()
            Me.Close()
        End If

    End Sub

    Private Sub Help_btn_Click_1(sender As Object, e As EventArgs) Handles Help_btn.Click
        Me.Hide()
        Help.Show()
    End Sub

    Private Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click
        Me.Hide()
        Game.Show()
    End Sub
End Class