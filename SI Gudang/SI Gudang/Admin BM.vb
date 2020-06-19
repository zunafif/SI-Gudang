Imports MySql.Data.MySqlClient

Public Class AdminBM
    Dim cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Dim rd As MySqlDataReader

    Sub tampilDataComboBox()
        openConnection()
        Dim str As String
        str = "select kode_barang, nama_barang from stock_barang"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                ComboBox1.Items.Add(rd("kode_barang"))
            Loop
        Else

        End If
    End Sub

    Private Sub AdminBM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
    End Sub
    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        viewSB.Show()
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Dim saveData As String
        Dim message As String
        message = MsgBox("Anda yakin menambahkan item ini ? ", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub
        End If

        saveData = "INSERT INTO barang_masuk(id_bm, kode_barang,tanggal_in,jumlah)values(NULL,'" & ComboBox1.SelectedItem.ToString & "','" & Format(tanggal.Value, "yyyy-MM-dd") & "','" & jumlah.Text & "')"

        UpdateData(saveData)
        With viewSB
            .DataGridView1.Refresh()
            .showData()
        End With

        With viewBM
            .DataGridView1.Refresh()
            .showData()
        End With
    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        Form1.Show()
        Visible = False
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ComboBox1.Text = ""
        jumlah.Text = ""
    End Sub

    Private Sub viewBarMas_Click(sender As Object, e As EventArgs) Handles viewBarMas.Click
        viewBM.Show()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Dispose()
    End Sub
End Class