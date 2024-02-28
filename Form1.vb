Public Class Form1

    Const decFica As Decimal = 0.0765
    Const decFederal As Decimal = 0.22
    Const decState As Decimal = 0.04

    Private Sub btnTaxes_Click(sender As Object, e As EventArgs) Handles btnTaxes.Click
        Dim strGrossPay As String
        Dim decGrossPay As Decimal
        Dim decFicaPay As Decimal
        Dim decFederalPay As Decimal
        Dim decStatePay As Decimal
        Dim decTotalTaxes As Decimal
        Dim decTotal As Decimal

        strGrossPay = txtCal.Text
        decGrossPay = Convert.ToDecimal(strGrossPay)
        decFicaPay = decGrossPay * decFica
        decFederalPay = decGrossPay * decFederal
        decStatePay = decGrossPay * decState
        decTotalTaxes = decFicaPay + decFederalPay + decStatePay
        decTotal = decGrossPay - decTotalTaxes
        ficaResults.Text = decFicaPay.ToString("C")
        federalResults.Text = decFederalPay.ToString("C")
        stateResults.Text = decStatePay.ToString("C")
        lblResults.Text = decTotal.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCal.Clear()
        ficaResults.Text = ""
        federalResults.Text = ""
        stateResults.Text = ""
        lblResults.Text = ""
        txtCal.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCal.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
