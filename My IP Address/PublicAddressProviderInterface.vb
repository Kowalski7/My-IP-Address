' Public IP address interface
'
' This interface defines the stuructre that all public IP address providers must implement.

Public Interface PublicAddressProviderInterface
    Sub FetchData()
    Function GetPublicAddress() As String
    Function GetFlag() As Bitmap
    Function GetCountry() As String
End Interface