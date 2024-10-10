Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions

Public Class LocalAddressFetcher
    Private addresses As Dictionary(Of String, List(Of List(Of String)))

    Private Function GetIPv4(UnicastAdresses As UnicastIPAddressInformationCollection)
        Dim ValidAddresses As New List(Of String)
        For Each address In UnicastAdresses
            If Regex.IsMatch(address.Address.ToString, "((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])") Then
                ValidAddresses.Add(address.Address.ToString)
            End If
        Next

        Return ValidAddresses
    End Function

    Private Function GetIPv6(UnicastAdresses As UnicastIPAddressInformationCollection)
        Dim ValidAddresses As New List(Of String)
        For Each address In UnicastAdresses
            If Regex.IsMatch(address.Address.ToString, "(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))") Then
                ValidAddresses.Add(address.Address.ToString)
            End If
        Next

        Return ValidAddresses
    End Function

    Public Sub FetchData()
        addresses = New Dictionary(Of String, List(Of List(Of String)))
        Dim NetworkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()

        For Each netadapter In NetworkInterfaces
            Dim intproperties As IPInterfaceProperties = netadapter.GetIPProperties()

            If netadapter.OperationalStatus = OperationalStatus.Up And netadapter.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then
                Dim IPv4Addresses As List(Of String) = GetIPv4(intproperties.UnicastAddresses)
                Dim IPv6Addresses As List(Of String) = GetIPv6(intproperties.UnicastAddresses)

                If IPv4Addresses.Count = 0 Then
                    IPv4Addresses.Add("-")
                End If

                If IPv6Addresses.Count = 0 Then
                    IPv6Addresses.Add("-")
                End If

                addresses.Add(netadapter.Name, New List(Of List(Of String)) From {IPv4Addresses, IPv6Addresses})
            End If
        Next
    End Sub

    Public Function GetLocalAddresses() As Dictionary(Of String, List(Of List(Of String)))
        Return addresses
    End Function
End Class
