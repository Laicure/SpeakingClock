<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Settings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Num_AnnounceInterval = New System.Windows.Forms.NumericUpDown()
        Me.Ch_Announce = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Num_AnnounceInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Num_AnnounceInterval)
        Me.GroupBox1.Controls.Add(Me.Ch_Announce)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(280, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Announcement"
        '
        'Num_AnnounceInterval
        '
        Me.Num_AnnounceInterval.BackColor = System.Drawing.Color.White
        Me.Num_AnnounceInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Num_AnnounceInterval.ForeColor = System.Drawing.Color.Black
        Me.Num_AnnounceInterval.Location = New System.Drawing.Point(224, 20)
        Me.Num_AnnounceInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.Num_AnnounceInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.Num_AnnounceInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num_AnnounceInterval.Name = "Num_AnnounceInterval"
        Me.Num_AnnounceInterval.Size = New System.Drawing.Size(50, 23)
        Me.Num_AnnounceInterval.TabIndex = 0
        Me.Num_AnnounceInterval.TabStop = False
        Me.Num_AnnounceInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Ch_Announce
        '
        Me.Ch_Announce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ch_Announce.Location = New System.Drawing.Point(4, 20)
        Me.Ch_Announce.Margin = New System.Windows.Forms.Padding(1)
        Me.Ch_Announce.Name = "Ch_Announce"
        Me.Ch_Announce.Size = New System.Drawing.Size(270, 23)
        Me.Ch_Announce.TabIndex = 0
        Me.Ch_Announce.TabStop = False
        Me.Ch_Announce.Text = "Announce Interval (minutes):"
        Me.Ch_Announce.UseVisualStyleBackColor = True
        '
        'Frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 53)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Settings"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Settings"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Num_AnnounceInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Num_AnnounceInterval As NumericUpDown
    Friend WithEvents Ch_Announce As CheckBox
End Class
