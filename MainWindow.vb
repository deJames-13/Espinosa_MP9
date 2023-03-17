Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPage(CustomerInfo.PageContainer, currentPage)
    End Sub
    Private Sub handleTool_Click(sender As Object, e As EventArgs) Handles toolCustInfo.Click, toolPurchInfo.Click, toolMenu.Click, toolExit.Click, toolDataGrids.Click, toolStatus.Click
        Dim tool As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Select Case tool.Name
            Case "toolCustInfo"
                switchPage(CustomerInfo.PageContainer, currentPage)
            Case "toolPurchInfo"
                switchPage(PurchaseInfo.PageContainer, currentPage)
            Case "toolStatus"
                switchPage(CheckForm.PageContainer, currentPage)
            Case "toolDataGrids"
                switchPage(DataGridsForm.PageContainer, currentPage)
            Case "toolExit"
                Me.Close()
        End Select

    End Sub

End Class
