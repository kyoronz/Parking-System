Imports System.ComponentModel

Public Class CustomerReport
    Private Sub CustomerReport_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AdminSubMenu.MdiParent = AddminMenu
        AdminSubMenu.WindowState = FormWindowState.Maximized
        AdminSubMenu.Show()
    End Sub

    Private Sub CustomerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetReport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSetReport.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class