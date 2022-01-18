<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCCU
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
        Me.btnFencing = New System.Windows.Forms.Button()
        Me.btnFraud = New System.Windows.Forms.Button()
        Me.btnLaundering = New System.Windows.Forms.Button()
        Me.GrdDisplay = New UJ.ACSSE.UJGrid()
        Me.SuspendLayout()
        '
        'btnFencing
        '
        Me.btnFencing.Location = New System.Drawing.Point(12, 34)
        Me.btnFencing.Name = "btnFencing"
        Me.btnFencing.Size = New System.Drawing.Size(164, 23)
        Me.btnFencing.TabIndex = 0
        Me.btnFencing.Text = "Create New Fencing Crime Case"
        Me.btnFencing.UseVisualStyleBackColor = True
        '
        'btnFraud
        '
        Me.btnFraud.Location = New System.Drawing.Point(182, 34)
        Me.btnFraud.Name = "btnFraud"
        Me.btnFraud.Size = New System.Drawing.Size(164, 23)
        Me.btnFraud.TabIndex = 1
        Me.btnFraud.Text = "Create New Fraud Crime Case"
        Me.btnFraud.UseVisualStyleBackColor = True
        '
        'btnLaundering
        '
        Me.btnLaundering.Location = New System.Drawing.Point(352, 34)
        Me.btnLaundering.Name = "btnLaundering"
        Me.btnLaundering.Size = New System.Drawing.Size(164, 23)
        Me.btnLaundering.TabIndex = 2
        Me.btnLaundering.Text = "Create New Laundering Crime Case"
        Me.btnLaundering.UseVisualStyleBackColor = True
        '
        'GrdDisplay
        '
        Me.GrdDisplay.AutoSize = True
        Me.GrdDisplay.Cols = 5
        Me.GrdDisplay.FixedCols = 1
        Me.GrdDisplay.FixedRows = 1
        Me.GrdDisplay.Location = New System.Drawing.Point(12, 99)
        Me.GrdDisplay.Name = "GrdDisplay"
        Me.GrdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.GrdDisplay.Size = New System.Drawing.Size(504, 161)
        Me.GrdDisplay.TabIndex = 4
        '
        'FrmCCU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 269)
        Me.Controls.Add(Me.GrdDisplay)
        Me.Controls.Add(Me.btnLaundering)
        Me.Controls.Add(Me.btnFraud)
        Me.Controls.Add(Me.btnFencing)
        Me.Name = "FrmCCU"
        Me.Text = "Commercial Crimes Unit of the Utopian Police Department"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFencing As System.Windows.Forms.Button
    Friend WithEvents btnFraud As System.Windows.Forms.Button
    Friend WithEvents btnLaundering As System.Windows.Forms.Button
    Friend WithEvents GrdDisplay As UJ.ACSSE.UJGrid

End Class
