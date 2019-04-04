Public Class TimKiemChuyenBay
    Public cmnd, maVe As Integer
    Public noiDi, noiDen, ngayDi, ngayDen, ten, sdt As String
    Private Sub TimKiemChuyenBay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ketNoi.Connect()
        rdMotChieu.Checked = True
        sdt = DoiChuyenBay.sdt
        ten = DoiChuyenBay.ten
        cmnd = DoiChuyenBay.cmnd
        maVe = DoiChuyenBay.maVe
    End Sub


    Private Sub rdMotChieu_CheckedChanged(sender As Object, e As EventArgs) Handles rdMotChieu.CheckedChanged
        lblNgayVe.Visible = False
        dtpNgayVe.Visible = False
    End Sub

    Private Sub rdKhuHoi_CheckedChanged(sender As Object, e As EventArgs) Handles rdKhuHoi.CheckedChanged
        lblNgayVe.Visible = True
        dtpNgayVe.Visible = True
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        If cbNoiDi.Text = "" And cbNoiDen.Text = "" Then
            MsgBox("Bạn phải nhập vào địa điểm đi và địa điểm đến")
        ElseIf cbNoiDi.Text.Equals(cbNoiDen.Text) Then
            MsgBox("Địa điểm đi và và địa điểm đến phải khác nhau")
        Else
            noiDi = cbNoiDi.Text
            noiDen = cbNoiDen.Text
            If dtpNgayVe.Visible = False Then
                ngayDi = Format(dtpNgayDi.Value, "yyyy/MM/dd")
                ngayDen = ""
                DanhSachChuyenBay.Show()
            Else
                If Format(dtpNgayDi.Value, "yyyy/MM/dd") <= Format(dtpNgayVe.Value, "yyyy/MM/dd") Then
                    ngayDi = Format(dtpNgayDi.Value, "yyyy/MM/dd")
                    ngayDen = Format(dtpNgayVe.Value, "yyyy/MM/dd")
                    DanhSachChuyenBay.Show()
                Else
                    MsgBox("Ngày quay về phải lớn hơn hoặc bằng ngày khởi hành")
                End If
            End If
        End If
    End Sub
End Class