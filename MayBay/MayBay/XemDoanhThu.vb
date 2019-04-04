Public Class XemDoanhThu
    Private Sub XemDoanhThu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dataset_BaoCao.XemDoanhThu' table. You can move, or remove it, as needed.
        Me.XemDoanhThuTableAdapter.Fill(Me.dataset_BaoCao.XemDoanhThu)

        Me.ReportViewer1.RefreshReport()
    End Sub
    'Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs)

    'Dim con = New SqlConnection
    'con = New SqlConnection("Data Source=cushinphepsi;Initial Catalog=QLVeMayBay;Integrated Security=True")
    'con.Open()
    'Dim cmd As SqlCommand
    'Dim adp As New SqlDataAdapter
    'Dim dt As New DataSet
    'Dim sql As String = "Select * from NhatKyThanhToan"
    'cmd = New SqlCommand(sql, con)
    'adp.SelectCommand = cmd
    'adp.Fill(dt, "NhatKyThanhToan")
    'Dim rp As New rptDoanhThu
    'rp.SetDataSource(dt)
    'CrystalReportViewer1.ReportSource = rp
    'CrystalReportViewer1.Refresh()
    'End Sub
End Class