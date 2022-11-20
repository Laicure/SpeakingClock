<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Tim_MainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Lb_Time = New System.Windows.Forms.Label()
        Me.Lb_Date = New System.Windows.Forms.Label()
        Me.Lb_Settings = New System.Windows.Forms.Label()
        Me.Tim_Announce = New System.Windows.Forms.Timer(Me.components)
        Me.Not_Main = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Tim_MainTimer
        '
        Me.Tim_MainTimer.Interval = 200
        '
        'Lb_Time
        '
        Me.Lb_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb_Time.Location = New System.Drawing.Point(2, 2)
        Me.Lb_Time.Margin = New System.Windows.Forms.Padding(1)
        Me.Lb_Time.Name = "Lb_Time"
        Me.Lb_Time.Size = New System.Drawing.Size(128, 23)
        Me.Lb_Time.TabIndex = 0
        Me.Lb_Time.Text = "<hh:mm:ss tt>"
        Me.Lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_Date
        '
        Me.Lb_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Date.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb_Date.Location = New System.Drawing.Point(2, 24)
        Me.Lb_Date.Margin = New System.Windows.Forms.Padding(1)
        Me.Lb_Date.Name = "Lb_Date"
        Me.Lb_Date.Size = New System.Drawing.Size(150, 23)
        Me.Lb_Date.TabIndex = 1
        Me.Lb_Date.Text = "<ddd, yyyy-MMM-dd>"
        Me.Lb_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_Settings
        '
        Me.Lb_Settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lb_Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lb_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lb_Settings.ForeColor = System.Drawing.Color.Blue
        Me.Lb_Settings.Location = New System.Drawing.Point(129, 2)
        Me.Lb_Settings.Margin = New System.Windows.Forms.Padding(1)
        Me.Lb_Settings.Name = "Lb_Settings"
        Me.Lb_Settings.Size = New System.Drawing.Size(23, 23)
        Me.Lb_Settings.TabIndex = 2
        Me.Lb_Settings.Text = "S"
        Me.Lb_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tim_Announce
        '
        Me.Tim_Announce.Interval = 200
        '
        'Not_Main
        '
        Me.Not_Main.Text = "Not_Main"
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(154, 49)
        Me.Controls.Add(Me.Lb_Settings)
        Me.Controls.Add(Me.Lb_Date)
        Me.Controls.Add(Me.Lb_Time)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Main"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tim_MainTimer As Timer
    Friend WithEvents Lb_Time As Label
    Friend WithEvents Lb_Date As Label
    Friend WithEvents Lb_Settings As Label
    Friend WithEvents Tim_Announce As Timer
    Friend WithEvents Not_Main As NotifyIcon
End Class
