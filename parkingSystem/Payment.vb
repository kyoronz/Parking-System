Public Class Payment
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPayment.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.DataSetPayment.DataTable1)
        getPaymentID(Add.paymentid)
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Shared Sub getPaymentID(ByVal paymentid As Integer)
        Payment.DataTable1TableAdapter.FillBy(Payment.DataSetPayment.DataTable1, paymentid)

        Payment.ReportViewer1.RefreshReport()
    End Sub
End Class