Module MainWindowModule
    Public currentPage As Panel = CustomerInfo.PageContainer
    Public Sub ClearAll(ts As TextBox())
        For Each t In ts
            t.Clear()
        Next
    End Sub
    Public Sub switchPage(ByRef newPage As Panel, ByRef currentPage As Panel)
        currentPage.Hide()
        newPage.Parent = MainWindow.MainPageContainer
        newPage.Dock = DockStyle.Fill
        newPage.Show()
        newPage.Focus()
        currentPage = newPage
    End Sub
End Module
