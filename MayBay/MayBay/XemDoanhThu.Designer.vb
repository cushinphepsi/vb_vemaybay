<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XemDoanhThu
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.XemDoanhThuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataset_BaoCao = New dataset_BaoCao()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.XemDoanhThuTableAdapter = New dataset_BaoCaoTableAdapters.XemDoanhThuTableAdapter()
        CType(Me.XemDoanhThuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataset_BaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XemDoanhThuBindingSource
        '
        Me.XemDoanhThuBindingSource.DataMember = "XemDoanhThu"
        Me.XemDoanhThuBindingSource.DataSource = Me.dataset_BaoCao
        '
        'dataset_BaoCao
        '
        Me.dataset_BaoCao.DataSetName = "dataset_BaoCao"
        Me.dataset_BaoCao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.XemDoanhThuBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MayBay.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(430, 297)
        Me.ReportViewer1.TabIndex = 0
        '
        'XemDoanhThuTableAdapter
        '
        Me.XemDoanhThuTableAdapter.ClearBeforeFill = True
        '
        'XemDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 297)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "XemDoanhThu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XemDoanhThu"
        CType(Me.XemDoanhThuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataset_BaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents XemDoanhThuBindingSource As BindingSource
    Friend WithEvents dataset_BaoCao As dataset_BaoCao
    Friend WithEvents XemDoanhThuTableAdapter As dataset_BaoCaoTableAdapters.XemDoanhThuTableAdapter
End Class
