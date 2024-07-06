<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CopyContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublicIP = New System.Windows.Forms.TextBox()
        Me.PublicIPfetcher = New System.ComponentModel.BackgroundWorker()
        Me.LocalIPfetcher = New System.ComponentModel.BackgroundWorker()
        Me.AdaptersListView = New System.Windows.Forms.ListView()
        Me.AdapterName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IPv4Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IPv6Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CopyLocalContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyIPv4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyIPv6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllAddressesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PublicAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PublicAddressProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IpapiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IpinfoioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IpifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOnGitHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PublicFlag = New System.Windows.Forms.PictureBox()
        Me.CopyContextMenu.SuspendLayout()
        Me.CopyLocalContextMenu.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PublicFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your public IP address is"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Local IP addresses:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CopyContextMenu
        '
        Me.CopyContextMenu.AutoSize = False
        Me.CopyContextMenu.BackColor = System.Drawing.SystemColors.Control
        Me.CopyContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.CopyContextMenu.Name = "CopyContextMenu"
        Me.CopyContextMenu.ShowImageMargin = False
        Me.CopyContextMenu.Size = New System.Drawing.Size(98, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'PublicIP
        '
        Me.PublicIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicIP.BackColor = System.Drawing.SystemColors.Window
        Me.PublicIP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PublicIP.ContextMenuStrip = Me.CopyContextMenu
        Me.PublicIP.Font = New System.Drawing.Font("Bahnschrift", 21.75!)
        Me.PublicIP.Location = New System.Drawing.Point(12, 70)
        Me.PublicIP.Name = "PublicIP"
        Me.PublicIP.ReadOnly = True
        Me.PublicIP.Size = New System.Drawing.Size(710, 35)
        Me.PublicIP.TabIndex = 2
        Me.PublicIP.Text = "Loading..."
        Me.PublicIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PublicIPfetcher
        '
        '
        'LocalIPfetcher
        '
        '
        'AdaptersListView
        '
        Me.AdaptersListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdaptersListView.BackColor = System.Drawing.SystemColors.Window
        Me.AdaptersListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdaptersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AdapterName, Me.IPv4Address, Me.IPv6Address})
        Me.AdaptersListView.ContextMenuStrip = Me.CopyLocalContextMenu
        Me.AdaptersListView.Font = New System.Drawing.Font("Bahnschrift", 11.25!)
        Me.AdaptersListView.HideSelection = False
        Me.AdaptersListView.Location = New System.Drawing.Point(16, 168)
        Me.AdaptersListView.MultiSelect = False
        Me.AdaptersListView.Name = "AdaptersListView"
        Me.AdaptersListView.Size = New System.Drawing.Size(704, 166)
        Me.AdaptersListView.TabIndex = 4
        Me.AdaptersListView.UseCompatibleStateImageBehavior = False
        Me.AdaptersListView.View = System.Windows.Forms.View.Details
        '
        'AdapterName
        '
        Me.AdapterName.Text = "Adapter name"
        Me.AdapterName.Width = 220
        '
        'IPv4Address
        '
        Me.IPv4Address.Text = "IPv4"
        Me.IPv4Address.Width = 175
        '
        'IPv6Address
        '
        Me.IPv6Address.Text = "IPv6"
        Me.IPv6Address.Width = 286
        '
        'CopyLocalContextMenu
        '
        Me.CopyLocalContextMenu.BackColor = System.Drawing.SystemColors.Control
        Me.CopyLocalContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyNameToolStripMenuItem, Me.CopyIPv4ToolStripMenuItem, Me.CopyIPv6ToolStripMenuItem})
        Me.CopyLocalContextMenu.Name = "CopyLocalContextMenu"
        Me.CopyLocalContextMenu.Size = New System.Drawing.Size(136, 70)
        '
        'CopyNameToolStripMenuItem
        '
        Me.CopyNameToolStripMenuItem.Name = "CopyNameToolStripMenuItem"
        Me.CopyNameToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyNameToolStripMenuItem.Text = "Copy name"
        '
        'CopyIPv4ToolStripMenuItem
        '
        Me.CopyIPv4ToolStripMenuItem.Name = "CopyIPv4ToolStripMenuItem"
        Me.CopyIPv4ToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyIPv4ToolStripMenuItem.Text = "Copy IPv4"
        '
        'CopyIPv6ToolStripMenuItem
        '
        Me.CopyIPv6ToolStripMenuItem.Name = "CopyIPv6ToolStripMenuItem"
        Me.CopyIPv6ToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyIPv6ToolStripMenuItem.Text = "Copy IPv6"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllAddressesToolStripMenuItem, Me.ToolStripSeparator1, Me.PublicAddressToolStripMenuItem, Me.LocalAddressToolStripMenuItem})
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'AllAddressesToolStripMenuItem
        '
        Me.AllAddressesToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_refresh
        Me.AllAddressesToolStripMenuItem.Name = "AllAddressesToolStripMenuItem"
        Me.AllAddressesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AllAddressesToolStripMenuItem.Text = "All addresses"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'PublicAddressToolStripMenuItem
        '
        Me.PublicAddressToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_wan
        Me.PublicAddressToolStripMenuItem.Name = "PublicAddressToolStripMenuItem"
        Me.PublicAddressToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PublicAddressToolStripMenuItem.Text = "Public address"
        '
        'LocalAddressToolStripMenuItem
        '
        Me.LocalAddressToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_lan
        Me.LocalAddressToolStripMenuItem.Name = "LocalAddressToolStripMenuItem"
        Me.LocalAddressToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LocalAddressToolStripMenuItem.Text = "Local address"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkModeToolStripMenuItem, Me.ToolStripSeparator2, Me.PublicAddressProviderToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "&Settings"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.CheckOnClick = True
        Me.DarkModeToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_moon
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark mode"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'PublicAddressProviderToolStripMenuItem
        '
        Me.PublicAddressProviderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IpapiToolStripMenuItem, Me.IpinfoioToolStripMenuItem, Me.IpifyToolStripMenuItem})
        Me.PublicAddressProviderToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_server
        Me.PublicAddressProviderToolStripMenuItem.Name = "PublicAddressProviderToolStripMenuItem"
        Me.PublicAddressProviderToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PublicAddressProviderToolStripMenuItem.Text = "Public address provider"
        '
        'IpapiToolStripMenuItem
        '
        Me.IpapiToolStripMenuItem.CheckOnClick = True
        Me.IpapiToolStripMenuItem.Name = "IpapiToolStripMenuItem"
        Me.IpapiToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IpapiToolStripMenuItem.Tag = "1"
        Me.IpapiToolStripMenuItem.Text = "ip-api"
        '
        'IpinfoioToolStripMenuItem
        '
        Me.IpinfoioToolStripMenuItem.CheckOnClick = True
        Me.IpinfoioToolStripMenuItem.Name = "IpinfoioToolStripMenuItem"
        Me.IpinfoioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IpinfoioToolStripMenuItem.Tag = "1"
        Me.IpinfoioToolStripMenuItem.Text = "ipinfo.io"
        '
        'IpifyToolStripMenuItem
        '
        Me.IpifyToolStripMenuItem.CheckOnClick = True
        Me.IpifyToolStripMenuItem.Name = "IpifyToolStripMenuItem"
        Me.IpifyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IpifyToolStripMenuItem.Tag = "1"
        Me.IpifyToolStripMenuItem.Text = "ipify"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem, Me.ViewOnGitHubToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Enabled = False
        Me.CheckForUpdatesToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_update
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for updates"
        '
        'ViewOnGitHubToolStripMenuItem
        '
        Me.ViewOnGitHubToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_github
        Me.ViewOnGitHubToolStripMenuItem.Name = "ViewOnGitHubToolStripMenuItem"
        Me.ViewOnGitHubToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ViewOnGitHubToolStripMenuItem.Text = "View on GitHub"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.My_IP_Address.My.Resources.Resources.option_info
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CountryTooltip
        '
        Me.CountryTooltip.IsBalloon = True
        '
        'PublicFlag
        '
        Me.PublicFlag.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicFlag.BackColor = System.Drawing.Color.Transparent
        Me.PublicFlag.Location = New System.Drawing.Point(310, 113)
        Me.PublicFlag.Name = "PublicFlag"
        Me.PublicFlag.Size = New System.Drawing.Size(115, 24)
        Me.PublicFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PublicFlag.TabIndex = 7
        Me.PublicFlag.TabStop = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 346)
        Me.Controls.Add(Me.PublicFlag)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AdaptersListView)
        Me.Controls.Add(Me.PublicIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(683, 385)
        Me.Name = "MainWindow"
        Me.Text = "My IP Address"
        Me.CopyContextMenu.ResumeLayout(False)
        Me.CopyLocalContextMenu.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PublicFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CopyContextMenu As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublicIP As TextBox
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublicIPfetcher As System.ComponentModel.BackgroundWorker
    Friend WithEvents LocalIPfetcher As System.ComponentModel.BackgroundWorker
    Friend WithEvents AdaptersListView As ListView
    Friend WithEvents AdapterName As ColumnHeader
    Friend WithEvents IPv4Address As ColumnHeader
    Friend WithEvents IPv6Address As ColumnHeader
    Friend WithEvents PublicFlag As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewOnGitHubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllAddressesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PublicAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LocalAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublicAddressProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IpifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IpinfoioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IpapiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CountryTooltip As ToolTip
    Friend WithEvents CopyLocalContextMenu As ContextMenuStrip
    Friend WithEvents CopyNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyIPv4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyIPv6ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
End Class
