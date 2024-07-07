Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class SettingsManager
    Private jsonPath As String
    Private settingsObject As JObject
    Private settingsModified As Boolean = False

    Public Sub New(configPath As String)
        Me.jsonPath = configPath

        Try
            settingsObject = JObject.Parse(File.ReadAllText(configPath))
        Catch ex As Exception
            Console.WriteLine("[ERROR] Failed loading settings file! Reason: " + ex.Message)
            settingsObject = GenerateDefaultSettings()
        End Try
    End Sub

    Private Function GenerateDefaultSettings() As JObject
        Dim settings As New JObject(
            New JProperty("DarkMode", False),
            New JProperty("LastProvider", 0)
        )

        Return settings
    End Function

    Public Function GetSettingsValue(key As String) As JToken
        Return settingsObject(key)
    End Function

    Public Sub SetSettingsValue(key As String, value As Object)
        If value <> settingsObject(key) Then
            settingsModified = True
            settingsObject(key) = JToken.FromObject(value)
        End If
    End Sub

    Public Sub SaveConfig()
        If settingsModified Then
            File.WriteAllText(jsonPath, settingsObject.ToString())
        Else
            Console.WriteLine("[INFO] No changes to save.")
        End If
    End Sub
End Class
