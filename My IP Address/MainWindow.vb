Imports System.ComponentModel
Imports System.Net
Imports System.Net.NetworkInformation

Public Class MainWindow
    Dim PublicIPString, AdapterNamesString, LocalIPv4String, LocalIPv6String As String
    Dim heightIP As Integer
    Dim PublicAddressProvider As PublicAddressProviderInterface
    Dim LocalAddressesProvider As LocalAddressFetcher

    ' INIT FUNCTION
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        PublicAddressProvider = New PublicAddressProviderIPAPI
        LocalAddressesProvider = New LocalAddressFetcher

        PublicIPfetcher.RunWorkerAsync()
        LocalIPfetcher.RunWorkerAsync()
    End Sub

    Private Sub UncheckAllProviders()
        For Each item As ToolStripMenuItem In PublicAddressProviderToolStripMenuItem.DropDownItems
            item.Checked = False
        Next
    End Sub

    ' CONTEXT MENU CONTROLS
    ' CopyContextMenu
    Private Sub CopyContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles CopyContextMenu.Opening
        Dim SourceControl As TextBox = sender.SourceControl
        If String.IsNullOrEmpty(SourceControl.SelectedText) Then
            CopyToolStripMenuItem.Enabled = False
        Else
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim SourceControl As TextBox = sender.Owner.SourceControl
        Clipboard.SetText(SourceControl.SelectedText)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim SourceControl As TextBox = sender.Owner.SourceControl
        SourceControl.Select(0, SourceControl.Text.Length)
    End Sub

    ' CopyLocalContextMenu
    Private Sub CopyLocalContextMenu_Opening(sender As Object, e As CancelEventArgs) Handles CopyLocalContextMenu.Opening
        Dim SourceControl As ListView = sender.SourceControl
        If SourceControl.SelectedItems.Count = 0 Then
            CopyNameToolStripMenuItem.Enabled = False
            CopyIPv4ToolStripMenuItem.Enabled = False
            CopyIPv6ToolStripMenuItem.Enabled = False
        Else
            CopyNameToolStripMenuItem.Enabled = True
            CopyIPv4ToolStripMenuItem.Enabled = True
            CopyIPv6ToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub CopyNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyNameToolStripMenuItem.Click
        Dim SourceControl As ListView = sender.Owner.SourceControl
        Clipboard.SetText(SourceControl.SelectedItems(0).Text)
    End Sub

    Private Sub CopyIPv4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyIPv4ToolStripMenuItem.Click
        Dim SourceControl As ListView = sender.Owner.SourceControl
        Clipboard.SetText(SourceControl.SelectedItems(0).SubItems(1).Text)
    End Sub

    Private Sub CopyIPv6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyIPv6ToolStripMenuItem.Click
        Dim SourceControl As ListView = sender.Owner.SourceControl
        Clipboard.SetText(SourceControl.SelectedItems(0).SubItems(2).Text)
    End Sub


    ' TOOLBAR CONTROLS
    ' Sub: File
    Private Sub IpapiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IpapiToolStripMenuItem.Click
        UncheckAllProviders()
        sender.checked = True

        PublicAddressProvider = New PublicAddressProviderIPAPI
    End Sub

    Private Sub IpinfoioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IpinfoioToolStripMenuItem.Click
        UncheckAllProviders()
        sender.checked = True

        PublicAddressProvider = New PublicAddressProviderIPInfo
    End Sub

    Private Sub IpifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IpifyToolStripMenuItem.Click
        UncheckAllProviders()
        sender.checked = True

        PublicAddressProvider = New PublicAddressProviderIPIFY
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    ' Sub: Refresh
    Private Sub AllAddressesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllAddressesToolStripMenuItem.Click
        sender.Enabled = False
        PublicAddressToolStripMenuItem.Enabled = False
        LocalAddressToolStripMenuItem.Enabled = False

        PublicIP.Text = "Loading..."
        PublicFlag.Image = Nothing
        AdaptersListView.Items.Clear()

        PublicIPfetcher.RunWorkerAsync()
        LocalIPfetcher.RunWorkerAsync()
    End Sub

    Private Sub PublicAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublicAddressToolStripMenuItem.Click
        sender.Enabled = False
        AllAddressesToolStripMenuItem.Enabled = False

        PublicIP.Text = "Loading..."
        PublicFlag.Image = Nothing
        PublicIPfetcher.RunWorkerAsync()
    End Sub

    Private Sub LocalAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalAddressToolStripMenuItem.Click
        sender.Enabled = False
        AllAddressesToolStripMenuItem.Enabled = False

        AdaptersListView.Items.Clear()

        LocalIPfetcher.RunWorkerAsync()
    End Sub

    ' Sub: Help
    Private Sub ViewOnGitHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewOnGitHubToolStripMenuItem.Click
        Process.Start("https://github.com/Kowalski7/My-IP-Address")
    End Sub

    ' BACKGROUND WORKERS
    Private Sub PublicIPfetcher_DoWork(sender As Object, e As DoWorkEventArgs) Handles PublicIPfetcher.DoWork
        PublicAddressProvider.FetchData()
    End Sub

    Private Sub PublicIPfetcher_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles PublicIPfetcher.RunWorkerCompleted
        PublicIP.Text = PublicAddressProvider.GetPublicAddress()
        PublicFlag.Image = PublicAddressProvider.GetFlag()
        CountryTooltip.SetToolTip(PublicFlag, PublicAddressProvider.GetCountry())

        PublicAddressToolStripMenuItem.Enabled = True

        If Not LocalIPfetcher.IsBusy Then
            AllAddressesToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub LocalIPfetcher_DoWork(sender As Object, e As DoWorkEventArgs) Handles LocalIPfetcher.DoWork
        LocalAddressesProvider.FetchData()
    End Sub

    Private Sub LocalIPfetcher_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LocalIPfetcher.RunWorkerCompleted
        Dim addresses = LocalAddressesProvider.GetLocalAddresses()

        For Each kvp As KeyValuePair(Of String, List(Of List(Of String))) In addresses
            ' Create new item containing the adapter's name
            Dim adapterListItem As New ListViewItem(kvp.Key)

            ' Add IPv4 addresses
            adapterListItem.SubItems.Add(String.Join("; ", kvp.Value(0)))

            ' Add IPv6 addresses
            adapterListItem.SubItems.Add(String.Join("; ", kvp.Value(1)))

            ' Add item to ListView
            AdaptersListView.Items.Add(adapterListItem)
        Next

        LocalAddressToolStripMenuItem.Enabled = True

        If Not PublicIPfetcher.IsBusy Then
            AllAddressesToolStripMenuItem.Enabled = True
        End If
    End Sub
End Class
