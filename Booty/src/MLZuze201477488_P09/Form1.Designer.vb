<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptain
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
        Me.MSGains = New System.Windows.Forms.MenuStrip()
        Me.MsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSBooty = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSGrog = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsRum = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsopenBooty = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsOpenGrog = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSOpenRum = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.MSGains.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSGains
        '
        Me.MSGains.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsFile})
        Me.MSGains.Location = New System.Drawing.Point(0, 0)
        Me.MSGains.Name = "MSGains"
        Me.MSGains.Size = New System.Drawing.Size(428, 24)
        Me.MSGains.TabIndex = 0
        Me.MSGains.Text = "MenuStrip1"
        '
        'MsFile
        '
        Me.MsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSCreate, Me.MSOpen})
        Me.MsFile.Name = "MsFile"
        Me.MsFile.Size = New System.Drawing.Size(37, 20)
        Me.MsFile.Text = "File"
        '
        'MSCreate
        '
        Me.MSCreate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MSBooty, Me.MSGrog, Me.MsRum})
        Me.MSCreate.Name = "MSCreate"
        Me.MSCreate.Size = New System.Drawing.Size(182, 22)
        Me.MSCreate.Text = "Create"
        '
        'MSBooty
        '
        Me.MSBooty.Name = "MSBooty"
        Me.MSBooty.Size = New System.Drawing.Size(180, 22)
        Me.MSBooty.Text = "Booty Information..."
        '
        'MSGrog
        '
        Me.MSGrog.Name = "MSGrog"
        Me.MSGrog.Size = New System.Drawing.Size(180, 22)
        Me.MSGrog.Text = "Grog Information..."
        '
        'MsRum
        '
        Me.MsRum.Name = "MsRum"
        Me.MsRum.Size = New System.Drawing.Size(180, 22)
        Me.MsRum.Text = "Rum Information..."
        '
        'MSOpen
        '
        Me.MSOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsopenBooty, Me.MsOpenGrog, Me.MSOpenRum})
        Me.MSOpen.Name = "MSOpen"
        Me.MSOpen.Size = New System.Drawing.Size(182, 22)
        Me.MSOpen.Text = "Open Sequential File"
        '
        'MsopenBooty
        '
        Me.MsopenBooty.Name = "MsopenBooty"
        Me.MsopenBooty.Size = New System.Drawing.Size(180, 22)
        Me.MsopenBooty.Text = "Booty Information..."
        '
        'MsOpenGrog
        '
        Me.MsOpenGrog.Name = "MsOpenGrog"
        Me.MsOpenGrog.Size = New System.Drawing.Size(180, 22)
        Me.MsOpenGrog.Text = "Grog Information..."
        '
        'MSOpenRum
        '
        Me.MSOpenRum.Name = "MSOpenRum"
        Me.MSOpenRum.Size = New System.Drawing.Size(180, 22)
        Me.MSOpenRum.Text = "Rum Information..."
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Location = New System.Drawing.Point(12, 45)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.ReadOnly = True
        Me.rtbDisplay.Size = New System.Drawing.Size(404, 205)
        Me.rtbDisplay.TabIndex = 1
        Me.rtbDisplay.Text = ""
        '
        'frmCaptain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 262)
        Me.Controls.Add(Me.rtbDisplay)
        Me.Controls.Add(Me.MSGains)
        Me.MainMenuStrip = Me.MSGains
        Me.Name = "frmCaptain"
        Me.Text = "The Captain's Gains"
        Me.MSGains.ResumeLayout(False)
        Me.MSGains.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSGains As System.Windows.Forms.MenuStrip
    Friend WithEvents MsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSGrog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSBooty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents MsRum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsopenBooty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsOpenGrog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSOpenRum As System.Windows.Forms.ToolStripMenuItem

End Class
