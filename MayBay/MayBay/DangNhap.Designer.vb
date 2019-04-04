<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DangNhap
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
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnDangNhap.Location = New System.Drawing.Point(110, 116)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(113, 30)
        Me.btnDangNhap.TabIndex = 10
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(101, 43)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(206, 26)
        Me.txtUser.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label7.Location = New System.Drawing.Point(23, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mật khẩu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(35, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ĐĂNG NHẬP TÀI KHOẢN"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(101, 79)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(206, 26)
        Me.txtPass.TabIndex = 11
        '
        'DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(323, 160)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "DangNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDangNhap As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPass As TextBox
End Class
