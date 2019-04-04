<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimKiemChuyenBay
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
        Me.rdMotChieu = New System.Windows.Forms.RadioButton()
        Me.rdKhuHoi = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNgayVe = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpNgayDi = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgayVe = New System.Windows.Forms.DateTimePicker()
        Me.cbNoiDi = New System.Windows.Forms.ComboBox()
        Me.cbNoiDen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(92, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TÌM KIẾM CHUYẾN BAY"
        '
        'rdMotChieu
        '
        Me.rdMotChieu.AutoSize = True
        Me.rdMotChieu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMotChieu.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdMotChieu.Location = New System.Drawing.Point(16, 34)
        Me.rdMotChieu.Name = "rdMotChieu"
        Me.rdMotChieu.Size = New System.Drawing.Size(88, 23)
        Me.rdMotChieu.TabIndex = 0
        Me.rdMotChieu.TabStop = True
        Me.rdMotChieu.Text = "Một chiều"
        Me.rdMotChieu.UseVisualStyleBackColor = True
        '
        'rdKhuHoi
        '
        Me.rdKhuHoi.AutoSize = True
        Me.rdKhuHoi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdKhuHoi.ForeColor = System.Drawing.Color.MediumBlue
        Me.rdKhuHoi.Location = New System.Drawing.Point(130, 34)
        Me.rdKhuHoi.Name = "rdKhuHoi"
        Me.rdKhuHoi.Size = New System.Drawing.Size(81, 23)
        Me.rdKhuHoi.TabIndex = 0
        Me.rdKhuHoi.TabStop = True
        Me.rdKhuHoi.Text = "Khứ hồi "
        Me.rdKhuHoi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Địa điểm đi"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Địa điểm đến"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ngày khởi hành"
        '
        'lblNgayVe
        '
        Me.lblNgayVe.AutoSize = True
        Me.lblNgayVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNgayVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNgayVe.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblNgayVe.Location = New System.Drawing.Point(257, 141)
        Me.lblNgayVe.Name = "lblNgayVe"
        Me.lblNgayVe.Size = New System.Drawing.Size(95, 21)
        Me.lblNgayVe.TabIndex = 1
        Me.lblNgayVe.Text = "Ngày quay về"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTimKiem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTimKiem.Location = New System.Drawing.Point(144, 184)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(84, 33)
        Me.btnTimKiem.TabIndex = 4
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(234, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Huỷ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpNgayDi
        '
        Me.dtpNgayDi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayDi.Location = New System.Drawing.Point(129, 141)
        Me.dtpNgayDi.Name = "dtpNgayDi"
        Me.dtpNgayDi.Size = New System.Drawing.Size(114, 22)
        Me.dtpNgayDi.TabIndex = 71
        '
        'dtpNgayVe
        '
        Me.dtpNgayVe.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dtpNgayVe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayVe.Location = New System.Drawing.Point(351, 141)
        Me.dtpNgayVe.Name = "dtpNgayVe"
        Me.dtpNgayVe.Size = New System.Drawing.Size(114, 22)
        Me.dtpNgayVe.TabIndex = 71
        '
        'cbNoiDi
        '
        Me.cbNoiDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNoiDi.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoiDi.ForeColor = System.Drawing.Color.Blue
        Me.cbNoiDi.Items.AddRange(New Object() {"Tân Sơn Nhất", "Nội Bài", "Quảng Nam", "Quảng Bình", "Phú Yên"})
        Me.cbNoiDi.Location = New System.Drawing.Point(114, 64)
        Me.cbNoiDi.Name = "cbNoiDi"
        Me.cbNoiDi.Size = New System.Drawing.Size(351, 25)
        Me.cbNoiDi.TabIndex = 172
        '
        'cbNoiDen
        '
        Me.cbNoiDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNoiDen.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoiDen.ForeColor = System.Drawing.Color.Blue
        Me.cbNoiDen.Items.AddRange(New Object() {"Tân Sơn Nhất", "Nội Bài", "Quảng Nam", "Quảng Bình", "Phú Yên"})
        Me.cbNoiDen.Location = New System.Drawing.Point(114, 98)
        Me.cbNoiDen.Name = "cbNoiDen"
        Me.cbNoiDen.Size = New System.Drawing.Size(351, 25)
        Me.cbNoiDen.TabIndex = 172
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbNoiDen)
        Me.GroupBox1.Controls.Add(Me.cbNoiDi)
        Me.GroupBox1.Controls.Add(Me.dtpNgayVe)
        Me.GroupBox1.Controls.Add(Me.dtpNgayDi)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnTimKiem)
        Me.GroupBox1.Controls.Add(Me.lblNgayVe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdKhuHoi)
        Me.GroupBox1.Controls.Add(Me.rdMotChieu)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 230)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tìm kiếm chuyến bay"
        '
        'TimKiemChuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TimKiemChuyenBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Tìm kiếm chuyến bay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents rdMotChieu As RadioButton
    Friend WithEvents rdKhuHoi As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNgayVe As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpNgayDi As DateTimePicker
    Friend WithEvents dtpNgayVe As DateTimePicker
    Friend WithEvents cbNoiDi As ComboBox
    Friend WithEvents cbNoiDen As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
