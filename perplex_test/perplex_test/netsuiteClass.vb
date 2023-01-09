Public Class netsuiteClass
    Public Property document As String
    Public Property companyName As String
    Public Property address As String
    Public Property poNumber As String
    Public Property poDate As String
    Public Property purchaseFrom As New NpurchaseFrom
    Public Property shipTo As New NshipTo
    Public Property shippingMethod As String
    Public Property paymentTerms As String
    Public Property requiredByDate As String
    Public Property items As New List(Of netsuiteItem)()
    Public Property subtotal As String
    Public Property salesTax As String
    Public Property orderTotal As String
    Public Property approvedBy As String
    Public Property stubs As New netsuiteStubs

End Class

Public Class NpurchaseFrom
    Public Property vendorID As String
    Public Property vendorName As String
    Public Property address As String
    Public Property contactName As String
End Class

Public Class NshipTo
    Public Property companyName As String
    Public Property address As String
    Public Property contactName As String
End Class

Public Class netsuiteItem
    Public Property itemDescription As String
    Public Property quantity As String
    Public Property unitPrice As String
    Public Property amount As String
    Public Property itemStub As netsuiteItemStub
End Class

Public Class netsuiteStubs
    Public Property description As String
    Public Property operatingUnit As String
    Public Property rev As String
    Public Property billTo As String
    Public Property status As String
    Public Property pCard As String
    Public Property contact As String
    Public Property currency As String
    Public Property type As String

End Class

Public Class netsuiteItemStub
    Public Property UOM As String
    Public Property rev As String
    Public Property job As String
    Public Property category As String
    Public Property promised As String
    Public Property supplierItem As String
    Public Property supplierConfigID As String

End Class