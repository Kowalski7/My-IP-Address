Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net

Public Class PublicAddressProviderIPAPI
    Implements PublicAddressProviderInterface

    Private ip As String
    Private country As String
    Private countryCode As String

    Public Function FetchData() As Nullable Implements PublicAddressProviderInterface.FetchData
        Try
            ' Fetch data
            Dim request As HttpWebRequest = HttpWebRequest.Create("http://ip-api.com/json")
            Dim response As HttpWebResponse = request.GetResponse()

            ' Read response
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim json As String = reader.ReadToEnd()
            reader.Close()
            response.Close()

            ' Parse response data as JSON
            Dim data As JObject = JObject.Parse(json)
            ip = data("query")
            country = data("country")
            countryCode = data("countryCode")
        Catch
            ip = "N/A"
        End Try

        Return Nothing
    End Function

    Public Function GetPublicAddress() As String Implements PublicAddressProviderInterface.GetPublicAddress
        Return ip
    End Function

    Public Function GetFlag() As Bitmap Implements PublicAddressProviderInterface.GetFlag
        Dim flag = My.Resources.ResourceManager.GetObject("flag_" + countryCode.ToUpper)

        Return If(flag, My.Resources.flag_UNKNOWN)
    End Function

    Public Function GetCountry() As String Implements PublicAddressProviderInterface.GetCountry
        Return If(country, "Unknown")
    End Function
End Class
