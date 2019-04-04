Imports System.Data.SqlClient
Public Class TraCuuLichBay
    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        sql = " Select vecb.CMND,TenKH,MaVe from KhachHang kh inner join VeChuyenBay vecb on kh.CMND = vecb.CMND 
                where MaVe = '" & txtMaVe.Text & "' and vecb.CMND = '" & txtCMND.Text & "' and TenKH = N'" & txtTen.Text & "'"
        ketNoi.Connect()
        Dim data As DataTable
        data = ketNoi.LoadDataTable(sql)
        danh_sach = Me.BindingContext(data)
        If danh_sach.Count = 0 Then
            If MsgBox("Bạn chưa đặt vé. Bạn có muốn đặt vé không ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                TimKiemChuyenBay.Show()
                Me.Close()
            End If
        Else
            ThongTinVe.Show()
            Me.Close()
        End If
    End Sub
End Class