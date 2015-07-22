Public Class frmDisplayInvoice
    Public Shared _decTotalTour1 As Decimal
    Public Shared _decTotalTour2 As Decimal
    Public Shared _decTotalTour3 As Decimal
    Public Shared _decTourSubTotal As Decimal
    Public Shared _decDiscountChild As Decimal
    Public Shared _decDiscountAAA As Decimal
    Public Shared _decDiscountMilitary As Decimal

    Dim decTax As Decimal
    Dim decServiceCharge As Decimal
    Dim decSubTotal As Decimal
    Dim decFinalTotal As Decimal

    Const cdecTaxPercent As Decimal = 0.15D
    Const cdecServiceChargePercent As Decimal = 0.07D
    Private Sub frmDisplayInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        decSubTotal = _decTourSubTotal - _decDiscountAAA - _decDiscountChild
        decTax = decSubTotal * cdecTaxPercent
        decServiceCharge = decSubTotal * cdecServiceChargePercent

        decFinalTotal = decTax + decServiceCharge + decSubTotal

        lblTour1Total.Text = _decTotalTour1.ToString("C")
        lblTour2Total.Text = _decTotalTour2.ToString("C")
        lblTour3Total.Text = _decTotalTour3.ToString("C")
        lblTourSubtotal.Text = _decTourSubTotal.ToString("C")
        lblAAADiscount.Text = _decDiscountAAA.ToString("C")
        lblChildDiscount.Text = _decDiscountChild.ToString("C")
        lblMilitaryDiscount.Text = _decDiscountMilitary.ToString("C")
        lblSubtotal.Text = decSubTotal.ToString("C")
        lblTax.Text = decTax.ToString("C")
        lblServiceCharge.Text = decServiceCharge.ToString("C")
        lblFinalTotal.Text = decFinalTotal.ToString("C")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub
End Class