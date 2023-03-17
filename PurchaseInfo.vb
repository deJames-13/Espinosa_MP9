Public Class PurchaseInfo

    Private Sub PageContainer_Enter(sender As Object, e As EventArgs) Handles PageContainer.Enter
        PageContainer.Focus()
    End Sub
    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        Dim m As Integer = MessageBox.Show("Would you like to save your info?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = 6 Then
            SaveInput()
        End If
        switchPage(CustomerInfo.PageContainer, currentPage)
        ResetForm()
    End Sub

    Private Sub btnAddToGrid_Click(sender As Object, e As EventArgs) Handles btnAddToGrid.Click
        switchPage(DataGridsForm.PageContainer, currentPage)
        Dim m As Integer = MessageBox.Show("Would you like to save your info?", "Save Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = 6 Then
            SaveInput()
        End If
        addToGrid()
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        ProcessPrintSummary()
        switchPage(SummaryForm.PageContainer, currentPage)
    End Sub
End Class