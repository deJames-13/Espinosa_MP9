Public Class CheckForm
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        PurchaseInfo.mtextID.Text = CustomerInfo.mtextID.Text
        PurchaseInfo.txtPrice.Text = fPrice.ToString("c2")
        PurchaseInfo.txtQuant.Text = fQuant

        isRetail = getStatus(rdbRet1)
        fShipCost = getShipCost(rdbPostal2, rdbGrd2)
        accExtras = getExtras(chkOne, chkMem, chkSale)
        fTotal = ComputeTotal()

        PrintOutput()
        switchPage(PurchaseInfo.PageContainer, currentPage)
    End Sub
End Class