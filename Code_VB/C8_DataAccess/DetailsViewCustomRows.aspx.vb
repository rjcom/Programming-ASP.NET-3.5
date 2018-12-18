Imports System.Security.Cryptography
Partial Class DetailsViewCustomRows
    Inherits System.Web.UI.Page

    Protected Sub dvwCustomers_ModeChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim [readOnly] As Boolean = (dvwCustomers.CurrentMode = DetailsViewMode.[ReadOnly])

        dvwCustomers.Fields(1).Visible = [readOnly]
        'FullName
        dvwCustomers.Fields(2).Visible = Not [readOnly]
        'NameStyle
        dvwCustomers.Fields(3).Visible = Not [readOnly]
        'Title
        dvwCustomers.Fields(4).Visible = Not [readOnly]
        'FirstName
        dvwCustomers.Fields(5).Visible = Not [readOnly]
        'MiddleName
        dvwCustomers.Fields(6).Visible = Not [readOnly]
        'LastName
        dvwCustomers.Fields(7).Visible = Not [readOnly]
        'Suffix
        dvwCustomers.Fields(12).Visible = [readOnly]
        'ModifiedDate
        dvwCustomers.Fields(13).Visible = [readOnly]
        'PasswordHash
        dvwCustomers.Fields(14).Visible = [readOnly]
        'PasswordSalt
        'Password field can only be viewed when adding a new record, so a little different logic
        If dvwCustomers.CurrentMode = DetailsViewMode.Insert Then
            dvwCustomers.Fields(15).Visible = True
        Else
            dvwCustomers.Fields(15).Visible = False
        End If

    End Sub

    ' before item is inserted, password hash and salt must be generated
    Protected Sub dvwCustomers_ItemInserting(ByVal sender As Object, ByVal e As DetailsViewInsertEventArgs)
        Dim password As String = DirectCast(dvwCustomers.FindControl("txtPasswordInsert"), TextBox).Text
        Dim salt As String = GetSalt()
        Dim hash As String = GetHashFromPlainTextAndSalt(password, salt)
        e.Values("PasswordHash") = hash
        e.Values("PasswordSalt") = salt
    End Sub

    Private Function GetHashFromPlainTextAndSalt(ByVal password As String, ByVal salt As String) As String
        Dim hasher As New SHA1CryptoServiceProvider()
        Dim clearBytes As Byte() = Encoding.UTF8.GetBytes(salt + password)
        Dim hashedBytes As Byte() = hasher.ComputeHash(clearBytes)
        Return Convert.ToBase64String(hashedBytes)
    End Function

    Private Function GetSalt() As String
        Dim buffer As Byte() = New Byte(4) {}
        Dim rng As New RNGCryptoServiceProvider()
        rng.GetBytes(buffer)
        Return Convert.ToBase64String(buffer)
    End Function


End Class
