' Public IP address interface
'
' This interface defines the stuructre that all public IP address providers must implement.

Public Interface PublicAddressProviderInterface
    Function FetchData() As Nullable
    Function GetPublicAddress() As String
    Function GetFlag() As Bitmap
    Function GetCountry() As String
End Interface