Imports System.Security.Cryptography

Partial Class FormViewCustomRows
    Inherits System.Web.UI.Page

    ' before item is inserted, password hash and salt must be generated
    Protected Sub fvwCustomers_ItemInserting(ByVal sender As Object, ByVal e As FormViewInsertEventArgs)
        Dim password As String = DirectCast(fvwCustomers.FindControl("PasswordTextBox"), TextBox).Text
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
