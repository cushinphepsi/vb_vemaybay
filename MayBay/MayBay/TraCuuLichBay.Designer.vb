<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraCuuLichBay
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
        Me.txtMaVe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtCMND = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMaVe
        '
        Me.txtMaVe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaVe.Location = New System.Drawing.Point(113, 43)
        Me.txtMaVe.Name = "txtMaVe"
        Me.txtMaVe.Size = New System.Drawing.Size(189, 26)
        Me.txtMaVe.TabIndex = 163
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(9, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Mã vé"
        '
        'btnXem
        '
        Me.btnXem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXem.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnXem.Location = New System.Drawing.Point(118, 142)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(80, 27)
        Me.btnXem.TabIndex = 154
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "TRA CỨU CHUYẾN BAY"
        '
        'txtTen
        '
        Me.txtTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Location = New System.Drawing.Point(113, 107)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(189, 26)
        Me.txtTen.TabIndex = 167
        '
        'txtCMND
        '
        Me.txtCMND.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMND.Location = New System.Drawing.Point(113, 73)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(189, 26)
        Me.txtCMND.TabIndex = 166
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label11.Location = New System.Drawing.Point(5, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 19)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Tên khách hàng"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label10.Location = New System.Drawing.Point(5, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 164
        Me.Label10.Text = "CMND"
        '
        'TraCuuLichBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 173)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMaVe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TraCuuLichBay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TraCuuLichBay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMaVe As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnXem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtCMND As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
