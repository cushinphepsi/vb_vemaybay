<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DanhSachChuyenBay
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
        Me.btnChon = New System.Windows.Forms.Button()
        Me.dgvDanhSachCB = New System.Windows.Forms.DataGridView()
        Me.macb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenHang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioDi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanBayDi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioDen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanBayDen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayKhoiHanh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSachCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(314, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 24)
        Me.Label1.TabIndex = 195
        Me.Label1.Text = "DANH SÁCH CHUYẾN BAY"
        '
        'btnChon
        '
        Me.btnChon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnChon.Location = New System.Drawing.Point(299, 336)
        Me.btnChon.Name = "btnChon"
        Me.btnChon.Size = New System.Drawing.Size(134, 29)
        Me.btnChon.TabIndex = 196
        Me.btnChon.Text = "Chọn chuyến bay"
        Me.btnChon.UseVisualStyleBackColor = True
        '
        'dgvDanhSachCB
        '
        Me.dgvDanhSachCB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDanhSachCB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvDanhSachCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.macb, Me.TenHang, Me.GioDi, Me.SanBayDi, Me.GioDen, Me.SanBayDen, Me.TongTien, Me.NgayKhoiHanh})
        Me.dgvDanhSachCB.Location = New System.Drawing.Point(-1, 37)
        Me.dgvDanhSachCB.Name = "dgvDanhSachCB"
        Me.dgvDanhSachCB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDanhSachCB.Size = New System.Drawing.Size(885, 293)
        Me.dgvDanhSachCB.TabIndex = 197
        '
        'macb
        '
        Me.macb.DataPropertyName = "MaChuyenBay"
        Me.macb.HeaderText = "Mã chuyến bay"
        Me.macb.Name = "macb"
        Me.macb.Width = 120
        '
        'TenHang
        '
        Me.TenHang.DataPropertyName = "TenHang"
        Me.TenHang.HeaderText = "Hãng hàng không"
        Me.TenHang.Name = "TenHang"
        Me.TenHang.Width = 120
        '
        'GioDi
        '
        Me.GioDi.DataPropertyName = "GioDi"
        Me.GioDi.HeaderText = "Giờ đi"
        Me.GioDi.Name = "GioDi"
        Me.GioDi.Width = 80
        '
        'SanBayDi
        '
        Me.SanBayDi.DataPropertyName = "SanBayDi"
        Me.SanBayDi.HeaderText = "Tên sân bay đi"
        Me.SanBayDi.Name = "SanBayDi"
        Me.SanBayDi.Width = 120
        '
        'GioDen
        '
        Me.GioDen.DataPropertyName = "GioDen"
        Me.GioDen.HeaderText = "Giờ đến"
        Me.GioDen.Name = "GioDen"
        Me.GioDen.Width = 80
        '
        'SanBayDen
        '
        Me.SanBayDen.DataPropertyName = "SanBayDen"
        Me.SanBayDen.HeaderText = "Tên sân bay đến"
        Me.SanBayDen.Name = "SanBayDen"
        Me.SanBayDen.Width = 120
        '
        'TongTien
        '
        Me.TongTien.DataPropertyName = "TongTien"
        Me.TongTien.HeaderText = "Giá vé"
        Me.TongTien.Name = "TongTien"
        Me.TongTien.Width = 80
        '
        'NgayKhoiHanh
        '
        Me.NgayKhoiHanh.DataPropertyName = "NgayKhoiHanh"
        Me.NgayKhoiHanh.HeaderText = "Ngày khởi hành"
        Me.NgayKhoiHanh.Name = "NgayKhoiHanh"
        Me.NgayKhoiHanh.Width = 120
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTimKiem.Location = New System.Drawing.Point(444, 336)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(134, 29)
        Me.btnTimKiem.TabIndex = 196
        Me.btnTimKiem.Text = "Tìm kiếm lại"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'DanhSachChuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 368)
        Me.Controls.Add(Me.dgvDanhSachCB)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnChon)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MediumBlue
        Me.Name = "DanhSachChuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DanhSachChuyenBay"
        CType(Me.dgvDanhSachCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChon As Button
    Friend WithEvents dgvDanhSachCB As DataGridView
    Friend WithEvents macb As DataGridViewTextBoxColumn
    Friend WithEvents TenHang As DataGridViewTextBoxColumn
    Friend WithEvents GioDi As DataGridViewTextBoxColumn
    Friend WithEvents SanBayDi As DataGridViewTextBoxColumn
    Friend WithEvents GioDen As DataGridViewTextBoxColumn
    Friend WithEvents SanBayDen As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents NgayKhoiHanh As DataGridViewTextBoxColumn
    Friend WithEvents btnTimKiem As Button
End Class
