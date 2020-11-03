Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static hits As Integer
        PictureBox1.Image = My.Resources.tailsgetstrolled
        Label1.Text = "tails got trolled lmao"
        hits += 1
        scoreboard.Text = hits.ToString("n0")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Copywrong 2020", MsgBoxStyle.Information, "a production by Totally Serious Company")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
