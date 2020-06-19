Imports MySql.Data.MySqlClient

Public Class stock

    Dim cmd As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub viewStock_Click(sender As Object, e As EventArgs) Handles viewStock.Click
        viewSB.Show()
    End Sub

    Private Sub clear_Click_1(sender As Object, e As EventArgs) Handles clear.Click
        nama.Text = ""
        satuan.Text = "pcs"
        jumlah.Text = ""
    End Sub

    Private Sub tambah_Click_1(sender As Object, e As EventArgs) Handles tambah.Click
        Dim saveData As String
        Dim message As String
        message = MsgBox("Anda yakin menambahkan item ini ? ", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub
        End If

        saveData = "INSERT INTO stock_barang(kode_barang,nama_barang,satuan,jumlah)values(NULL ,'" & nama.Text & "','" & satuan.SelectedItem.ToString() & "','" & jumlah.Text & "')"

        UpdateData(saveData)
        With viewSB
            .DataGridView1.Refresh()
            .showData()
        End With
    End Sub

    Private Sub menu_Click_1(sender As Object, e As EventArgs) Handles menu.Click
        Form1.Show()
        Visible = False
    End Sub

    Private Sub keluar_Click_1(sender As Object, e As EventArgs) Handles keluar.Click
        Dispose()
    End Sub
End Class