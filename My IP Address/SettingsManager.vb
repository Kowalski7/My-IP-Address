Imports MadMilkman.Ini

Public Class SettingsManager
    Private iniPath As String
    Private iniFile As IniFile
    Private settingsSection As IniSection

    Public Sub New(IniPath As String)
        Me.iniPath = IniPath
        iniFile = New IniFile()

        If IO.File.Exists(IniPath) Then
            iniFile.Load(IniPath)
            settingsSection = iniFile.Sections("Settings")
        Else
            settingsSection = iniFile.Sections.Add("Settings")
            settingsSection.Keys.Add("DarkMode", "0")
            settingsSection.Keys.Add("LastProvider", "0")
        End If
    End Sub

    Public Function GetSettingsValue(key As String) As String
        Return settingsSection.Keys(key).Value
    End Function

    Public Sub SetSettingsValue(key As String, value As String)
        settingsSection.Keys(key).Value = value
    End Sub

    Public Sub SaveConfig()
        iniFile.Save(iniPath)
    End Sub
End Class
