<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TuyenBay
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
        Me.txtMaTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvThongTinCB = New System.Windows.Forms.DataGridView()
        Me.matuyenbay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sanbaydi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SanBayDen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSBDi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSBDen = New System.Windows.Forms.TextBox()
        CType(Me.dgvThongTinCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaTB
        '
        Me.txtMaTB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaTB.Location = New System.Drawing.Point(103, 43)
        Me.txtMaTB.Name = "txtMaTB"
        Me.txtMaTB.Size = New System.Drawing.Size(116, 26)
        Me.txtMaTB.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Tên sân bay đi"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(6, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Mã tuyến bay"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThoat.Location = New System.Drawing.Point(399, 113)
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
        Me.btnXoa.Location = New System.Drawing.Point(303, 113)
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
        Me.btnSua.Location = New System.Drawing.Point(206, 113)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(78, 31)
        Me.btnSua.TabIndex = 153
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnLuu.Location = New System.Drawing.Point(113, 113)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(78, 31)
        Me.btnLuu.TabIndex = 154
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThem.Location = New System.Drawing.Point(14, 113)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(78, 31)
        Me.btnThem.TabIndex = 155
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvThongTinCB
        '
        Me.dgvThongTinCB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvThongTinCB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvThongTinCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongTinCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matuyenbay, Me.sanbaydi, Me.SanBayDen})
        Me.dgvThongTinCB.Location = New System.Drawing.Point(2, 150)
        Me.dgvThongTinCB.Name = "dgvThongTinCB"
        Me.dgvThongTinCB.Size = New System.Drawing.Size(480, 186)
        Me.dgvThongTinCB.TabIndex = 151
        '
        'matuyenbay
        '
        Me.matuyenbay.DataPropertyName = "MaTuyenBay"
        Me.matuyenbay.HeaderText = "Mã tuyến bay"
        Me.matuyenbay.Name = "matuyenbay"
        Me.matuyenbay.Width = 130
        '
        'sanbaydi
        '
        Me.sanbaydi.DataPropertyName = "SanBayDi"
        Me.sanbaydi.HeaderText = "Tên sân bay đi"
        Me.sanbaydi.Name = "sanbaydi"
        Me.sanbaydi.Width = 140
        '
        'SanBayDen
        '
        Me.SanBayDen.DataPropertyName = "SanBayDen"
        Me.SanBayDen.HeaderText = "Tên sân bay đến"
        Me.SanBayDen.Name = "SanBayDen"
        Me.SanBayDen.Width = 140
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "QUẢN LÝ TUYẾN BAY"
        '
        'txtSBDi
        '
        Me.txtSBDi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBDi.Location = New System.Drawing.Point(103, 77)
        Me.txtSBDi.Name = "txtSBDi"
        Me.txtSBDi.Size = New System.Drawing.Size(116, 26)
        Me.txtSBDi.TabIndex = 167
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(248, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 23)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Tên sân bay đến"
        '
        'txtSBDen
        '
        Me.txtSBDen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBDen.Location = New System.Drawing.Point(358, 77)
        Me.txtSBDen.Name = "txtSBDen"
        Me.txtSBDen.Size = New System.Drawing.Size(114, 26)
        Me.txtSBDen.TabIndex = 167
        '
        'TuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 338)
        Me.Controls.Add(Me.txtSBDen)
        Me.Controls.Add(Me.txtSBDi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvThongTinCB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tuyến bay"
        CType(Me.dgvThongTinCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThoat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents dgvThongTinCB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSBDi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSBDen As TextBox
    Friend WithEvents matuyenbay As DataGridViewTextBoxColumn
    Friend WithEvents sanbaydi As DataGridViewTextBoxColumn
    Friend WithEvents SanBayDen As DataGridViewTextBoxColumn
End Class
