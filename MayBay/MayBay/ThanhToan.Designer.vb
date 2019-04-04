<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThanhToan
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
        Me.txtTien = New System.Windows.Forms.TextBox()
        Me.txtMaVe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnThanhToan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtTien
        '
        Me.txtTien.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTien.Location = New System.Drawing.Point(100, 112)
        Me.txtTien.Name = "txtTien"
        Me.txtTien.Size = New System.Drawing.Size(169, 26)
        Me.txtTien.TabIndex = 162
        '
        'txtMaVe
        '
        Me.txtMaVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaVe.Location = New System.Drawing.Point(100, 45)
        Me.txtMaVe.Name = "txtMaVe"
        Me.txtMaVe.Size = New System.Drawing.Size(169, 26)
        Me.txtMaVe.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(16, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Số tiền"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Mã đặt chỗ"
        '
        'btnThanhToan
        '
        Me.btnThanhToan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanhToan.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnThanhToan.Location = New System.Drawing.Point(82, 149)
        Me.btnThanhToan.Name = "btnThanhToan"
        Me.btnThanhToan.Size = New System.Drawing.Size(109, 31)
        Me.btnThanhToan.TabIndex = 154
        Me.btnThanhToan.Text = "Thanh toán"
        Me.btnThanhToan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "THANH TOÁN"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(16, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "CMND"
        '
        'txtCMND
        '
        Me.txtCMND.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMND.Location = New System.Drawing.Point(100, 80)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(169, 26)
        Me.txtCMND.TabIndex = 163
        '
        'ThanhToan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 192)
        Me.Controls.Add(Me.txtTien)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.txtMaVe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnThanhToan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThanhToan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thanh toán"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTien As TextBox
    Friend WithEvents txtMaVe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThanhToan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCMND As TextBox
End Class
