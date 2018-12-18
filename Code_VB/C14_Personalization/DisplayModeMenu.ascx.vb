
Partial Class DisplayModeMenu
    Inherits System.Web.UI.UserControl

    ' will reference the current WebPartManager control. 
    Private webPartManager As WebPartManager


    Protected Sub Page_Init1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        AddHandler Page.InitComplete, AddressOf InitComplete

    End Sub

    ' when the page is fully initialized 
    Public Sub InitComplete(ByVal sender As Object, ByVal e As EventArgs)

        webPartManager = webPartManager.GetCurrentWebPartManager(Page)
        Dim browseModeName As String = webPartManager.BrowseDisplayMode.Name

        For Each mode As WebPartDisplayMode In webPartManager.SupportedDisplayModes
            Dim modeName As String = mode.Name
            If mode.IsEnabled(webPartManager) Then
                Dim listItem As New ListItem(modeName, modeName)
                ddlDisplayMode.Items.Add(listItem)
            End If
        Next

    End Sub

    ' Change the page to the selected display mode. 
    Public Sub ddlDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim selectedMode As String = ddlDisplayMode.SelectedValue
        Dim mode As WebPartDisplayMode = webPartManager.SupportedDisplayModes(selectedMode)

        If mode IsNot Nothing Then
            webPartManager.DisplayMode = mode
        End If

    End Sub

    ' Set the selected item equal to the current display mode. 
    Protected Sub Page_PreRender1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender

        Dim items As ListItemCollection = ddlDisplayMode.Items
        Dim selectedIndex As Integer = items.IndexOf(items.FindByText(webPartManager.DisplayMode.Name))
        ddlDisplayMode.SelectedIndex = selectedIndex

    End Sub
End Class
