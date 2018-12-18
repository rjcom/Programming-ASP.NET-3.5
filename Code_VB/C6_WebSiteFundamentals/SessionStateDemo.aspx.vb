
Partial Class SessionStateDemo
    Inherits System.Web.UI.Page

    Protected Sub rbl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbl.SelectedIndexChanged
        If rbl.SelectedIndex <> -1 Then
            Dim Books As String() = New String(2) {}
            Session("cattext") = rbl.SelectedItem.Text
            Session("catcode") = rbl.SelectedItem.Value
            Select Case rbl.SelectedItem.Value
                Case "n"
                    Books(0) = "Programming C#"
                    Books(1) = "Programming ASP.NET"
                    Books(2) = "C# Essentials"
                    Exit Select
                Case "d"
                    Books(0) = "Oracle & Open Source"
                    Books(1) = "SQL in a Nutshell"
                    Books(2) = "Transact-SQL Programming"
                    Exit Select
                Case "h"
                    Books(0) = "PC Hardware in a Nutshell"
                    Books(1) = "Dictionary of PC Hardware and Data Communications Terms"
                    Books(2) = "Linux Device Drivers"
                    Exit Select
            End Select
            Session("books") = Books
        End If
    End Sub

    Protected Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn.Click
        If True Then
            If rbl.SelectedIndex = -1 Then
                lblMessage.Text = "You must select a book category."
            Else
                Dim sb As New StringBuilder()
                sb.Append("You have selected the category ")
                sb.Append(DirectCast(Session("cattext"), String))
                sb.Append(" with code """)
                sb.Append(DirectCast(Session("catcode"), String))
                sb.Append(""".")
                lblMessage.Text = sb.ToString()
                ddl.Visible = True
                Dim CatBooks As String() = DirectCast(Session("books"), String())

                ' Populate the DropDownList.
                Dim i As Integer
                ddl.Items.Clear()
                For i = 0 To CatBooks.GetLength(0) - 1
                    ddl.Items.Add(New ListItem(CatBooks(i)))
                Next
            End If
        End If
    End Sub
End Class
