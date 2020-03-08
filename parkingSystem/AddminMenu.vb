Imports System.ComponentModel

Public Class AddminMenu
    Dim choiceflag As Integer = 0
    Private Sub ParkingSlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParkingSlotToolStripMenuItem.Click
        ParkingSlotView.MdiParent = Me
        ParkingSlotView.WindowState = FormWindowState.Maximized
        ParkingSlotView.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim reply As DialogResult

        reply = MessageBox.Show("Are you sure to logout of the program?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reply = DialogResult.Yes Then
            choiceflag = 1
            Me.Close()
        End If
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        CustomerReport.MdiParent = Me
        CustomerReport.WindowState = FormWindowState.Maximized
        CustomerReport.Show()
    End Sub

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        User.MdiParent = Me
        User.WindowState = FormWindowState.Maximized
        User.Show()
    End Sub


    Private Sub AddminMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If choiceflag = 1 Then
            Login.Show()
        Else
            Application.Exit()
        End If
        choiceflag = 0
    End Sub

    Private Sub AddminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminSubMenu.MdiParent = Me
        AdminSubMenu.WindowState = FormWindowState.Maximized
        AdminSubMenu.Show()
    End Sub
End Class

