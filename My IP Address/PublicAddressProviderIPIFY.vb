Imports System.IO
Imports System.Net

Public Class PublicAddressProviderIPIFY
    Implements PublicAddressProviderInterface

    Private ip As String

    Public Sub FetchData() Implements PublicAddressProviderInterface.FetchData
        Try
            ' Fetch data
            Dim request As HttpWebRequest = WebRequest.Create("https://api.ipify.org/")
            request.Timeout = 5000

            Dim response As HttpWebResponse = request.GetResponse()

            ' Read response
            Dim reader As New StreamReader(response.GetResponseStream())
            ip = reader.ReadLine()
            reader.Close()
        Catch
            ip = "N/A"
        End Try
    End Sub

    Public Function GetPublicAddress() As String Implements PublicAddressProviderInterface.GetPublicAddress
        Return ip
    End Function

    Public Function GetFlag() As Bitmap Implements PublicAddressProviderInterface.GetFlag
        Return My.Resources.flag_UNKNOWN
    End Function

    Public Function GetCountry() As String Implements PublicAddressProviderInterface.GetCountry
        Return "Not supported by provider"
    End Function
End Class