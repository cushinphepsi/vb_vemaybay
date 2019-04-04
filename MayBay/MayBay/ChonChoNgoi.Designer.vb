<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChonChoNgoi
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
        Me.btnTiepTuc = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaVe = New System.Windows.Forms.TextBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTiepTuc
        '
        Me.btnTiepTuc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnTiepTuc.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnTiepTuc.Location = New System.Drawing.Point(93, 113)
        Me.btnTiepTuc.Name = "btnTiepTuc"
        Me.btnTiepTuc.Size = New System.Drawing.Size(84, 28)
        Me.btnTiepTuc.TabIndex = 117
        Me.btnTiepTuc.Text = "Tiếp tục"
        Me.btnTiepTuc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Mã đặt chỗ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "NHẬP MÃ ĐẶT CHỖ"
        '
        'txtMaVe
        '
        Me.txtMaVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaVe.Location = New System.Drawing.Point(93, 46)
        Me.txtMaVe.Name = "txtMaVe"
        Me.txtMaVe.Size = New System.Drawing.Size(147, 26)
        Me.txtMaVe.TabIndex = 113
        '
        'txtCMND
        '
        Me.txtCMND.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMND.Location = New System.Drawing.Point(93, 78)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(147, 26)
        Me.txtCMND.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label10.Location = New System.Drawing.Point(9, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "CMND"
        '
        'ChonChoNgoi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 152)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnTiepTuc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaVe)
        Me.Name = "ChonChoNgoi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nhập mã đặt chỗ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTiepTuc As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaVe As TextBox
    Friend WithEvents txtCMND As TextBox
    Friend WithEvents Label10 As Label
End Class
