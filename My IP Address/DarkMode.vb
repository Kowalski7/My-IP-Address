Module DarkMode
    Private ReadOnly DarkBackgroundColor As Color = Color.FromArgb(45, 45, 48)
    Private ReadOnly DarkForegroundColor As Color = Color.White
    Private ReadOnly DarkPrimaryColor As Color = Color.DimGray
    Private ReadOnly DarkSecondaryColor As Color = Color.FromArgb(64, 64, 64)

    Public Class DarkModeToolStripRenderer
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
            MyBase.New(New DarkModeColorTable())
        End Sub

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            If e.Item.Selected Then
                e.Graphics.FillRectangle(Brushes.Gray, e.Item.ContentRectangle)
            Else
                e.Graphics.FillRectangle(New SolidBrush(DarkPrimaryColor), e.Item.ContentRectangle)
            End If
        End Sub

        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            If e.Item.Enabled Then
                e.TextColor = DarkForegroundColor
            Else
                e.TextColor = Color.Silver
            End If

            TextRenderer.DrawText(e.Graphics, e.Text, e.TextFont, e.TextRectangle, e.TextColor, e.TextFormat)
        End Sub
    End Class

    Public Class DarkModeColorTable
        Inherits ProfessionalColorTable

        Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
            Get
                Return DarkPrimaryColor
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
            Get
                Return DarkPrimaryColor
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
            Get
                Return DarkPrimaryColor
            End Get
        End Property

        Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
            Get
                Return DarkPrimaryColor
            End Get
        End Property
    End Class


    Public Sub ApplyDarkMode(ByVal form As Form)
        form.BackColor = DarkBackgroundColor
        form.ForeColor = DarkForegroundColor

        For Each control As Control In form.Controls
            ApplyDarkModeToControl(control)

            ' Check for ContextMenuStrip on the control itself
            If TypeOf control.ContextMenuStrip Is ContextMenuStrip Then
                ApplyDarkModeToControl(control.ContextMenuStrip)
            End If
        Next
    End Sub

    Private Sub ApplyDarkModeToControl(ByVal control As Control)
        If TypeOf control Is TextBox Then
            control.BackColor = DarkBackgroundColor
            control.ForeColor = DarkForegroundColor
        ElseIf TypeOf control Is ListView Then
            control.BackColor = DarkSecondaryColor
            control.ForeColor = DarkForegroundColor
        ElseIf TypeOf control Is MenuStrip OrElse TypeOf control Is ContextMenuStrip Then
            Dim toolStrip As ToolStrip = CType(control, ToolStrip)
            toolStrip.BackColor = DarkPrimaryColor
            'toolStrip.ForeColor = DarkForegroundColor
            toolStrip.Renderer = New DarkModeToolStripRenderer()
            For Each item As ToolStripItem In toolStrip.Items
                ApplyDarkModeToToolStripItem(item)
            Next
        End If
    End Sub

    Private Sub ApplyDarkModeToToolStripItem(ByVal item As ToolStripItem)
        item.BackColor = DarkPrimaryColor
        item.ForeColor = DarkForegroundColor
        If TypeOf item Is ToolStripMenuItem Then
            Dim menuItem As ToolStripMenuItem = CType(item, ToolStripMenuItem)
            For Each dropDownItem As ToolStripItem In menuItem.DropDownItems
                ApplyDarkModeToToolStripItem(dropDownItem)
            Next
        End If
    End Sub

    ' APPLYING LIGHT MODE

    Public Sub ApplyLightMode(ByVal form As Form)
        form.BackColor = Color.White
        form.ForeColor = SystemColors.ControlText

        For Each control As Control In form.Controls
            ApplyLightModeToControl(control)

            ' Check for ContextMenuStrip on the control itself
            If TypeOf control.ContextMenuStrip Is ContextMenuStrip Then
                ApplyLightModeToControl(control.ContextMenuStrip)
            End If
        Next
    End Sub

    Private Sub ApplyLightModeToControl(ByVal control As Control)
        If TypeOf control Is TextBox OrElse TypeOf control Is ListView Then
            control.BackColor = SystemColors.Window
            control.ForeColor = SystemColors.WindowText
        ElseIf TypeOf control Is MenuStrip OrElse TypeOf control Is ContextMenuStrip Then
            Dim toolStrip As ToolStrip = CType(control, ToolStrip)
            toolStrip.BackColor = Color.WhiteSmoke
            'toolStrip.ForeColor = LightModeColors.ToolStripForeColor
            toolStrip.Renderer = New ToolStripProfessionalRenderer()
            For Each item As ToolStripItem In toolStrip.Items
                ApplyLightModeToToolStripItem(item)
            Next
        End If
    End Sub

    Private Sub ApplyLightModeToToolStripItem(ByVal item As ToolStripItem)
        item.BackColor = SystemColors.Control
        item.ForeColor = SystemColors.ControlText
        If TypeOf item Is ToolStripMenuItem Then
            Dim menuItem As ToolStripMenuItem = CType(item, ToolStripMenuItem)
            For Each dropDownItem As ToolStripItem In menuItem.DropDownItems
                ApplyLightModeToToolStripItem(dropDownItem)
            Next
        End If
    End Sub
End Module
