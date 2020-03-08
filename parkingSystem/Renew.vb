Imports System.Data.OleDb
Public Class Renew
    Dim tempdate As Date
    Dim price As Decimal
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand 'run command search database
    Dim dr As OleDbDataReader 'forward reading component

    Private Sub btncon_Click(sender As Object, e As EventArgs) Handles btncon.Click
        Dim flag As Integer
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")

        Dim renewsql As String
        renewsql = "UPDATE Level1 SET DateExpired=@DE, Status=@ST WHERE ParkingSlot=@PS"

        conn.Open()
        cmd = New OleDbCommand(renewsql, conn)
        cmd.Parameters.AddWithValue("@DE", txtExp.Text)
        cmd.Parameters.AddWithValue("@ST", "Unavailable")
        cmd.Parameters.AddWithValue("@PS", ParkingSlotView.parkingslot)

        cmd.ExecuteNonQuery()
        flag = cmd.ExecuteNonQuery

        Dim da As New OleDb.OleDbDataAdapter(renewsql, conn)
        Dim ds As New DataSet
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        renewsql = "SELECT * FROM Payment"
        ds = New DataSet
        da = New OleDb.OleDbDataAdapter(renewsql, conn)
        da.Fill(ds, "Payment")

        Dim newrows As DataRow = ds.Tables("Payment").NewRow
        newrows.Item(0) = ds.Tables("Payment").Rows.Count + 1
        newrows.Item(1) = ParkingSlotView.txtic.Text
        newrows.Item(2) = price
        newrows.Item(3) = ParkingSlotView.parkingslot
        newrows.Item(4) = Date.Now
        Add.paymentid = newrows.Item(0)
        cb = New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        ds.Tables("Payment").Rows.Add(newrows)
        da.Update(ds, "Payment")

        conn.Close()
        If flag = 0 Then
            MessageBox.Show("Unable to renew record.", "Renew Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Renew successful. Press 'OK' to print the receipt. ", "Renew Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub rbo3_CheckedChanged(sender As Object, e As EventArgs) Handles rbo3.CheckedChanged
        tempdate = Date.Parse(txtRenew.Text)
        txtExp.Text = tempdate.AddMonths(3)
        If ParkingSlotView.carparklevel.Substring(0, 3) = "L04" Then
            price = 80.0 * 3
        Else
            price = 120.0 * 3
        End If
        btncon.Enabled = True
    End Sub

    Private Sub frmRenew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRenew.Text = ParkingSlotView.txtde.Text
    End Sub

    Private Sub rbo6_CheckedChanged(sender As Object, e As EventArgs) Handles rbo6.CheckedChanged
        tempdate = Date.Parse(txtRenew.Text)
        txtExp.Text = tempdate.AddMonths(6)
        If ParkingSlotView.carparklevel.Substring(0, 3) = "L04" Then
            price = 80.0 * 6
        Else
            price = 120.0 * 6
        End If
        btncon.Enabled = True
    End Sub
End Class