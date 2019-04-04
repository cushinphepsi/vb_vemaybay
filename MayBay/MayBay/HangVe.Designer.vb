<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HangVe
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
        Me.txtTenHV = New System.Windows.Forms.TextBox()
        Me.txtMaHV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVeDau = New System.Windows.Forms.Button()
        Me.btnLui = New System.Windows.Forms.Button()
        Me.btnTien = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvThongTinHV = New System.Windows.Forms.DataGridView()
        Me.MaHangVe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenHangVe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaHangVe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnVeCuoi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGiaHV = New System.Windows.Forms.TextBox()
        CType(Me.dgvThongTinHV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTenHV
        '
        Me.txtTenHV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenHV.Location = New System.Drawing.Point(165, 68)
        Me.txtTenHV.Name = "txtTenHV"
        Me.txtTenHV.Size = New System.Drawing.Size(219, 26)
        Me.txtTenHV.TabIndex = 163
        '
        'txtMaHV
        '
        Me.txtMaHV.Enabled = False
        Me.txtMaHV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHV.Location = New System.Drawing.Point(165, 35)
        Me.txtMaHV.Name = "txtMaHV"
        Me.txtMaHV.Size = New System.Drawing.Size(219, 26)
        Me.txtMaHV.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(71, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tên hạng vé"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(71, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mã hạng vé"
        '
        'btnVeDau
        '
        Me.btnVeDau.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeDau.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeDau.Location = New System.Drawing.Point(91, 181)
        Me.btnVeDau.Name = "btnVeDau"
        Me.btnVeDau.Size = New System.Drawing.Size(62, 29)
        Me.btnVeDau.TabIndex = 157
        Me.btnVeDau.Text = "l<"
        Me.btnVeDau.UseVisualStyleBackColor = True
        '
        'btnLui
        '
        Me.btnLui.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLui.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLui.Location = New System.Drawing.Point(174, 181)
        Me.btnLui.Name = "btnLui"
        Me.btnLui.Size = New System.Drawing.Size(62, 29)
        Me.btnLui.TabIndex = 158
        Me.btnLui.Text = "<"
        Me.btnLui.UseVisualStyleBackColor = True
        '
        'btnTien
        '
        Me.btnTien.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTien.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTien.Location = New System.Drawing.Point(262, 181)
        Me.btnTien.Name = "btnTien"
        Me.btnTien.Size = New System.Drawing.Size(62, 29)
        Me.btnTien.TabIndex = 160
        Me.btnTien.Text = ">"
        Me.btnTien.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(399, 140)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(78, 31)
        Me.btnThoat.TabIndex = 156
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXoa.Location = New System.Drawing.Point(303, 140)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(78, 31)
        Me.btnXoa.TabIndex = 152
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnSua.Location = New System.Drawing.Point(206, 140)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 153
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(14, 140)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 155
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvThongTinHV
        '
        Me.dgvThongTinHV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinHV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinHV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHangVe, Me.TenHangVe, Me.GiaHangVe})
        Me.dgvThongTinHV.Location = New System.Drawing.Point(2, 216)
        Me.dgvThongTinHV.Name = "dgvThongTinHV"
        Me.dgvThongTinHV.Size = New System.Drawing.Size(476, 180)
        Me.dgvThongTinHV.TabIndex = 151
        '
        'MaHangVe
        '
        Me.MaHangVe.DataPropertyName = "MaHangVe"
        Me.MaHangVe.HeaderText = "Mã hạng vé"
        Me.MaHangVe.Name = "MaHangVe"
        Me.MaHangVe.Width = 120
        '
        'TenHangVe
        '
        Me.TenHangVe.DataPropertyName = "TenHangVe"
        Me.TenHangVe.HeaderText = "Tên hạng vé"
        Me.TenHangVe.Name = "TenHangVe"
        Me.TenHangVe.Width = 200
        '
        'GiaHangVe
        '
        Me.GiaHangVe.DataPropertyName = "GiaHangVe"
        Me.GiaHangVe.HeaderText = "Giá hạng vé"
        Me.GiaHangVe.Name = "GiaHangVe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(140, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "QUẢN LÝ HẠNG VÉ"
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(113, 140)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 154
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnVeCuoi
        '
        Me.btnVeCuoi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeCuoi.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnVeCuoi.Location = New System.Drawing.Point(347, 181)
        Me.btnVeCuoi.Name = "btnVeCuoi"
        Me.btnVeCuoi.Size = New System.Drawing.Size(62, 29)
        Me.btnVeCuoi.TabIndex = 159
        Me.btnVeCuoi.Text = ">l"
        Me.btnVeCuoi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(71, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Giá hạng vé"
        '
        'txtGiaHV
        '
        Me.txtGiaHV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiaHV.Location = New System.Drawing.Point(165, 101)
        Me.txtGiaHV.Name = "txtGiaHV"
        Me.txtGiaHV.Size = New System.Drawing.Size(219, 26)
        Me.txtGiaHV.TabIndex = 163
        '
        'HangVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 398)
        Me.Controls.Add(Me.txtGiaHV)
        Me.Controls.Add(Me.txtTenHV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMaHV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVeDau)
        Me.Controls.Add(Me.btnLui)
        Me.Controls.Add(Me.btnTien)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvThongTinHV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnVeCuoi)
        Me.Name = "HangVe"
        Me.Text = "HangVe"
        CType(Me.dgvThongTinHV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTenHV As TextBox
    Friend WithEvents txtMaHV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVeDau As Button
    Friend WithEvents btnLui As Button
    Friend WithEvents btnTien As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvThongTinHV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnVeCuoi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGiaHV As TextBox
    Friend WithEvents MaHangVe As DataGridViewTextBoxColumn
    Friend WithEvents TenHangVe As DataGridViewTextBoxColumn
    Friend WithEvents GiaHangVe As DataGridViewTextBoxColumn
End Class
