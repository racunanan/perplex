Public Class sapClass
    Public Property documentType As String
    Public Property company As New sCompany
    Public Property vendor As New sVendor
    Public Property shipTo As New sShipTo
    Public Property poNumber As String
    Public Property poDate As String
    Public Property pageNumber As String
    Public Property items As New List(Of sapItem)()
    Public Property total As String
    Public Property tax As String
    Public Property totalPlusTax As String
    Public Property termsAndCondition As New sTermsAndCondition
    ' No stubs yet
End Class

Public Class sCompany
    Public Property companyName As String
    Public Property address As String
    Public Property contactNo As String
    Public Property TIN As String
End Class

Public Class sVendor
    Public Property name As String
    Public Property address As String
    Public Property contactNo As String
    Public Property TIN As String
End Class

Public Class sShipTo
    Public Property name As String
    Public Property address As String
    Public Property contactNo As String
End Class

Public Class sTermsAndCondition
    Public Property payment As String
    Public Property issuedBy As String
    Public Property remarks As String
End Class

Public Class sapItem
    Public Property itemNo As String
    Public Property vendorItemCode As String
    Public Property itemCodeItemDescription As String
    Public Property UOM As String
    Public Property deliveryDate As String
    Public Property quantity As String
    Public Property unitPrice As String
    Public Property amount As String
End Class