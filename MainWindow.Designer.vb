<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.WindowPanel = New System.Windows.Forms.Panel()
        Me.MainPage = New System.Windows.Forms.Panel()
        Me.MainPageContainer = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolCustInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPurchInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolDataGrids = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowPanel.SuspendLayout()
        Me.MainPage.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowPanel
        '
        Me.WindowPanel.Controls.Add(Me.MainPage)
        Me.WindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowPanel.Location = New System.Drawing.Point(0, 0)
        Me.WindowPanel.Name = "WindowPanel"
        Me.WindowPanel.Size = New System.Drawing.Size(984, 466)
        Me.WindowPanel.TabIndex = 2
        '
        'MainPage
        '
        Me.MainPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MainPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPage.Controls.Add(Me.MainPageContainer)
        Me.MainPage.Controls.Add(Me.Panel17)
        Me.MainPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPage.Location = New System.Drawing.Point(0, 0)
        Me.MainPage.Margin = New System.Windows.Forms.Padding(10)
        Me.MainPage.Name = "MainPage"
        Me.MainPage.Padding = New System.Windows.Forms.Padding(5)
        Me.MainPage.Size = New System.Drawing.Size(984, 466)
        Me.MainPage.TabIndex = 3
        '
        'MainPageContainer
        '
        Me.MainPageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPageContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MainPageContainer.Location = New System.Drawing.Point(5, 59)
        Me.MainPageContainer.Name = "MainPageContainer"
        Me.MainPageContainer.Size = New System.Drawing.Size(972, 400)
        Me.MainPageContainer.TabIndex = 7
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.MenuStrip1)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel17.Location = New System.Drawing.Point(5, 5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel17.Size = New System.Drawing.Size(972, 40)
        Me.Panel17.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolMenu, Me.toolCustInfo, Me.toolStatus, Me.toolPurchInfo, Me.toolDataGrids})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(960, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolMenu
        '
        Me.toolMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolExit})
        Me.toolMenu.Name = "toolMenu"
        Me.toolMenu.Size = New System.Drawing.Size(50, 24)
        Me.toolMenu.Text = "Menu"
        '
        'toolExit
        '
        Me.toolExit.Name = "toolExit"
        Me.toolExit.Size = New System.Drawing.Size(93, 22)
        Me.toolExit.Text = "Exit"
        '
        'toolCustInfo
        '
        Me.toolCustInfo.Name = "toolCustInfo"
        Me.toolCustInfo.Size = New System.Drawing.Size(137, 24)
        Me.toolCustInfo.Text = "Customer Information"
        '
        'toolStatus
        '
        Me.toolStatus.Name = "toolStatus"
        Me.toolStatus.Size = New System.Drawing.Size(102, 24)
        Me.toolStatus.Text = "Purchase Status"
        '
        'toolPurchInfo
        '
        Me.toolPurchInfo.Name = "toolPurchInfo"
        Me.toolPurchInfo.Size = New System.Drawing.Size(133, 24)
        Me.toolPurchInfo.Text = "Purchase Information"
        '
        'toolDataGrids
        '
        Me.toolDataGrids.Name = "toolDataGrids"
        Me.toolDataGrids.Size = New System.Drawing.Size(73, 24)
        Me.toolDataGrids.Text = "Data Grids"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(984, 466)
        Me.Controls.Add(Me.WindowPanel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.Text = "Welcome to my Form!"
        Me.WindowPanel.ResumeLayout(False)
        Me.MainPage.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowPanel As Panel
    Friend WithEvents MainPage As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolMenu As ToolStripMenuItem
    Friend WithEvents MainPageContainer As Panel
    Friend WithEvents toolExit As ToolStripMenuItem
    Friend WithEvents toolCustInfo As ToolStripMenuItem
    Friend WithEvents toolPurchInfo As ToolStripMenuItem
    Friend WithEvents toolDataGrids As ToolStripMenuItem
    Friend WithEvents toolStatus As ToolStripMenuItem
End Class
