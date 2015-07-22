Public Class frmDisplayTourCosts

    Private Sub frmDisplayTourCosts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lblTourNameHeader As New Label()
        lblTourNameHeader.Text = "TOUR NAME"
        lblTourNameHeader.Font = New Font("Tahoma", 12)

        Dim lblTourTypeHeader As New Label()
        lblTourTypeHeader.Text = "TYPE"
        lblTourTypeHeader.Font = New Font("Tahoma", 12)

        Dim lblTourPricePerHeader As New Label()
        lblTourPricePerHeader.Text = "PRICE"
        lblTourPricePerHeader.Font = New Font("Tahoma", 12)

        Dim lblTourDurationHeader As New Label()
        lblTourDurationHeader.Text = "DURATION"
        lblTourDurationHeader.Font = New Font("Tahoma", 12)

        tblDisplay.Controls.Add(lblTourNameHeader, 0, 0)
        tblDisplay.Controls.Add(lblTourTypeHeader, 1, 0)
        tblDisplay.Controls.Add(lblTourPricePerHeader, 2, 0)
        tblDisplay.Controls.Add(lblTourDurationHeader, 3, 0)

        For intCounter = 0 To 8
            Dim lblTourName As New Label()
            lblTourName.Text = frmReservationSystem._strTourName(intCounter)
            lblTourName.MinimumSize = New Size(265, 30)

            Dim lblTourType As New Label()
            lblTourType.Text = frmReservationSystem._strTourType(intCounter)

            Dim lblTourPricePer As New Label()
            lblTourPricePer.Text = (frmReservationSystem._decTourPricePer(intCounter)).ToString("C")

            Dim lblTourDuration As New Label()
            lblTourDuration.Text = (frmReservationSystem._decTourDuration(intCounter)).ToString("F") & " hours"

            tblDisplay.Controls.Add(lblTourName, 0, intCounter + 1)
            tblDisplay.Controls.Add(lblTourType, 1, intCounter + 1)
            tblDisplay.Controls.Add(lblTourPricePer, 2, intCounter + 1)
            tblDisplay.Controls.Add(lblTourDuration, 3, intCounter + 1)
        Next
        Controls.Add(tblDisplay)
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub
End Class