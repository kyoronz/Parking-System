Imports System.ComponentModel
Public Class Add
    Dim con As OleDb.OleDbConnection
    Dim valflag As Integer = 0
    Public IC As String 'to get the ic number from adduser and addsearchic
    Public paymentid As Integer 'to store paymentid for payment purpose
    Public canflag As Integer = 0 'to check cancel operation

    Sub validation() 'to validate the input
        If txtname.Text = vbNullString Or cboxduration.Text = vbNullString Then
            valflag = 1
            MessageBox.Show("Please complete the form.", "Register error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        Adduser.ShowDialog()
        If IC = vbNullString Then 'owner is not registered
            Exit Sub
        Else
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()
            Dim dr As OleDb.OleDbDataReader
            Dim sql As String = "SELECT * FROM Customer WHERE IC=@ic"
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@ic", IC)
            dr = cmd.ExecuteReader
            If Not (dr.HasRows) Then 'check the existence of owner details once again, normally the true part will not work
                MessageBox.Show("No user is registered. Please proceed to add new user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dr.Read()                       'input the owner information to the owner details
                txtname.Text = dr.Item(1)
                txtic.Text = dr.Item(0)
                txtcn.Text = dr.Item(2)
                txtemail.Text = dr.Item(3)
                txtcarplate.Text = dr.Item(4)
            End If
            con.Close()
        End If
    End Sub

    Private Sub btnsearchic_Click(sender As Object, e As EventArgs) Handles btnsearchic.Click
        Addsearchic.ShowDialog()
        If IC = vbNullString Then 'owner details is not confirmed and cannot be added to the add form
            Exit Sub
        Else
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()
            Dim dr As OleDb.OleDbDataReader
            Dim sql As String = "SELECT * FROM Customer WHERE IC=@ic"
            Dim cmd As New OleDb.OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@ic", IC)
            dr = cmd.ExecuteReader
            If Not (dr.HasRows) Then  'check the existence of owner details once again, normally the true part will not work
                MessageBox.Show("No user is registered. Please proceed to add new user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                dr.Read()                       'input the owner information to the owner details
                txtname.Text = dr.Item(1)
                txtic.Text = dr.Item(0)
                txtcn.Text = dr.Item(2)
                txtemail.Text = dr.Item(3)
                txtcarplate.Text = dr.Item(4)
            End If
            con.Close()
        End If
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtname.Enabled = False
        txtic.Enabled = False
        txtcn.Enabled = False
        txtemail.Enabled = False
        txtcarplate.Enabled = False
        txtpsid.Enabled = False
        txtpayment.Enabled = False
        txtdeposit.Enabled = False
        txtdatereg.Enabled = False
        cboxduration.Items.Add("")
        cboxduration.Items.Add("3 month")
        cboxduration.Items.Add("6 month")
        cboxduration.DropDownStyle = ComboBoxStyle.DropDownList
        txtpsid.Text = ParkingSlotView.parkingslot 'get the parkingslotid from parkingslotview
        txtdatereg.Text = Now.Date
        btnconfirm.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        canflag = 0
        validation()
        If valflag = 1 Then
            valflag = 0
            Exit Sub
        Else
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
            con.Open()
            Dim sql As String = "SELECT * FROM Level1 ORDER BY ParkingSlot ASC"
            Dim ds As New DataSet
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Name")

            'increase pointer to the parkingslotid
            Dim Maxrows As Integer = ds.Tables("Name").Rows.Count
            Dim namecounter As Integer = 0
            While Not ds.Tables("Name").Rows(namecounter).Item(0) = ParkingSlotView.parkingslot
                namecounter += 1
            End While
            'edit the details of parkingslot
            Dim d As DataRow = ds.Tables("Name").Rows(namecounter)
            d.Item(1) = txtic.Text
            d.Item(2) = Now.Date
            d.Item(3) = txtdeposit.Text.Substring(3)
            Dim dn As Date = Now.Date
            d.Item(4) = dn.AddMonths(3) 'equal to register date +3 month
            d.Item(5) = "Unavailable"

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            da.Update(ds, "Name")
            'add the payment details
            sql = "SELECT * FROM Payment"
            ds = New DataSet
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Payment")

            Dim newrows As DataRow = ds.Tables("Payment").NewRow
            newrows.Item(0) = ds.Tables("Payment").Rows.Count + 1
            newrows.Item(1) = txtic.Text
            newrows.Item(2) = txtpayment.Text.Substring(3)
            newrows.Item(3) = ParkingSlotView.parkingslot
            newrows.Item(4) = Date.Now
            paymentid = newrows.Item(0)
            cb = New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            ds.Tables("Payment").Rows.Add(newrows)
            da.Update(ds, "Payment")

            con.Close()
            Radd() 'use to change the status of owner to register ('R')
            Payment.ShowDialog()
            Me.Close()
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        canflag = 1
        Me.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Sub clear()
        txtname.Clear()
        txtic.Clear()
        txtcn.Clear()
        txtemail.Clear()
        txtcarplate.Clear()
        txtpayment.Clear()
        cboxduration.Items.Clear()
        btnconfirm.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub cboxduration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxduration.SelectedIndexChanged
        Dim roof As Decimal = 80
        Dim normal As Decimal = 120
        If ParkingSlotView.carparklevel.Substring(0, 3) = "L04" Then
            If cboxduration.SelectedIndex = 1 Then
                txtpayment.Text = "RM " & (roof * 3)
                txtdeposit.Text = "RM " & (roof * 3 * 0.8)
            ElseIf cboxduration.SelectedIndex = 2 Then
                txtpayment.Text = "RM " & (roof * 6)
                txtdeposit.Text = "RM " & (roof * 6 * 0.8)
            Else
                txtpayment.Text = ""
            End If
        Else
            If cboxduration.SelectedIndex = 1 Then
                txtpayment.Text = "RM " & (normal * 3)
                txtdeposit.Text = "RM " & (normal * 3 * 0.8)
            ElseIf cboxduration.SelectedIndex = 2 Then
                txtpayment.Text = "RM " & (normal * 6)
                txtdeposit.Text = "RM " & (normal * 6 * 0.8)
            Else
                txtpayment.Text = ""
            End If
        End If
        btnconfirm.Enabled = True
        btnclear.Enabled = True
    End Sub

    Private Sub Add_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        clear()
    End Sub
    Sub Radd()
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VBN.accdb;")
        con.Open()
        Dim flag As Integer = 0
        Dim sql As String = "UPDATE Customer SET Status = 'R' WHERE IC = @ic"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@ic", IC)
        cmd.ExecuteNonQuery()
        flag = cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class