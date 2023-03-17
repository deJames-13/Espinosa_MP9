Public Class CustomerInfo
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If isEmpty({txtName.Text, txtAddr.Text, mtextTel.Text, mtextID.Text, txtPrice.Text, txtQuant.Text}) OrElse validateNumeric(txtPrice, txtQuant) Then
            Return
        End If
        If Not mtextTel.MaskCompleted Then
            MsgBox("Telephone Number is not Complete!", MsgBoxStyle.Exclamation, "Missing Info!")
            Return
        End If
        setValues(txtName.Text, txtAddr.Text, mtextTel.Text, mtextID.Text, CDbl(txtPrice.Text), CDbl(txtQuant.Text))
        switchPage(CheckForm.PageContainer, currentPage)
    End Sub
End Class