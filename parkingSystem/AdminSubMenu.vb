Public Class AdminSubMenu
    Private Sub pcbacc_MouseHover(sender As Object, e As EventArgs) Handles pcbacc.MouseHover
        pcbacc.BackColor = SystemColors.InactiveCaption
        lbltext.Text = "Account Setting"
    End Sub

    Private Sub pcbacc_MouseLeave(sender As Object, e As EventArgs) Handles pcbacc.MouseLeave
        pcbacc.BackColor = SystemColors.Info
        lbltext.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pcbacc.Click
        User.MdiParent = AddminMenu
        User.WindowState = FormWindowState.Maximized
        User.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pcbrpt.Click
        CustomerReport.MdiParent = AddminMenu
        CustomerReport.WindowState = FormWindowState.Maximized
        CustomerReport.Show()
    End Sub

    Private Sub pcbps_MouseHover(sender As Object, e As EventArgs) Handles pcbps.MouseHover
        pcbps.BackColor = SystemColors.InactiveCaption
        lbltext1.Text = "Carpark Reservation System"
    End Sub

    Private Sub pcbps_Click(sender As Object, e As EventArgs) Handles pcbps.Click
        ParkingSlotView.MdiParent = AddminMenu
        ParkingSlotView.WindowState = FormWindowState.Maximized
        ParkingSlotView.Show()
    End Sub

    Private Sub pcbps_MouseLeave(sender As Object, e As EventArgs) Handles pcbps.MouseLeave
        pcbps.BackColor = SystemColors.Info
        lbltext1.Text = ""
    End Sub

    Private Sub pcbrpt_MouseHover(sender As Object, e As EventArgs) Handles pcbrpt.MouseHover
        pcbrpt.BackColor = SystemColors.InactiveCaption
        lbltext.Text = "Customer report"
    End Sub

    Private Sub pcbrpt_MouseLeave(sender As Object, e As EventArgs) Handles pcbrpt.MouseLeave
        pcbrpt.BackColor = SystemColors.Info
        lbltext.Text = ""
    End Sub
End Class