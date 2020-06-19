<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBM
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.tambah = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.menu = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.view = New System.Windows.Forms.Button()
        Me.viewBarMas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BARANG MASUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah"
        '
        'tanggal
        '
        Me.tanggal.CustomFormat = "yyyy-mm-dd"
        Me.tanggal.Location = New System.Drawing.Point(78, 103)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(200, 20)
        Me.tanggal.TabIndex = 8
        Me.tanggal.Value = New Date(2020, 5, 17, 0, 0, 0, 0)
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"kode"})
        Me.ComboBox1.Location = New System.Drawing.Point(78, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(78, 134)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(200, 20)
        Me.jumlah.TabIndex = 10
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(78, 176)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(94, 23)
        Me.tambah.TabIndex = 13
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(189, 176)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(89, 23)
        Me.clear.TabIndex = 14
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'menu
        '
        Me.menu.Location = New System.Drawing.Point(355, 341)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(75, 23)
        Me.menu.TabIndex = 15
        Me.menu.Text = "Menu"
        Me.menu.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(437, 340)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 23)
        Me.keluar.TabIndex = 16
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'view
        '
        Me.view.Location = New System.Drawing.Point(78, 206)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(200, 23)
        Me.view.TabIndex = 17
        Me.view.Text = "Lihat Stock Barang"
        Me.view.UseVisualStyleBackColor = True
        '
        'viewBarMas
        '
        Me.viewBarMas.Location = New System.Drawing.Point(78, 235)
        Me.viewBarMas.Name = "viewBarMas"
        Me.viewBarMas.Size = New System.Drawing.Size(200, 23)
        Me.viewBarMas.TabIndex = 18
        Me.viewBarMas.Text = "Lihat Data BM"
        Me.viewBarMas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.viewBarMas)
        Me.Panel1.Controls.Add(Me.view)
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.tambah)
        Me.Panel1.Controls.Add(Me.jumlah)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(103, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 273)
        Me.Panel1.TabIndex = 19
        '
        'AdminBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_Gudang.My.Resources.Resources.mppl_gudang
        Me.ClientSize = New System.Drawing.Size(524, 375)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AdminBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tanggal As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents clear As Button
    Friend WithEvents menu As Button
    Friend WithEvents keluar As Button
    Friend WithEvents view As Button
    Friend WithEvents viewBarMas As Button
    Friend WithEvents Panel1 As Panel
End Class
