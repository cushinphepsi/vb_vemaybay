Imports System.Data.SqlClient
Public Class ChonChoNgoi
    Private WithEvents danh_sach As BindingManagerBase
    Public sql As String
    Private Sub btnTiepTuc_Click(sender As Object, e As EventArgs) Handles btnTiepTuc.Click
        sql = " Select MaVe from VeChuyenBay
                where CMND =  '" & txtCMND.Text & "' and MaVe = '" & txtMaVe.Text & "'"

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
            ChonGhe.Show()
            Me.Close()
        End If
    End Sub
End Class

