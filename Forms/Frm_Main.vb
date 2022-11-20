Public Class Frm_Main

#Region "Form"

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sub_FormIconText(Me, "Speaking Clock")
        Not_Main.Icon = My.Resources.art

        Tim_MainTimer.Enabled = True
    End Sub

    Private Sub Frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'e.Cancel = True
        'Me.Hide()
    End Sub

#End Region

#Region "Controls"

    Private Sub Tim_MainTimer_Tick(sender As Object, e As EventArgs) Handles Tim_MainTimer.Tick
        Dim nowTimeDate As DateTime = Now
        Lb_Time.Text = nowTimeDate.ToString("hh:mm:ss tt", cul_invar)
        Lb_Date.Text = nowTimeDate.ToString("ddd, yyyy-MMM-dd", cul_invar)
        Not_Main.Text = nowTimeDate.ToString("hh:mm:ss tt" & str_newLine & "ddd, yyyy-MMM-dd", cul_invar)
    End Sub

    Private Sub Lb_Settings_Click(sender As Object, e As EventArgs) Handles Lb_Settings.Click
        With Frm_Settings
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub Tim_Announce_Tick(sender As Object, e As EventArgs) Handles Tim_Announce.Tick

    End Sub


#End Region

End Class
