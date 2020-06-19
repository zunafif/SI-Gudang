Imports MySql.Data.MySqlClient

Public Class AdminBK
    Dim cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Dim rd As MySqlDataReader

    Sub tampilDataComboBox()
        openConnection()
        Dim str As String
        str = "select kode_barang from stock_barang"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                kode.Items.Add(rd("kode_barang"))
            Loop
        Else

        End If
    End Sub

    Private Sub PesanBar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilDataComboBox()
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Dim saveData As String
        Dim message As String
        message = MsgBox("Anda yakin menambahkan item ini ? ", vbYesNo + vbInformation, "Warning")
        If message = vbNo Then
            Exit Sub
        End If

        saveData = "INSERT INTO barang_keluar(id_bk, kode_barang,tanggal_keluar,jumlah,no_antrian,nama_pemesan,tujuan)values(NULL,'" & kode.SelectedItem.ToString & "','" & Format(tanggal.Value, "yyyy-MM-dd") & "','" & jumlah.Text & "','" & antrian.Text & "','" & pemesan.Text & "','" & tujuan.SelectedItem.ToString & "')"

        UpdateData(saveData)

        With viewBK
            .DataGridView1.Refresh()
            .showData()
        End With
        With viewSB
            .DataGridView1.Refresh()
            .showData()
        End With

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        jumlah.Text = ""
        antrian.Text = ""
        pemesan.Text = ""
    End Sub

    Private Sub dataBk_Click(sender As Object, e As EventArgs) Handles dataBk.Click
        viewBK.Show()
    End Sub

    Private Sub daraVer_Click(sender As Object, e As EventArgs) Handles daraVer.Click
        viewVer.Show()
    End Sub

    Private Sub dataPsn_Click(sender As Object, e As EventArgs) Handles dataPsn.Click
        viewReq.Show()
    End Sub

    Private Sub DataSb_Click(sender As Object, e As EventArgs) Handles DataSb.Click
        viewSB.Show()
    End Sub
End Class