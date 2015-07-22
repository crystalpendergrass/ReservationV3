<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayTourCosts
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
        Me.lblDisplayTourCost = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.tblDisplay = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'lblDisplayTourCost
        '
        Me.lblDisplayTourCost.AutoSize = True
        Me.lblDisplayTourCost.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTourCost.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblDisplayTourCost.Location = New System.Drawing.Point(159, 18)
        Me.lblDisplayTourCost.Name = "lblDisplayTourCost"
        Me.lblDisplayTourCost.Size = New System.Drawing.Size(317, 29)
        Me.lblDisplayTourCost.TabIndex = 0
        Me.lblDisplayTourCost.Text = "Display Tour Descriptions"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnReturn.Location = New System.Drawing.Point(232, 397)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(170, 23)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'tblDisplay
        '
        Me.tblDisplay.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.tblDisplay.ColumnCount = 4
        Me.tblDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDisplay.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.tblDisplay.Location = New System.Drawing.Point(17, 66)
        Me.tblDisplay.Name = "tblDisplay"
        Me.tblDisplay.RowCount = 10
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDisplay.Size = New System.Drawing.Size(600, 315)
        Me.tblDisplay.TabIndex = 4
        '
        'frmDisplayTourCosts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 436)
        Me.Controls.Add(Me.tblDisplay)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblDisplayTourCost)
        Me.Name = "frmDisplayTourCosts"
        Me.Text = "Display Tour Costs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplayTourCost As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents tblDisplay As System.Windows.Forms.TableLayoutPanel
End Class
