<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationSystem
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
        Me.lblHeading01 = New System.Windows.Forms.Label()
        Me.lblHeading03 = New System.Windows.Forms.Label()
        Me.txtTour1Adults = New System.Windows.Forms.TextBox()
        Me.btnDisplayInvoice = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTour11 = New System.Windows.Forms.Label()
        Me.lblTour21 = New System.Windows.Forms.Label()
        Me.lblTour31 = New System.Windows.Forms.Label()
        Me.lblTour1Description = New System.Windows.Forms.Label()
        Me.lblTour2Description = New System.Windows.Forms.Label()
        Me.lblTour3Description = New System.Windows.Forms.Label()
        Me.txtTour1Child = New System.Windows.Forms.TextBox()
        Me.pnlTourDescription = New System.Windows.Forms.Panel()
        Me.lblSelectedTours = New System.Windows.Forms.Label()
        Me.lblTour3Count = New System.Windows.Forms.Label()
        Me.lblTour2Count = New System.Windows.Forms.Label()
        Me.lblTourParticipants = New System.Windows.Forms.Label()
        Me.lblTour1Count = New System.Windows.Forms.Label()
        Me.txtTour3Child = New System.Windows.Forms.TextBox()
        Me.lblChildren = New System.Windows.Forms.Label()
        Me.txtTour3Adults = New System.Windows.Forms.TextBox()
        Me.lblAdults = New System.Windows.Forms.Label()
        Me.txtTour2Child = New System.Windows.Forms.TextBox()
        Me.txtTour2Adults = New System.Windows.Forms.TextBox()
        Me.btnSelectTours = New System.Windows.Forms.Button()
        Me.btnClearTourSelection = New System.Windows.Forms.Button()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayTourCost = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAdditionalDiscounts = New System.Windows.Forms.Label()
        Me.chkAAADiscount = New System.Windows.Forms.CheckBox()
        Me.chkMilitary = New System.Windows.Forms.CheckBox()
        Me.cldTourDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSelectDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlTourDescription.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading01
        '
        Me.lblHeading01.AutoSize = True
        Me.lblHeading01.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading01.Location = New System.Drawing.Point(225, 27)
        Me.lblHeading01.Name = "lblHeading01"
        Me.lblHeading01.Size = New System.Drawing.Size(352, 84)
        Me.lblHeading01.TabIndex = 0
        Me.lblHeading01.Text = "Columbus Agency " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Regional Travel"
        Me.lblHeading01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading03
        '
        Me.lblHeading03.AutoSize = True
        Me.lblHeading03.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading03.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblHeading03.Location = New System.Drawing.Point(276, 118)
        Me.lblHeading03.Name = "lblHeading03"
        Me.lblHeading03.Size = New System.Drawing.Size(250, 29)
        Me.lblHeading03.TabIndex = 1
        Me.lblHeading03.Text = "Reservation System"
        '
        'txtTour1Adults
        '
        Me.txtTour1Adults.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour1Adults.Location = New System.Drawing.Point(127, 177)
        Me.txtTour1Adults.Name = "txtTour1Adults"
        Me.txtTour1Adults.Size = New System.Drawing.Size(36, 22)
        Me.txtTour1Adults.TabIndex = 5
        '
        'btnDisplayInvoice
        '
        Me.btnDisplayInvoice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDisplayInvoice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayInvoice.Location = New System.Drawing.Point(503, 505)
        Me.btnDisplayInvoice.Name = "btnDisplayInvoice"
        Me.btnDisplayInvoice.Size = New System.Drawing.Size(120, 25)
        Me.btnDisplayInvoice.TabIndex = 20
        Me.btnDisplayInvoice.Text = "Display Invoice"
        Me.btnDisplayInvoice.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Select Tour(s):"
        '
        'lblTour11
        '
        Me.lblTour11.AutoSize = True
        Me.lblTour11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour11.Location = New System.Drawing.Point(3, 32)
        Me.lblTour11.Name = "lblTour11"
        Me.lblTour11.Size = New System.Drawing.Size(42, 13)
        Me.lblTour11.TabIndex = 44
        Me.lblTour11.Text = "Tour 1:"
        '
        'lblTour21
        '
        Me.lblTour21.AutoSize = True
        Me.lblTour21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour21.Location = New System.Drawing.Point(3, 66)
        Me.lblTour21.Name = "lblTour21"
        Me.lblTour21.Size = New System.Drawing.Size(42, 13)
        Me.lblTour21.TabIndex = 48
        Me.lblTour21.Text = "Tour 2:"
        '
        'lblTour31
        '
        Me.lblTour31.AutoSize = True
        Me.lblTour31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour31.Location = New System.Drawing.Point(3, 99)
        Me.lblTour31.Name = "lblTour31"
        Me.lblTour31.Size = New System.Drawing.Size(45, 13)
        Me.lblTour31.TabIndex = 49
        Me.lblTour31.Text = "Tour 3: "
        '
        'lblTour1Description
        '
        Me.lblTour1Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour1Description.Location = New System.Drawing.Point(44, 32)
        Me.lblTour1Description.Name = "lblTour1Description"
        Me.lblTour1Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour1Description.TabIndex = 50
        Me.lblTour1Description.Text = "Label15"
        '
        'lblTour2Description
        '
        Me.lblTour2Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour2Description.Location = New System.Drawing.Point(44, 66)
        Me.lblTour2Description.Name = "lblTour2Description"
        Me.lblTour2Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour2Description.TabIndex = 51
        Me.lblTour2Description.Text = "Label16"
        '
        'lblTour3Description
        '
        Me.lblTour3Description.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour3Description.Location = New System.Drawing.Point(44, 99)
        Me.lblTour3Description.Name = "lblTour3Description"
        Me.lblTour3Description.Size = New System.Drawing.Size(330, 27)
        Me.lblTour3Description.TabIndex = 52
        Me.lblTour3Description.Text = "Label17"
        '
        'txtTour1Child
        '
        Me.txtTour1Child.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour1Child.Location = New System.Drawing.Point(190, 177)
        Me.txtTour1Child.Name = "txtTour1Child"
        Me.txtTour1Child.Size = New System.Drawing.Size(36, 22)
        Me.txtTour1Child.TabIndex = 54
        '
        'pnlTourDescription
        '
        Me.pnlTourDescription.Controls.Add(Me.lblSelectedTours)
        Me.pnlTourDescription.Controls.Add(Me.lblTour3Count)
        Me.pnlTourDescription.Controls.Add(Me.lblTour2Count)
        Me.pnlTourDescription.Controls.Add(Me.lblTourParticipants)
        Me.pnlTourDescription.Controls.Add(Me.lblTour1Count)
        Me.pnlTourDescription.Controls.Add(Me.txtTour3Child)
        Me.pnlTourDescription.Controls.Add(Me.lblChildren)
        Me.pnlTourDescription.Controls.Add(Me.txtTour3Adults)
        Me.pnlTourDescription.Controls.Add(Me.lblAdults)
        Me.pnlTourDescription.Controls.Add(Me.txtTour2Child)
        Me.pnlTourDescription.Controls.Add(Me.lblTour3Description)
        Me.pnlTourDescription.Controls.Add(Me.txtTour2Adults)
        Me.pnlTourDescription.Controls.Add(Me.lblTour1Description)
        Me.pnlTourDescription.Controls.Add(Me.lblTour2Description)
        Me.pnlTourDescription.Controls.Add(Me.lblTour11)
        Me.pnlTourDescription.Controls.Add(Me.lblTour21)
        Me.pnlTourDescription.Controls.Add(Me.lblTour31)
        Me.pnlTourDescription.Controls.Add(Me.txtTour1Child)
        Me.pnlTourDescription.Controls.Add(Me.txtTour1Adults)
        Me.pnlTourDescription.Location = New System.Drawing.Point(353, 150)
        Me.pnlTourDescription.Name = "pnlTourDescription"
        Me.pnlTourDescription.Size = New System.Drawing.Size(415, 277)
        Me.pnlTourDescription.TabIndex = 63
        '
        'lblSelectedTours
        '
        Me.lblSelectedTours.AutoSize = True
        Me.lblSelectedTours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedTours.Location = New System.Drawing.Point(3, 10)
        Me.lblSelectedTours.Name = "lblSelectedTours"
        Me.lblSelectedTours.Size = New System.Drawing.Size(118, 16)
        Me.lblSelectedTours.TabIndex = 78
        Me.lblSelectedTours.Text = "Selected Tours:"
        '
        'lblTour3Count
        '
        Me.lblTour3Count.AutoSize = True
        Me.lblTour3Count.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour3Count.Location = New System.Drawing.Point(32, 252)
        Me.lblTour3Count.Name = "lblTour3Count"
        Me.lblTour3Count.Size = New System.Drawing.Size(89, 14)
        Me.lblTour3Count.TabIndex = 77
        Me.lblTour3Count.Text = "Tour 3 Count: "
        '
        'lblTour2Count
        '
        Me.lblTour2Count.AutoSize = True
        Me.lblTour2Count.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour2Count.Location = New System.Drawing.Point(32, 216)
        Me.lblTour2Count.Name = "lblTour2Count"
        Me.lblTour2Count.Size = New System.Drawing.Size(85, 14)
        Me.lblTour2Count.TabIndex = 76
        Me.lblTour2Count.Text = "Tour 2 Count:"
        '
        'lblTourParticipants
        '
        Me.lblTourParticipants.AutoSize = True
        Me.lblTourParticipants.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTourParticipants.Location = New System.Drawing.Point(8, 126)
        Me.lblTourParticipants.Name = "lblTourParticipants"
        Me.lblTourParticipants.Size = New System.Drawing.Size(262, 16)
        Me.lblTourParticipants.TabIndex = 75
        Me.lblTourParticipants.Text = "Number of Adult and Child Participants:"
        '
        'lblTour1Count
        '
        Me.lblTour1Count.AutoSize = True
        Me.lblTour1Count.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTour1Count.Location = New System.Drawing.Point(32, 180)
        Me.lblTour1Count.Name = "lblTour1Count"
        Me.lblTour1Count.Size = New System.Drawing.Size(85, 14)
        Me.lblTour1Count.TabIndex = 74
        Me.lblTour1Count.Text = "Tour 1 Count:"
        '
        'txtTour3Child
        '
        Me.txtTour3Child.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour3Child.Location = New System.Drawing.Point(190, 249)
        Me.txtTour3Child.Name = "txtTour3Child"
        Me.txtTour3Child.Size = New System.Drawing.Size(36, 22)
        Me.txtTour3Child.TabIndex = 73
        '
        'lblChildren
        '
        Me.lblChildren.AutoSize = True
        Me.lblChildren.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChildren.Location = New System.Drawing.Point(187, 154)
        Me.lblChildren.Name = "lblChildren"
        Me.lblChildren.Size = New System.Drawing.Size(50, 14)
        Me.lblChildren.TabIndex = 55
        Me.lblChildren.Text = "Children"
        '
        'txtTour3Adults
        '
        Me.txtTour3Adults.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour3Adults.Location = New System.Drawing.Point(127, 249)
        Me.txtTour3Adults.Name = "txtTour3Adults"
        Me.txtTour3Adults.Size = New System.Drawing.Size(36, 22)
        Me.txtTour3Adults.TabIndex = 72
        '
        'lblAdults
        '
        Me.lblAdults.AutoSize = True
        Me.lblAdults.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdults.Location = New System.Drawing.Point(124, 154)
        Me.lblAdults.Name = "lblAdults"
        Me.lblAdults.Size = New System.Drawing.Size(41, 14)
        Me.lblAdults.TabIndex = 53
        Me.lblAdults.Text = "Adults"
        '
        'txtTour2Child
        '
        Me.txtTour2Child.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour2Child.Location = New System.Drawing.Point(190, 213)
        Me.txtTour2Child.Name = "txtTour2Child"
        Me.txtTour2Child.Size = New System.Drawing.Size(36, 22)
        Me.txtTour2Child.TabIndex = 71
        '
        'txtTour2Adults
        '
        Me.txtTour2Adults.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTour2Adults.Location = New System.Drawing.Point(127, 213)
        Me.txtTour2Adults.Name = "txtTour2Adults"
        Me.txtTour2Adults.Size = New System.Drawing.Size(36, 22)
        Me.txtTour2Adults.TabIndex = 70
        '
        'btnSelectTours
        '
        Me.btnSelectTours.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTours.Location = New System.Drawing.Point(18, 483)
        Me.btnSelectTours.Name = "btnSelectTours"
        Me.btnSelectTours.Size = New System.Drawing.Size(100, 23)
        Me.btnSelectTours.TabIndex = 67
        Me.btnSelectTours.Text = "Select Tours"
        Me.btnSelectTours.UseVisualStyleBackColor = True
        '
        'btnClearTourSelection
        '
        Me.btnClearTourSelection.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTourSelection.Location = New System.Drawing.Point(154, 483)
        Me.btnClearTourSelection.Name = "btnClearTourSelection"
        Me.btnClearTourSelection.Size = New System.Drawing.Size(127, 23)
        Me.btnClearTourSelection.TabIndex = 68
        Me.btnClearTourSelection.Text = "Clear Tour Selection"
        Me.btnClearTourSelection.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "mnuCartMenu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplayTourCost, Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuDisplayTourCost
        '
        Me.mnuDisplayTourCost.Name = "mnuDisplayTourCost"
        Me.mnuDisplayTourCost.Size = New System.Drawing.Size(167, 22)
        Me.mnuDisplayTourCost.Text = "&Display Tour Cost"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(167, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(167, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'lblAdditionalDiscounts
        '
        Me.lblAdditionalDiscounts.AutoSize = True
        Me.lblAdditionalDiscounts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalDiscounts.Location = New System.Drawing.Point(361, 429)
        Me.lblAdditionalDiscounts.Name = "lblAdditionalDiscounts"
        Me.lblAdditionalDiscounts.Size = New System.Drawing.Size(157, 16)
        Me.lblAdditionalDiscounts.TabIndex = 70
        Me.lblAdditionalDiscounts.Text = "Additional Discount(s):"
        '
        'chkAAADiscount
        '
        Me.chkAAADiscount.AutoSize = True
        Me.chkAAADiscount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAAADiscount.Location = New System.Drawing.Point(364, 454)
        Me.chkAAADiscount.Name = "chkAAADiscount"
        Me.chkAAADiscount.Size = New System.Drawing.Size(98, 18)
        Me.chkAAADiscount.TabIndex = 71
        Me.chkAAADiscount.Text = "AAA Member"
        Me.chkAAADiscount.UseVisualStyleBackColor = True
        '
        'chkMilitary
        '
        Me.chkMilitary.AutoSize = True
        Me.chkMilitary.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMilitary.Location = New System.Drawing.Point(364, 478)
        Me.chkMilitary.Name = "chkMilitary"
        Me.chkMilitary.Size = New System.Drawing.Size(106, 18)
        Me.chkMilitary.TabIndex = 72
        Me.chkMilitary.Text = "Military with ID"
        Me.chkMilitary.UseVisualStyleBackColor = True
        '
        'cldTourDate
        '
        Me.cldTourDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cldTourDate.Location = New System.Drawing.Point(567, 454)
        Me.cldTourDate.Name = "cldTourDate"
        Me.cldTourDate.Size = New System.Drawing.Size(219, 22)
        Me.cldTourDate.TabIndex = 73
        '
        'lblSelectDate
        '
        Me.lblSelectDate.AutoSize = True
        Me.lblSelectDate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDate.Location = New System.Drawing.Point(564, 431)
        Me.lblSelectDate.Name = "lblSelectDate"
        Me.lblSelectDate.Size = New System.Drawing.Size(113, 14)
        Me.lblSelectDate.TabIndex = 74
        Me.lblSelectDate.Text = "Select Tour Date:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prog1_cp.My.Resources.Resources.index
        Me.PictureBox1.Location = New System.Drawing.Point(644, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.prog1_cp.My.Resources.Resources.White_Water_Rafting_Clipart
        Me.picLogo.Location = New System.Drawing.Point(18, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(140, 120)
        Me.picLogo.TabIndex = 23
        Me.picLogo.TabStop = False
        '
        'frmReservationSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(809, 561)
        Me.Controls.Add(Me.lblSelectDate)
        Me.Controls.Add(Me.cldTourDate)
        Me.Controls.Add(Me.chkMilitary)
        Me.Controls.Add(Me.chkAAADiscount)
        Me.Controls.Add(Me.lblAdditionalDiscounts)
        Me.Controls.Add(Me.btnClearTourSelection)
        Me.Controls.Add(Me.btnSelectTours)
        Me.Controls.Add(Me.pnlTourDescription)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnDisplayInvoice)
        Me.Controls.Add(Me.lblHeading03)
        Me.Controls.Add(Me.lblHeading01)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmReservationSystem"
        Me.Text = "CART Reservation System"
        Me.pnlTourDescription.ResumeLayout(False)
        Me.pnlTourDescription.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading01 As System.Windows.Forms.Label
    Friend WithEvents lblHeading03 As System.Windows.Forms.Label
    Friend WithEvents lblTour12 As System.Windows.Forms.Label
    Friend WithEvents txtTour2Size As System.Windows.Forms.TextBox
    Friend WithEvents lblTour22 As System.Windows.Forms.Label
    Friend WithEvents txtTour1Adults As System.Windows.Forms.TextBox
    Friend WithEvents txtTour3Children As System.Windows.Forms.TextBox
    Friend WithEvents txtTour2Children As System.Windows.Forms.TextBox
    Friend WithEvents lblTour32 As System.Windows.Forms.Label
    Friend WithEvents txtTour3Size As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayInvoice As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTour11 As System.Windows.Forms.Label
    Friend WithEvents lblTour21 As System.Windows.Forms.Label
    Friend WithEvents lblTour31 As System.Windows.Forms.Label
    Friend WithEvents lblTour1Description As System.Windows.Forms.Label
    Friend WithEvents lblTour2Description As System.Windows.Forms.Label
    Friend WithEvents lblTour3Description As System.Windows.Forms.Label
    Friend WithEvents lblGroupDescription As System.Windows.Forms.Label
    Friend WithEvents txtTour1Child As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTourDescription As System.Windows.Forms.Panel
    Friend WithEvents pnlGroupDescription As System.Windows.Forms.Panel
    Friend WithEvents btnSelectTours As System.Windows.Forms.Button
    Friend WithEvents btnClearTourSelection As System.Windows.Forms.Button
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDisplayTourCost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTour2Adults As System.Windows.Forms.TextBox
    Friend WithEvents txtTour2Child As System.Windows.Forms.TextBox
    Friend WithEvents txtTour3Adults As System.Windows.Forms.TextBox
    Friend WithEvents txtTour3Child As System.Windows.Forms.TextBox
    Friend WithEvents lblChildren As System.Windows.Forms.Label
    Friend WithEvents lblAdults As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalDiscounts As System.Windows.Forms.Label
    Friend WithEvents chkAAADiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkMilitary As System.Windows.Forms.CheckBox
    Friend WithEvents lblTour3Count As System.Windows.Forms.Label
    Friend WithEvents lblTour2Count As System.Windows.Forms.Label
    Friend WithEvents lblTourParticipants As System.Windows.Forms.Label
    Friend WithEvents lblTour1Count As System.Windows.Forms.Label
    Friend WithEvents cldTourDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSelectDate As System.Windows.Forms.Label
    Friend WithEvents lblSelectedTours As System.Windows.Forms.Label

End Class
