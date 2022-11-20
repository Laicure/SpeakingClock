Public Class Frm_Settings

#Region "Form"

    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sub_FormIconText(Me, "Speaking Clock")
    End Sub

    Private Sub Frm_Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        With Frm_Main.Tim_Announce
            .Interval = Convert.ToInt32(Num_AnnounceInterval.Value) * 60000
            .Enabled = Ch_Announce.Checked
        End With
    End Sub

#End Region

End Class
