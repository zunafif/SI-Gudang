<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
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
        Me.keluar = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.Button()
        Me.satuan = New System.Windows.Forms.ComboBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Button()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewStock = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(768, 545)
        Me.keluar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(138, 35)
        Me.keluar.TabIndex = 24
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Location = New System.Drawing.Point(621, 545)
        Me.menu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(138, 35)
        Me.menu.TabIndex = 23
        Me.menu.Text = "Menu"
        Me.menu.UseVisualStyleBackColor = True
        '
        'satuan
        '
        Me.satuan.FormattingEnabled = True
        Me.satuan.Items.AddRange(New Object() {"pcs", "box", "unit", "lusin", "pasang", "rim"})
        Me.satuan.Location = New System.Drawing.Point(111, 135)
        Me.satuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(416, 28)
        Me.satuan.TabIndex = 22
        Me.satuan.Text = "pcs"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(333, 245)
        Me.clear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(196, 35)
        Me.clear.TabIndex = 21
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(111, 245)
        Me.tambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(213, 35)
        Me.tambah.TabIndex = 20
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(111, 184)
        Me.jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(416, 26)
        Me.jumlah.TabIndex = 19
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(111, 87)
        Me.nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(416, 26)
        Me.nama.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 184)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 66)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Stock Barang"
        '
        'viewStock
        '
        Me.viewStock.Location = New System.Drawing.Point(111, 292)
        Me.viewStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.viewStock.Name = "viewStock"
        Me.viewStock.Size = New System.Drawing.Size(418, 35)
        Me.viewStock.TabIndex = 25
        Me.viewStock.Text = "Lihat Data Stock"
        Me.viewStock.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.viewStock)
        Me.Panel1.Controls.Add(Me.satuan)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.tambah)
        Me.Panel1.Controls.Add(Me.jumlah)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(143, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 354)
        Me.Panel1.TabIndex = 26
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_Gudang.My.Resources.Resources.mppl_gudang
        Me.ClientSize = New System.Drawing.Size(924, 598)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "stock"
        Me.Text = "ADMIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents keluar As Button
    Friend WithEvents menu As Button
    Friend WithEvents satuan As ComboBox
    Friend WithEvents clear As Button
    Friend WithEvents tambah As Button
    Friend WithEvents jumlah As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents viewStock As Button
    Friend WithEvents Panel1 As Panel
End Class
