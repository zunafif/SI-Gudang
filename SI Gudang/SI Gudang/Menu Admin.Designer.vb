<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.Button()
        Me.bm = New System.Windows.Forms.Button()
        Me.bk = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 85)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'menu
        '
        Me.menu.Location = New System.Drawing.Point(147, 171)
        Me.menu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(232, 35)
        Me.menu.TabIndex = 1
        Me.menu.Text = "Stock Barang"
        Me.menu.UseVisualStyleBackColor = True
        '
        'bm
        '
        Me.bm.Location = New System.Drawing.Point(147, 229)
        Me.bm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bm.Name = "bm"
        Me.bm.Size = New System.Drawing.Size(232, 35)
        Me.bm.TabIndex = 2
        Me.bm.Text = "Barang Masuk"
        Me.bm.UseVisualStyleBackColor = True
        '
        'bk
        '
        Me.bk.Location = New System.Drawing.Point(147, 291)
        Me.bk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bk.Name = "bk"
        Me.bk.Size = New System.Drawing.Size(232, 35)
        Me.bk.TabIndex = 3
        Me.bk.Text = "Barang Keluar"
        Me.bk.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(147, 349)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(232, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Data Verifikasi"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SI_Gudang.My.Resources.Resources.mppl_gudang
        Me.ClientSize = New System.Drawing.Size(520, 486)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.bk)
        Me.Controls.Add(Me.bm)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "ADMIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents menu As Button
    Friend WithEvents bm As Button
    Friend WithEvents bk As Button
    Friend WithEvents Button4 As Button
End Class
