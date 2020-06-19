Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles menu.Click
        stock.Show()
        Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bm.Click
        AdminBM.Show()
        Visible = False
    End Sub

    Private Sub bk_Click(sender As Object, e As EventArgs) Handles bk.Click
        AdminBK.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        viewVer.Show()
    End Sub
End Class