Imports System.Data.OleDb
Imports System.Net.Mail
Public Class frmUpdate
    Dim parkingslot As String
    Dim flag As Integer
    Dim tempic As String
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand 'run command search database
    Dim dr As OleDbDataReader 'forward reading component

    Public Function IsEmailValid(emailAddress As String) As Boolean
        Try
            Dim mailAddress As New MailAddress(emailAddress)
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")

        Dim updatesql As String
        updatesql = "UPDATE Customer SET ContactNo=@CN, EmailAddress=@EM, CarNumber=@CP WHERE IC=@IC"

        conn.Open()
        cmd = New OleDbCommand(updatesql, conn)
        cmd.Parameters.AddWithValue("@CN", txtcn.Text)
        cmd.Parameters.AddWithValue("@EM", txteml.Text)
        cmd.Parameters.AddWithValue("@CP", txtcp.Text)
        cmd.Parameters.AddWithValue("@IC", tempic)
        cmd.ExecuteNonQuery()
        flag = cmd.ExecuteNonQuery
        conn.Close()

        If flag = 0 Then
            MessageBox.Show("Unable to update record.", "Update error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Records has been successfully updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcn.Enabled = False
            txteml.Enabled = False
            txtcp.Enabled = False
            btnSave.Enabled = False
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnSave
        CancelButton = btnCancel
        txtcn.Enabled = True
        txteml.Enabled = True
        txtcp.Enabled = True

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=VBN.accdb;")

        parkingslot = ParkingSlotView.txtps.Text
        Dim sql As String
        sql = "SELECT * FROM Level1 WHERE ParkingSlot=@PS"

        conn.Open()
        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@PS", parkingslot)
        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            dr.Read()
            tempic = dr.Item("IC")
            txtps.Text = dr.Item("ParkingSlot")
            txtdr.Text = dr.Item("DateRegistered")
            txtdep.Text = dr.Item("DepositPaid")
            txtde.Text = dr.Item("DateExpired")
        End If

        sql = "SELECT * FROM Customer WHERE IC=@IC"

        cmd = New OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@IC", tempic)
        dr = cmd.ExecuteReader

        If (dr.HasRows) Then
            dr.Read()
            txtname.Text = dr.Item("FullName")
            txtic.Text = dr.Item("IC")
            txtcp.Text = dr.Item("CarNumber")
            txteml.Text = dr.Item("EmailAddress")
            txtcn.Text = dr.Item("ContactNo")
        End If
        conn.Close()
    End Sub

    Private Sub txtcp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcp.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcn_LostFocus(sender As Object, e As EventArgs) Handles txtcn.LostFocus
        If txtcn.MaskCompleted = False Then
            lblcn.Text = "Incomplete Contact Number."
            btnSave.Enabled = False
        Else
            lblcn.Text = ""
            If lblemail.Text = "" And lblcp.Text = "" And lblcn.Text = "" Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtcp_LostFocus(sender As Object, e As EventArgs) Handles txtcp.LostFocus
        If txtcp.Text = "" Then
            lblcp.Text = "Invalid Car Plate number."
            btnSave.Enabled = False
        Else
            lblcp.Text = ""
            If lblemail.Text = "" And lblcp.Text = "" And lblcn.Text = "" Then
                btnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub txteml_LostFocus(sender As Object, e As EventArgs) Handles txteml.LostFocus
        If IsEmailValid(txteml.Text) = False Then
            lblemail.Text = "Invalid Email Address."
            btnSave.Enabled = False
        Else
            lblemail.Text = ""
            If lblemail.Text = "" And lblcp.Text = "" And lblcn.Text = "" Then
                btnSave.Enabled = True
            End If
        End If
    End Sub
End Class