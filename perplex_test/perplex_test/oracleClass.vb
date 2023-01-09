Public Class oracleClass
    Public Property operatingUnit As String
    Public Property PO As String
    Public Property rev As String
    Public Property supplier As String
    Public Property shipTo As String
    Public Property buyer As String
    Public Property created As String
    Public Property type As String
    Public Property site As String
    Public Property billTo As String
    Public Property status As String
    Public Property pCard As String
    Public Property contact As String
    Public Property currency As String
    Public Property total As String
    Public Property description As String
    Public Property items As New List(Of oracleItem)()
    Public Property stubs As New oracleStubs

End Class

Public Class oracleItem
    Public Property num As String
    Public Property type As String
    Public Property item As String
    Public Property rev As String
    Public Property job As String
    Public Property category As String
    Public Property description As String
    Public Property UOM As String
    Public Property quantity As String
    Public Property price As String
    Public Property promised As String
    Public Property needBy As String
    Public Property supplierItem As String
    Public Property supplierConfigID As String
    Public Property amount As String
    Public Property chargeAccount As String

End Class


Public Class oracleStubs
    Public Class Ocompany
        Public Property companyName As String
        Public Property address As String
        Public Property contactNo As String
        Public Property TIN As String
    End Class


    Public Class Ovendor
        Public Property address As String
        Public Property contactNo As String
    End Class

    Public Class OshipTo
        Public Property contactNo As String
    End Class

    Public Class OtermsAndCondition
        Public Property payment As String
    End Class

    Public Property company As Ocompany
    Public Property vendor As Ovendor
    Public Property shipTo As OshipTo
    Public Property pageNumber As String
    Public Property tax As String
    Public Property totalPlusTax As String
    Public Property termsAndCondition As String
End Class

