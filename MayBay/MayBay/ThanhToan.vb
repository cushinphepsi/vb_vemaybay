Imports System.Data.SqlClient
Public Class ThanhToan
    Private WithEvents danh_sach, ds As BindingManagerBase
    Public sql, maChuyenBay, maVe, tienThanhToanVe As String
    Public tongTien As Integer
    Private Sub btnThanhToan_Click(sender As Object, e As EventArgs) Handles btnThanhToan.Click
        If (txtMaVe.Text = "" Or txtTien.Text = "" Or txtCMND.Text = "") Then
            MsgBox("Chưa nhập đủ dữ liệu !")
        Else
            ketNoi.Connect()
            sql = " Select MaVe from KhachHang kh inner join VeChuyenBay vecb on kh.CMND = vecb.CMND 
                    where vecb.CMND = '" & txtCMND.Text & "' "
            Dim data As DataTable
            data = ketNoi.LoadDataTable(sql)
            danh_sach = Me.BindingContext(data)
            If danh_sach.Count = 0 Then
                MsgBox("Bạn nhập sai mã vé hoặc CMND")
            Else
                maVe = danh_sach.Current("MaVe")
                If maVe <> txtMaVe.Text Then
                    MsgBox("Bạn nhập sai mã vé hoặc CMND")
                Else
                    sql = " select MaChuyenBay from VeChuyenBay where MaVe = '" & txtMaVe.Text & "' "
                    data = ketNoi.LoadDataTable(sql)
                    danh_sach = Me.BindingContext(data)
                    maChuyenBay = danh_sach.Current("MaChuyenBay")

                    sql = " select TongTien from ChuyenBay where MaChuyenBay = '" & maChuyenBay & "' "
                    data = ketNoi.LoadDataTable(sql)
                    danh_sach = Me.BindingContext(data)
                    tongTien = danh_sach.Current("TongTien")

                    sql = " select TongTien from NhatKyThanhToan where MaVe = '" & txtMaVe.Text & "' "
                    data = ketNoi.LoadDataTable(sql)
                    danh_sach = Me.BindingContext(data)
                    If danh_sach.Count <> 0 Then
                        MsgBox("Bạn đã thanh toán rồi ")
                    Else
                        If tongTien <> txtTien.Text Then
                            MsgBox("Bạn cần phải thanh toán số tiền là : " & tongTien)
                        Else
                            MsgBox("Thanh toán thành công")
                            sql = " Insert into NhatKyThanhToan(MaNV,MaVe,TongTien,TrangThai,NgayThanhToan) 
                                    values ('" & maNV & "','" & maVe & "' ,'" & txtTien.Text & "',N'Đã thanh toán',getdate())"
                            ketNoi.Excute(sql)
                            InVe.Show()
                            Me.Close()
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class