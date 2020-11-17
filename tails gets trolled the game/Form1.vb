Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static hits As Integer ' sets up the scoreboard
        PictureBox1.Image = My.Resources.tailsgetstrolled ' changes the picture
        Label1.Text = "tails got trolled lmao" ' changes the troll state text
        hits += 1 ' adds +1 to the scoreboard
        scoreboard.Text = hits.ToString("n0") ' changes the scoreboard text
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about = New AboutBox1()
        about.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End ' exits the program
    End Sub

    Private Sub scoreboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scoreboard.Click
        Static hits As Integer
        hits += 255
        scoreboard.Text = hits.ToString("n0")
    End Sub
End Class
