Imports System.Globalization

Module ComputationModule

    Public strName, strAddr, strTel, strProdID As String
    Public isRetail As Boolean = False
    Public fPrice, fQuant, fShipCost, fDisc, fDiscRt, fSubTot, fTax, fTotal, accExtras As Double
    Public arrInfos As New ArrayList()


    Public Function isEmpty(str As String()) As Boolean
        For Each s In str
            If String.IsNullOrEmpty(s) Then
                MsgBox("Input Required!", MsgBoxStyle.Exclamation, "Missing Info!")
                Return True
            End If
        Next
        Return False
    End Function

    Public Function validateNumeric(ByRef txtProdPrice As TextBox, ByRef txtQuant As TextBox) As Boolean

        If (txtProdPrice.Text.First() = "$") Then
            txtProdPrice.Text = txtProdPrice.Text.Remove(0, 1)
        End If

        If (Not IsNumeric(txtQuant.Text)) Then
            MsgBox("Invalid Numeric input found! Please input a valid number!", MsgBoxStyle.Exclamation, "Missing Info!")
            txtQuant.Clear()
            txtProdPrice.Focus()
            Return True
        ElseIf (Not IsNumeric(txtProdPrice.Text)) Then
            MsgBox("Invalid Numeric input found! Please input a valid number!", MsgBoxStyle.Exclamation, "Missing Info!")
            txtProdPrice.Clear()
            txtProdPrice.Focus()
            Return True
        ElseIf CInt(txtProdPrice.Text) < 0 Then
            MsgBox("Price must be a number greater than 0!", MsgBoxStyle.Exclamation, "Invalid Info!")
            txtProdPrice.Clear()
            txtProdPrice.Focus()
            Return True
        ElseIf CInt(txtQuant.Text) < 0 Then
            txtProdPrice.Text = CDec(txtProdPrice.Text).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            MsgBox("Quantity must be a number greater than 0!", MsgBoxStyle.Exclamation, "Invalid Info!")
            txtQuant.Clear()
            txtQuant.Focus()
            Return True
        End If
        Return False
    End Function

    Public Sub setValues(name As String, addr As String, tel As String, prodId As String, price As Double, quant As Double)
        strName = name
        strAddr = addr
        strTel = tel
        strProdID = prodId
        fPrice = price
        fQuant = quant
        isRetail = False
    End Sub

    Public Function getStatus(rdbRet1 As RadioButton) As Boolean
        Dim retail As Boolean = False
        fDiscRt = 0.1
        If rdbRet1.Checked Then
            fDiscRt = 0
            retail = True
        End If
        Return retail
    End Function


    Public Function getShipCost(rdbPostal2 As RadioButton, rdbGrd2 As RadioButton) As Double
        Dim cost As Double
        cost = 25 * fQuant
        If rdbPostal2.Checked Then
            cost = 12 * fQuant
        ElseIf rdbGrd2.Checked Then
            cost = 20 * fQuant
        End If
        Return cost
    End Function

    Public Function getExtras(chkWarrant3 As CheckBox, chkMemb3 As CheckBox, chkSale3 As CheckBox) As Double
        Dim extras As Double = 0
        If chkWarrant3.Checked Then
            extras += 75
        End If
        If chkMemb3.Checked Then
            extras += 150
        End If
        If chkSale3.Checked Then
            extras += 25
        End If
        Return extras
    End Function

    Public Function ComputeTotal() As Double
        fDisc = getDiscount()
        fSubTot = getSubTotal()
        fTax = getTax(fSubTot)
        Dim total As Double = fSubTot + fTax
        Return total
    End Function

    Public Function getDiscount() As Double
        Return (fPrice * fQuant) * fDiscRt
    End Function

    Public Function getSubTotal() As Double
        Return ((fPrice * fQuant) + fShipCost + accExtras) - fDisc
    End Function


    Public Function getTax(subTotal As Double) As Double
        Dim tax As Double = 0
        If isRetail Then
            tax = subTotal * 0.05
        End If
        Return tax
    End Function

    Public Sub PrintOutput()
        Dim f As PurchaseInfo = PurchaseInfo
        f.txtShip.Text = fShipCost.ToString("C2")
        f.txtExtras.Text = accExtras.ToString("C2")
        f.txtDisc.Text = fDisc.ToString("C2")
        f.txtSub.Text = fSubTot.ToString("C2")
        f.txtTax.Text = fTax.ToString("C2")
        f.txtTotal.Text = fTotal.ToString("C2")
    End Sub

    Public Sub ProcessPrintSummary()
        Dim totalDisc, ave, quantity As Decimal
        For Each s In arrInfos
            Dim arr As Array = Split(s, "/")
            If arr(0) = "Whole Sale" Then
                totalDisc += arr(7)
                quantity += arr(4)
            End If
        Next
        ave = totalDisc / quantity

        SummaryForm.lblDisc.Text = totalDisc.ToString("c2")
        SummaryForm.lblQuant.Text = quantity
        SummaryForm.lblAver.Text = totalDisc.ToString("c2")

    End Sub

    Public Sub SaveInput()
        Dim type As String = "Whole Sale"
        If isRetail Then
            type = "Retail"
        End If

        Dim strInput As String = type & "/" & strName & "/" & strProdID & "/" & fPrice & "/" & fQuant & "/" & fShipCost & "/" & accExtras & "/" & fDisc & "/" & fDisc & "/" & fSubTot & "/" & fTax
        arrInfos.Add(strInput)

    End Sub

    Public Function splitArray(arr As ArrayList, n As Integer, d As Char) As Array
        Return Split(arr(n), d)
    End Function

    Public Sub addToGrid()
        Dim nr1, nr2, nr3 As Integer
        For idx As Integer = DataGridsForm.dtGridMain.RowCount To arrInfos.Count - 1
            Dim arr = splitArray(arrInfos, idx, "/")

            nr1 = DataGridsForm.dtGridMain.Rows.Add
            If arr(0) = "Retail" Then
                nr2 = DataGridsForm.dtGridRetail.Rows.Add
            Else
                nr3 = DataGridsForm.dtGridWhole.Rows.Add
            End If
            For cols As Integer = 0 To DataGridsForm.dtGridMain.ColumnCount - 1
                If arr(0) = "Retail" Then
                    DataGridsForm.dtGridRetail.Item(cols, nr2).Value = arr(cols)
                Else
                    DataGridsForm.dtGridWhole.Item(cols, nr3).Value = arr(cols)
                End If
                DataGridsForm.dtGridMain.Item(cols, nr1).Value = arr(cols)
            Next
        Next
    End Sub


    Public Sub ResetForm()
        fTax = 0
        fShipCost = 0
        accExtras = 0
        isRetail = False
        strName = ""
        strAddr = ""
        strTel = ""
        strProdID = ""
        Dim p As PurchaseInfo = PurchaseInfo
        Dim c As CustomerInfo = CustomerInfo
        Dim chk As CheckForm = CheckForm
        ClearAll({c.txtName, c.txtAddr, c.txtPrice, c.txtQuant, p.txtPrice, p.txtQuant, p.txtShip, p.txtExtras, p.txtDisc, p.txtSub, p.txtTax, p.txtTotal})
        c.mtextTel.Clear()
        c.mtextID.Clear()
        p.mtextID.Clear()
        chk.rdbWhole1.Checked = True
        chk.rdbRet1.Checked = False
        chk.rdbAir2.Checked = True
        chk.rdbGrd2.Checked = False
        chk.rdbPostal2.Checked = False
        chk.chkOne.Checked = False
        chk.chkMem.Checked = False
        chk.chkSale.Checked = False
    End Sub


End Module
