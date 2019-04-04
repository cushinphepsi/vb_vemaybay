Imports System.Data.SqlClient
Public Class InVe
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim con = New SqlConnection
        con = New SqlConnection("Data Source=cushinphepsi;Initial Catalog=QLVeMayBay;Integrated Security=True")
        con.Open()
        Dim cmd As SqlCommand
        Dim adp As New SqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        sql = "Select * from VeChuyenBay where MaVe = '" & ThanhToan.maVe & "' "
        cmd = New SqlCommand(sql, con)
        adp.SelectCommand = cmd
        adp.Fill(dt, "VeChuyenBay")
        Dim rp As New rptInVe
        rp.SetDataSource(dt)
        CrystalReportViewer1.ReportSource = rp
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub InVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class