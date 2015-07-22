'****************************************************************************** 
' PROGRAM: Columbus Agency for Regional Travel v3
' AUTHOR: Crystal Pendergrass
' DATE: 17 April 2015
' PURPOSE: The Columbus Agency for Regional Travel Reservation System allows 
' the customer to view different types of tours and compute the cost of the 
' customer’s reservation.  
'******************************************************************************

Option Strict On
Public Class frmReservationSystem
    ' constants for this application
    Public Shared _intArraySize As Integer = 9
    Public Shared _strTourName(_intArraySize) As String
    Public Shared _strTourType(_intArraySize) As String
    Public Shared _decTourPricePer(_intArraySize) As Decimal
    Public Shared _decTourDuration(_intArraySize) As Decimal

    Dim theCheckBoxes As List(Of CheckBox)

    Const cdecDiscountChild As Decimal = 0.35D
    Const cdecDiscountAAA As Decimal = 0.05D
    Const cdecDiscountMilitary As Decimal = 0.1D
    Const cdecPricePerWhitewaterClassic As Decimal = 32.5D
    Const cdecPricePerWhitewaterHighwater As Decimal = 48.5D
    Const cdecPricePerZipLine As Decimal = 16D
    Const cdecPricePerCanopyBoat As Decimal = 21D
    Const cdecPricePerOxbowMeadows As Decimal = 20D
    Const cdecPricePerCocaColaSpace As Decimal = 18D
    Const cdecPricePerHistoricDistrict As Decimal = 15D
    Const cdecPricePerInfantryMusuem As Decimal = 22D
    Const cdecPricePerPortColumbus As Decimal = 10D
    Const cdecTaxPercent As Decimal = 0.15D
    Const cdecServiceChargePercent As Decimal = 0.07D
    Const cintMaxNumberOfTours As Integer = 3
    Const cintLargeGroupSize As Integer = 10

    Dim intCountChildren As Integer
    Dim intCountAdults As Integer
    Dim intGroupSize As Integer
    Dim decPricePerTour1 As Decimal
    Dim decPricePerTour2 As Decimal
    Dim decPricePerTour3 As Decimal

    Dim strTours(cintMaxNumberOfTours) As String

    '****************************************************************************** 
    'When the formed is loaded the "Display Invoice" button is disabled, radiobuttons 
    'are blank.  
    '******************************************************************************
    Private Sub frmReservationSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strFileLocation = "tour.txt"
        Dim intArrayIndex As Integer = 0
        Dim strFileError As String = "The file is not available.  Restart when the file is available."

        If IO.File.Exists(strFileLocation) Then
            objReader = IO.File.OpenText(strFileLocation)
            Do While objReader.Peek <> -1
                _strTourName(intArrayIndex) = objReader.ReadLine()
                _strTourType(intArrayIndex) = objReader.ReadLine()
                _decTourPricePer(intArrayIndex) = Convert.ToDecimal(objReader.ReadLine())
                _decTourDuration(intArrayIndex) = Convert.ToDecimal(objReader.ReadLine())
                intArrayIndex += 1
            Loop
        End If

        SetUpCheckBoxes()

        MakeObjectsInvisible()
    End Sub

    '****************************************************************************** 
    'When the Select Tours button is clicked, the selected tours and their costs
    'per person are displayed.  If more than the maximum number of allowed tours
    'is selected the user is warned and selections are erased.  
    'Code modified from:
    'http://stackoverflow.com/questions/28529715/array-of-checkboxes-vb-net
    '******************************************************************************
    Private Sub btnSelectTours_Click(sender As Object, e As EventArgs) Handles btnSelectTours.Click
        Dim count = 0
        For Each cb In theCheckBoxes
            ' do something with cb.Checked
            If cb.Checked Then
                count += 1
            End If
        Next

        If count = 0 Then
            MsgBox("You have NOT selected any tours.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "No Tours Selected")
        ElseIf count > 3 Then
            MsgBox("You have selected " & count & " tours." & Environment.NewLine & "You can only select " & cintMaxNumberOfTours & " tours.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Too Many Tours Selected")
            EraseTourSelections()
        Else
            EraseTours()

            CopyTours()
            lblAdults.Visible = True
            lblChildren.Visible = True

            If (strTours(0) <> Nothing) Then
                decPricePerTour1 = GetTourPrice(strTours(0))
                lblTour1Description.Text = strTours(0) & " [" & decPricePerTour1.ToString("C") & "]"
                lblTour1Count.Visible = True
                txtTour1Adults.Visible = True
                txtTour1Child.Visible = True

            End If
            If (strTours(1) <> Nothing) Then
                decPricePerTour2 = GetTourPrice(strTours(1))
                lblTour2Description.Text = strTours(1) & " [" & decPricePerTour2.ToString("C") & "]"
                lblTour2Count.Visible = True
                txtTour2Adults.Visible = True
                txtTour2Child.Visible = True
            Else
                lblTour21.Visible = False
                lblTour2Count.Visible = False
                txtTour2Adults.Visible = False
                txtTour2Child.Visible = False
            End If
            If (strTours(2) <> Nothing) Then
                decPricePerTour3 = GetTourPrice(strTours(2))
                lblTour3Description.Text = strTours(2) & " [" & decPricePerTour3.ToString("C") & "]"
                lblTour3Count.Visible = True
                txtTour3Adults.Visible = True
                txtTour3Child.Visible = True
            Else
                lblTour31.Visible = False
                lblTour3Count.Visible = False
                txtTour3Adults.Visible = False
                txtTour3Child.Visible = False
            End If

            btnDisplayInvoice.Visible = True

            pnlTourDescription.Visible = True

            lblAdditionalDiscounts.Visible = True
            chkAAADiscount.Visible = True
            chkMilitary.Visible = True

            lblSelectDate.Visible = True
            cldTourDate.Visible = True

            DisableTourSelection()
        End If

    End Sub

    '****************************************************************************** 
    'When the Display Invoice button is clicked then the total cost of all 
    'tours is calculated, as well as discounts, tax, service charge and the final 
    'total of the entire reservation.
    '******************************************************************************
    Private Sub btnDisplayInvoice_Click(sender As Object, e As EventArgs) Handles btnDisplayInvoice.Click
        Dim decTourSubTotal As Decimal = 0
        Dim decDiscountChild As Decimal = 0

        Try
            If (txtTour1Adults.TextLength = 0 And txtTour1Child.TextLength = 0) Then
                MsgBox("Must have at least one tour participant", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "No Tour Participant")
            Else
                intGroupSize = GroupCount(txtTour1Adults, txtTour1Child)
                frmDisplayInvoice._decTotalTour1 = decPricePerTour1 * intGroupSize
                frmDisplayInvoice._decDiscountChild += decPricePerTour1 * intCountChildren * cdecDiscountChild
                decTourSubTotal += frmDisplayInvoice._decTotalTour1
            End If

            If (txtTour2Adults.TextLength > 0 Or txtTour2Child.TextLength > 0) Then
                intGroupSize = GroupCount(txtTour2Adults, txtTour2Child)
                frmDisplayInvoice._decTotalTour2 = decPricePerTour2 * intGroupSize
                frmDisplayInvoice._decDiscountChild += decPricePerTour2 * intCountChildren * cdecDiscountChild
                decTourSubTotal += frmDisplayInvoice._decTotalTour2
            End If

            If (txtTour3Adults.TextLength > 0 Or txtTour3Child.TextLength > 0) Then
                intGroupSize = GroupCount(txtTour3Adults, txtTour3Child)
                frmDisplayInvoice._decTotalTour3 = decPricePerTour3 * intGroupSize
                frmDisplayInvoice._decDiscountChild += decPricePerTour3 * intCountChildren * cdecDiscountChild
                decTourSubTotal += frmDisplayInvoice._decTotalTour3
            End If

            frmDisplayInvoice._decTourSubTotal = decTourSubTotal

            If (chkAAADiscount.Checked = True) Then
                frmDisplayInvoice._decDiscountAAA = decTourSubTotal * cdecDiscountAAA

            End If

            If (chkMilitary.Checked = True) Then
                frmDisplayInvoice._decDiscountMilitary = decTourSubTotal * cdecDiscountMilitary
            End If

            If cldTourDate.Value < DateTime.Today Then
                MsgBox("Invalid date selected: Tours can only be scheduled for today or booked for future date", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Selected Date Invalid")
                cldTourDate.Value = DateTime.Today
            End If

            Dim frmSecond As New frmDisplayInvoice
            frmSecond.ShowDialog()

        Catch Exception As FormatException
            MsgBox("One of your entries is not a number.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Incorrect Value(s)")
            txtTour1Adults.Clear()
            txtTour1Child.Clear()
            txtTour2Adults.Clear()
            txtTour2Child.Clear()
            txtTour3Adults.Clear()
            txtTour3Child.Clear()
        End Try
    End Sub

    '****************************************************************************** 
    'Returns the per person cost of a select tour.  
    '******************************************************************************
    Private Function GetTourPrice(ByVal strTourName As String) As Decimal
        Select Case strTourName
            Case "Whitewater Classic"
                Return cdecPricePerWhitewaterClassic
            Case "Whitewater Highwater"
                Return cdecPricePerWhitewaterHighwater
            Case "Zip Line"
                Return cdecPricePerZipLine
            Case "Canopy Boat"
                Return cdecPricePerCanopyBoat
            Case "Oxbow Meadows with Canopy Treetop Bridge"
                Return cdecPricePerOxbowMeadows
            Case "Coca Cola Space Science Center with Planetarium"
                Return cdecPricePerCocaColaSpace
            Case "Historic District and Columbus Museum Tour including Pemberton’s Pharmacy and McCullers House"
                Return cdecPricePerHistoricDistrict
            Case "Infantry Museum including iMax movie"
                Return cdecPricePerInfantryMusuem
            Case "Port Columbus Civil War Naval Museum"
                Return cdecPricePerPortColumbus
            Case Else
                Return 0
        End Select
    End Function

    '****************************************************************************** 
    'Sets the visiblity status for select components.
    '******************************************************************************
    Private Sub MakeObjectsVisible()
        ' This proceudre displays the objects showing the results
        pnlTourDescription.Visible = True
    End Sub

    '****************************************************************************** 
    'Sets the invisiblity status for select components.
    '******************************************************************************
    Private Sub MakeObjectsInvisible()
        ' This proceudre displays the objects showing the results
        pnlTourDescription.Visible = False

        lblAdditionalDiscounts.Visible = False
        chkAAADiscount.Visible = False
        chkMilitary.Visible = False

        lblSelectDate.Visible = False
        cldTourDate.Visible = False

        btnDisplayInvoice.Visible = False
    End Sub

    '****************************************************************************** 
    'Erases tour selection information
    '******************************************************************************
    Private Sub EraseTours()
        Array.Clear(strTours, Nothing, strTours.Length)

        lblTour1Description.Text = ""
        lblTour2Description.Text = ""
        lblTour3Description.Text = ""
    End Sub

    '****************************************************************************** 
    'Completely resets reservation process.  All stored data and calculations are
    'erased.  Screen returns to screen when program initially launched.  
    '******************************************************************************
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        MakeObjectsInvisible()

        txtTour1Adults.Clear()
        txtTour1Child.Clear()

        txtTour2Adults.Clear()
        txtTour2Child.Clear()

        txtTour3Adults.Clear()
        txtTour3Child.Clear()

        EraseTourSelections()

        EraseTours()

        EnableTourSelection()
    End Sub

    '****************************************************************************** 
    'Exits window and closes application
    '******************************************************************************
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

    '****************************************************************************** 
    'Opens second window to display the name, type, cost and duration of each tour.  
    '******************************************************************************
    Private Sub mnuDisplayTourCost_Click(sender As Object, e As EventArgs) Handles mnuDisplayTourCost.Click
        Dim frmSecond As New frmDisplayTourCosts
        frmSecond.ShowDialog()
    End Sub

    '****************************************************************************** 
    'Creates a list of checkboxs whose labels are the names of each tour.
    'Code modified from:
    'http://stackoverflow.com/questions/28529715/array-of-checkboxes-vb-net
    '******************************************************************************
    Sub SetUpCheckBoxes()
        theCheckBoxes = New List(Of CheckBox)
        Dim offset = 190
        For intCounter = 0 To (_intArraySize - 1)
            Dim cb = New CheckBox()
            cb.Location = New Point(25, offset)
            cb.Text = _strTourName(intCounter)
            cb.Checked = False
            cb.Size = New Size(300, 30)
            cb.Font = New Font("Tahoma", 8)
            Controls.Add(cb)
            theCheckBoxes.Add(cb)
            offset = offset + 32
        Next
    End Sub

    '****************************************************************************** 
    'Deselects all selected tours.  
    '******************************************************************************
    Private Sub EraseTourSelections()
        For Each cb In theCheckBoxes
            cb.Checked = False
        Next
    End Sub

    '****************************************************************************** 
    'Copies the name of selected tours into an array.  
    '******************************************************************************
    Private Sub CopyTours()
        For Each cb In theCheckBoxes
            If cb.Checked Then
                If (strTours(0) = Nothing) Then
                    strTours(0) = cb.Text
                ElseIf (strTours(1) = Nothing) Then
                    strTours(1) = cb.Text
                Else
                    strTours(2) = cb.Text
                End If
            End If
        Next
    End Sub

    '****************************************************************************** 
    'Disables all checkboxes
    '******************************************************************************
    Private Sub DisableTourSelection()
        For Each cb In theCheckBoxes
            cb.Enabled = False
        Next
        btnSelectTours.Enabled = False
    End Sub

    '****************************************************************************** 
    'Enables all checkboxes
    '******************************************************************************
    Private Sub EnableTourSelection()
        For Each cb In theCheckBoxes
            cb.Enabled = True
        Next
        btnSelectTours.Enabled = True
    End Sub

    '****************************************************************************** 
    'Clears all selections and entries that the user has selected and input.  
    '******************************************************************************
    Private Sub btnClearTourSelection_Click(sender As Object, e As EventArgs) Handles btnClearTourSelection.Click
        EnableTourSelection()
        EraseTourSelections()
        MakeObjectsInvisible()
        txtTour1Adults.Clear()
        txtTour1Child.Clear()
        txtTour2Adults.Clear()
        txtTour2Child.Clear()
        txtTour3Adults.Clear()
        txtTour3Child.Clear()
    End Sub

    '****************************************************************************** 
    'Accepts textboxes that contain the number of children and adults attending
    'a tour.  Returns the total number of participants in a tour.  Resets negative
    'entries that have been entered in a textbox.
    '******************************************************************************
    Private Function GroupCount(ByRef tbAdult As TextBox, ByRef tbChild As TextBox) As Integer
        Dim intTourCount As Integer = 0

        intCountAdults = 0
        intCountChildren = 0

        If (tbAdult.TextLength = 0) Then
            intCountAdults = 0
        ElseIf (Convert.ToInt32(tbAdult.Text) < 0) Then
            MsgBox("Group size cannot be a negative number! You entered" & Environment.NewLine & "Adult Count: " & tbAdult.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Entered Negative Value")
            tbAdult.Clear()
        Else
            intCountAdults = Convert.ToInt32(tbAdult.Text)
        End If

        If (tbChild.TextLength = 0) Then
            intCountChildren = 0
        ElseIf (Convert.ToInt32(tbChild.Text) < 0) Then
            MsgBox("Number of children cannot be a negative number! You entered: " & Environment.NewLine & "Child Count: " & tbChild.Text, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Entered Negative Value")
            tbChild.Clear()
        Else
            intCountChildren = Convert.ToInt32(tbChild.Text)
        End If

        intTourCount = intCountAdults + intCountChildren
        Return intTourCount

    End Function

    Private Sub chkAAADiscount_CheckedChanged(sender As Object, e As EventArgs) Handles chkAAADiscount.CheckedChanged

    End Sub
End Class
