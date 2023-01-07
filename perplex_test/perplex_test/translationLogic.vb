Imports System.IO
Imports System.Text

Module translationLogic
    Sub sap2oracle(ByVal srcPath As String)

        'Output class creation
        Dim oracle As oracleClass = New oracleClass
        Dim read = Newtonsoft.Json.Linq.JObject.Parse(srcPath)
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
        For i As Integer = 0 To read.Item("items").ToArray.Length
            ' Hope repeated dims are allowed
            Dim tempItem As oracleItem = New oracleItem
            tempItem.num = read.Item("items")(i)("itemNo").ToString
            tempItem.type = ""
            tempItem.item = read.Item("items")(i)("vendorItemCode").ToString
            tempItem.rev = ""
            tempItem.job = ""
            tempItem.category = ""
            tempItem.description = read.Item("items")(i)("itemCodeDescritpion").ToString
            tempItem.UOM = read.Item("items")(i)("UOM").ToString
            tempItem.quantity = read.Item("items")(i)("quantity").ToString
            tempItem.price = read.Item("items")(i)("unitPrice").ToString
            tempItem.promised = ""
            tempItem.needBy = read.Item("items")(i)("deliveryDate").ToString
            tempItem.supplierItem = ""
            tempItem.supplierConfigID = ""
            tempItem.amount = read.Item("items")(i)("amount").ToString

            ' No idea what charge account is. Did not add yet
            ' Pray that somehow the list made is a shallow copy of the dict
            ' If not, find out a way to make a shallow copy that is repeatable

            ' LIKELY DEATH POINT
            oracle.items.Add(tempItem)
        Next

        ' Put stubs here kung sinipag
        Dim fs As FileStream = File.Create(srcPath)
        Dim strserialize As String = Newtonsoft.Json.JsonConvert.SerializeObject(oracle)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(strserialize)
        fs.Write(info, 0, info.Length)
        fs.Close()

    End Sub




End Module
