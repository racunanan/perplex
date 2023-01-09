Imports System.IO
Imports System.Text

Module translationLogic
    Sub sap2oracle(ByVal srcPath As String)
        'Output class creation
        Dim oracle As oracleClass = New oracleClass
        Dim json As String
        json = My.Computer.FileSystem.ReadAllText(srcPath, System.Text.Encoding.Default)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

        oracle.operatingUnit = ""
        oracle.PO = read.Item("poNumber").ToString
        oracle.rev = ""
        oracle.supplier = read.Item("vendor")("name").ToString
        oracle.shipTo = read.Item("shipTo")("name").ToString
        oracle.buyer = ""
        oracle.created = read.Item("poDate").ToString
        oracle.type = read.Item("documentType").ToString
        oracle.site = read.Item("shipTo")("address").ToString
        oracle.billTo = ""
        oracle.status = ""
        oracle.pCard = ""
        oracle.contact = ""
        oracle.currency = ""
        oracle.total = ""
        oracle.description = ""

        ' Filling up items field
        For i As Integer = 0 To read.Item("items").ToArray.Length - 1
            Dim tempItem As oracleItem = New oracleItem

            tempItem.num = read.Item("items")(i)("itemNo").ToString
            tempItem.type = ""
            tempItem.item = read.Item("items")(i)("vendorItemCode").ToString
            tempItem.rev = ""
            tempItem.job = ""
            tempItem.category = ""
            tempItem.description = read.Item("items")(i)("itemCodeItemDescription").ToString
            tempItem.UOM = read.Item("items")(i)("UOM").ToString
            tempItem.quantity = read.Item("items")(i)("quantity").ToString
            tempItem.price = read.Item("items")(i)("unitPrice").ToString
            tempItem.promised = ""
            tempItem.needBy = read.Item("items")(i)("deliveryDate").ToString
            tempItem.supplierItem = ""
            tempItem.supplierConfigID = ""
            tempItem.amount = read.Item("items")(i)("amount").ToString
            tempItem.chargeAccount = ""

            oracle.items.Add(tempItem)
        Next

        ' Put stubs here kung sinipag

        Dim fs As FileStream = File.Create(GlobalVariables.filepath + "/converted_" + GlobalVariables.filename)
        Dim strserialize As String = Newtonsoft.Json.JsonConvert.SerializeObject(oracle)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strserialize)
        fs.Write(info, 0, info.Length)
        fs.Close()

    End Sub

    Sub sap2netsuite(ByVal srcPath As String)
        Dim netsuite As New netsuiteClass
        Dim json As String
        json = My.Computer.FileSystem.ReadAllText(srcPath, System.Text.Encoding.Default)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

        netsuite.document = read.Item("documentType").ToString
        netsuite.companyName = read.Item("company")("companyName").ToString
        netsuite.address = read.Item("company")("address").ToString
        netsuite.poNumber = read.Item("poNumber").ToString
        netsuite.poDate = read.Item("poDate").ToString
        netsuite.purchaseFrom.vendorID = ""
        netsuite.purchaseFrom.vendorName = read.Item("vendor")("name").ToString
        netsuite.purchaseFrom.address = read.Item("vendor")("address").ToString
        netsuite.purchaseFrom.contactName = ""
        netsuite.shipTo.companyName = read.Item("shipTo")("name").ToString
        netsuite.shipTo.address = read.Item("shipTo")("address").ToString
        netsuite.shipTo.contactName = ""
        netsuite.shippingMethod = ""
        netsuite.paymentTerms = read.Item("termsAndCondition")("payment").ToString
        netsuite.requiredByDate = read.Item("items")(0)("deliveryDate").ToString

        ' Filling up items field
        For i As Integer = 0 To read.Item("items").ToArray.Length - 1
            Dim tempItem As netsuiteItem = New netsuiteItem
            tempItem.itemDescription = read.Item("items")(i)("itemCodeItemDescription").ToString
            tempItem.quantity = read.Item("items")(i)("quantity").ToString
            tempItem.unitPrice = read.Item("items")(i)("unitPrice").ToString
            tempItem.amount = read.Item("items")(i)("amount").ToString
            ' Stub for items here if you wish
            netsuite.items.Add(tempItem)
        Next
        netsuite.subtotal = read.Item("total").ToString
        netsuite.salesTax = read.Item("tax").ToString
        netsuite.orderTotal = read.Item("totalPlusTax").ToString
        netsuite.approvedBy = read.Item("termsAndCondition")("issuedBy").ToString
        ' Put stubs here kung sinipag


        Dim fs As FileStream = File.Create(GlobalVariables.filepath + "/converted_" + GlobalVariables.filename)
        Dim strserialize As String = Newtonsoft.Json.JsonConvert.SerializeObject(netsuite)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strserialize)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Sub oracle2netsuite(ByVal srcPath As String)
        Dim netsuite As New netsuiteClass
        Dim json As String
        json = My.Computer.FileSystem.ReadAllText(srcPath, System.Text.Encoding.Default)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

        netsuite.document = read.Item("type").ToString
        netsuite.companyName = ""
        netsuite.address = ""
        netsuite.poNumber = read.Item("PO").ToString
        netsuite.poDate = read.Item("created").ToString
        netsuite.purchaseFrom.vendorID = ""
        netsuite.purchaseFrom.vendorName = read.Item("supplier").ToString
        netsuite.purchaseFrom.address = ""
        netsuite.purchaseFrom.contactName = ""
        netsuite.shipTo.companyName = read.Item("shipTo").ToString
        netsuite.shipTo.address = read.Item("site").ToString
        netsuite.shipTo.contactName = ""
        netsuite.shippingMethod = ""
        netsuite.paymentTerms = ""
        netsuite.requiredByDate = read.Item("items")(0)("needBy").ToString

        ' Filling up items field
        For i As Integer = 0 To read.Item("items").ToArray.Length - 1
            Dim tempItem As netsuiteItem = New netsuiteItem
            tempItem.itemDescription = read.Item("items")(i)("description").ToString
            tempItem.quantity = read.Item("items")(i)("quantity").ToString
            tempItem.unitPrice = read.Item("items")(i)("price").ToString
            tempItem.amount = read.Item("items")(i)("amount").ToString
            ' Stub for items here if you wish
            netsuite.items.Add(tempItem)
        Next
        netsuite.subtotal = read.Item("total").ToString
        netsuite.salesTax = ""
        netsuite.orderTotal = ""
        netsuite.approvedBy = read.Item("buyer").ToString
        ' Put stubs here kung sinipag


        Dim fs As FileStream = File.Create(GlobalVariables.filepath + "/converted_" + GlobalVariables.filename)
        Dim strserialize As String = Newtonsoft.Json.JsonConvert.SerializeObject(netsuite)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strserialize)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

    Sub oracle2sap(ByVal srcPath As String)
        Dim sap As New sapClass
        Dim json As String
        json = My.Computer.FileSystem.ReadAllText(srcPath, System.Text.Encoding.Default)
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(json)

        sap.documentType = read.Item("type").ToString
        sap.company.companyName = ""
        sap.company.address = ""
        sap.company.TIN = ""
        sap.vendor.name = read.Item("supplier").ToString
        sap.vendor.address = ""
        sap.vendor.contactNo = ""
        sap.vendor.TIN = ""
        sap.poNumber = read.Item("PO").ToString
        sap.poDate = read.Item("created").ToString
        sap.pageNumber = ""

        ' Filling up items field
        For i As Integer = 0 To read.Item("items").ToArray.Length - 1
            Dim tempItem As sapItem = New sapItem
            tempItem.itemNo = read.Item("items")(i)("num").ToString
            tempItem.vendorItemCode = read.Item("items")(i)("item").ToString
            tempItem.itemCodeItemDescription = read.Item("items")(i)("description").ToString
            tempItem.UOM = read.Item("items")(i)("UOM").ToString
            tempItem.deliveryDate = read.Item("items")(i)("needBy").ToString
            tempItem.quantity = read.Item("items")(i)("quantity").ToString
            tempItem.unitPrice = read.Item("items")(i)("price").ToString
            tempItem.amount = read.Item("items")(i)("amount").ToString
            ' Stub for items here if you wish
            sap.items.Add(tempItem)
        Next
        sap.total = read.Item("total").ToString
        sap.tax = ""
        sap.totalPlusTax = ""

        sap.termsAndCondition.payment = ""
        sap.termsAndCondition.issuedBy = read.Item("buyer").ToString
        sap.termsAndCondition.remarks = read.Item("description").ToString
        ' Put stubs here kung sinipag


        Dim fs As FileStream = File.Create(GlobalVariables.filepath + "/converted_" + GlobalVariables.filename)
        Dim strserialize As String = Newtonsoft.Json.JsonConvert.SerializeObject(sap)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strserialize)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub




End Module
