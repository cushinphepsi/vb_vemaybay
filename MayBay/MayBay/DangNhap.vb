Imports System.Data.SqlClient
Public Class DangNhap

    Private sql As String
    Private WithEvents danh_sach As BindingManagerBase
    Dim con As New SqlConnection
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        ketNoi.Connect()
        'Dim con As New SqlConnection("Data Source=cushinphepsi;Initial Catalog=QLVeMayBay;Integrated Security=True")

        '    sql = "Select * from NhanVien where Email = @email and MatKhau = @password"
        '    Dim cmd As New SqlCommand(sql, con)
        '    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtUser.Text
        '    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPass.Text
        sql = "Select * from NhanVien where Email = '" & txtUser.Text & "' and MatKhau = '" & txtPass.Text & "' "

        Dim data As DataTable
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        If danh_sach.Count = 0 Then
            MsgBox("Đăng nhập không thành công ! Vui lòng nhập đúng email và mật khẩu")
        Else
            MessageBox.Show(" Đăng nhập thành công ")
            maNV = danh_sach.Current("MaNV")
            Me.Close()
        End If
        'Dim adapter As New SqlDataAdapter(cmd)
        '    Dim table As New DataTable()
        '    adapter.Fill(table)
        'If table.Rows.Count() <= 0 Then
        '    MessageBox.Show("Đăng nhập không thành công ! Vui lòng nhập đúng email và mật khẩu")
        '    maNV = ""
        'Else
        '    MessageBox.Show(" Đăng nhập thành công ")
        '    maNV = danh_sach.Current("MaNV")
        '    Me.Close()
        'End If

    End Sub
End Class