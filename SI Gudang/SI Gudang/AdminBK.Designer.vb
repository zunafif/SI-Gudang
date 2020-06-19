<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBK
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.ComboBox()
        Me.tujuan = New System.Windows.Forms.ComboBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.antrian = New System.Windows.Forms.TextBox()
        Me.pemesan = New System.Windows.Forms.TextBox()
        Me.tambah = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.dataBk = New System.Windows.Forms.Button()
        Me.daraVer = New System.Windows.Forms.Button()
        Me.dataPsn = New System.Windows.Forms.Button()
        Me.DataSb = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 66)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barang Keluar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Antrian"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pemesan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 313)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tujuan"
        '
        'kode
        '
        Me.kode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.kode.FormattingEnabled = True
        Me.kode.Location = New System.Drawing.Point(160, 45)
        Me.kode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(298, 28)
        Me.kode.TabIndex = 7
        '
        'tujuan
        '
        Me.tujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tujuan.FormattingEnabled = True
        Me.tujuan.Items.AddRange(New Object() {"Teknik Mesin", "Teknik Listrik", "Operasional Bangunan", "Produksi", "Laboratorium", "Bengkel Mobil", "Kantor Umum", "Office Boy"})
        Me.tujuan.Location = New System.Drawing.Point(160, 308)
        Me.tujuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Size = New System.Drawing.Size(298, 28)
        Me.tujuan.TabIndex = 8
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(160, 99)
        Me.tanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(298, 26)
        Me.tanggal.TabIndex = 9
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(160, 151)
        Me.jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(298, 26)
        Me.jumlah.TabIndex = 10
        '
        'antrian
        '
        Me.antrian.Location = New System.Drawing.Point(160, 203)
        Me.antrian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.antrian.Name = "antrian"
        Me.antrian.Size = New System.Drawing.Size(298, 26)
        Me.antrian.TabIndex = 11
        '
        'pemesan
        '
        Me.pemesan.Location = New System.Drawing.Point(160, 256)
        Me.pemesan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pemesan.Name = "pemesan"
        Me.pemesan.Size = New System.Drawing.Size(298, 26)
        Me.pemesan.TabIndex = 12
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(160, 365)
        Me.tambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(135, 35)
        Me.tambah.TabIndex = 13
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(325, 365)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(135, 35)
        Me.clear.TabIndex = 14
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'dataBk
        '
        Me.dataBk.Location = New System.Drawing.Point(160, 411)
        Me.dataBk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataBk.Name = "dataBk"
        Me.dataBk.Size = New System.Drawing.Size(300, 35)
        Me.dataBk.TabIndex = 15
        Me.dataBk.Text = "Data Barang Keluar"
        Me.dataBk.UseVisualStyleBackColor = True
        '
        'daraVer
        '
        Me.daraVer.Location = New System.Drawing.Point(160, 457)
        Me.daraVer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.daraVer.Name = "daraVer"
        Me.daraVer.Size = New System.Drawing.Size(300, 35)
        Me.daraVer.TabIndex = 16
        Me.daraVer.Text = "Data Verifikasi"
        Me.daraVer.UseVisualStyleBackColor = True
        '
        'dataPsn
        '
        Me.dataPsn.Location = New System.Drawing.Point(160, 503)
        Me.dataPsn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dataPsn.Name = "dataPsn"
        Me.dataPsn.Size = New System.Drawing.Size(300, 35)
        Me.dataPsn.TabIndex = 17
        Me.dataPsn.Text = "Data Pesanan"
        Me.dataPsn.UseVisualStyleBackColor = True
        '
        'DataSb
        '
        Me.DataSb.Location = New System.Drawing.Point(160, 549)
        Me.DataSb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataSb.Name = "DataSb"
        Me.DataSb.Size = New System.Drawing.Size(300, 35)
        Me.DataSb.TabIndex = 18
        Me.DataSb.Text = "Data Stock"
        Me.DataSb.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataSb)
        Me.Panel1.Controls.Add(Me.dataPsn)
        Me.Panel1.Controls.Add(Me.daraVer)
        Me.Panel1.Controls.Add(Me.dataBk)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.tambah)
        Me.Panel1.Controls.Add(Me.pemesan)
        Me.Panel1.Controls.Add(Me.antrian)
        Me.Panel1.Controls.Add(Me.jumlah)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.tujuan)
        Me.Panel1.Controls.Add(Me.kode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(125, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 605)
        Me.Panel1.TabIndex = 19
        '
        'AdminBK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_Gudang.My.Resources.Resources.mppl_gudang
        Me.ClientSize = New System.Drawing.Size(802, 706)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AdminBK"
        Me.Text = "ADMIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents kode As ComboBox
    Friend WithEvents tujuan As ComboBox
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents jumlah As TextBox
    Friend WithEvents antrian As TextBox
    Friend WithEvents pemesan As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents clear As Button
    Friend WithEvents dataBk As Button
    Friend WithEvents daraVer As Button
    Friend WithEvents dataPsn As Button
    Friend WithEvents DataSb As Button
    Friend WithEvents Panel1 As Panel
End Class
