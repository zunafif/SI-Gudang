Public Class Login

    Private Sub Show_CheckedChanged(sender As Object, e As EventArgs) Handles Show.CheckedChanged
        If Show.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user = username.Text
        Dim passwd = password.Text

        If passwd = "123" And user = "admin" Then
            Form1.Show()
            Visible = False
        ElseIf passwd = "123" And user = "karyawan" Then
            PesanBar.Show()
            Visible = False
        ElseIf passwd = "123" And user = "kabag" Then
            Verifikasi.Show()
            Visible = False
        Else
            MsgBox("Username / Password Salah")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()
    End Sub
End Class