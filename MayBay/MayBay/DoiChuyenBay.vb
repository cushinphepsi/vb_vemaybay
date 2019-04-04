Imports System.Data.SqlClient
Public Class DoiChuyenBay
    Private WithEvents danh_sach As BindingManagerBase
    Public sql, ten, sdt As String
    Public cmnd, maVe As Integer

    Private Sub btnDongY_Click(sender As Object, e As EventArgs) Handles btnDongY.Click
        cmnd = txtCMND.Text
        ten = txtTen.Text
        sdt = txtSDT.Text
        maVe = txtMaVe.Text
        sql = " Select vecb.CMND,TenKH,SDT,MaVe from KhachHang kh inner join VeChuyenBay vecb on kh.CMND = vecb.CMND 
                where vecb.CMND = '" & cmnd & "' and TenKH = N'" & ten & "' and SDT = '" & sdt & "'"
        ketNoi.Connect()
        Dim data As DataTable
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        If danh_sach.Count = 0 Then
            MsgBox("Vui lòng nhập đúng tất cả thông tin")
        Else
            maVe = danh_sach.Current("MaVe")
            doiCB = "Yes"
            TimKiemChuyenBay.Show()
            Me.Close()
        End If
    End Sub
End Class