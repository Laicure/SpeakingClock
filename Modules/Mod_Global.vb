Module Mod_Global
    Friend cul_invar As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Friend str_newLine As String = Environment.NewLine

    'Main
    Friend boo_Announce As Boolean = False
    Friend int_AnnounceInterval As Int32 = 0

#Region "Form"

    Friend Sub Sub_FormIconText(targetForm As Form, formCaption As String)
        With targetForm
            .Icon = My.Resources.art
            .Text = formCaption
        End With
    End Sub

#End Region

End Module
