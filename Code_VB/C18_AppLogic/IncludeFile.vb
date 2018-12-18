<script runat="server">

Private Sub WriteFile(ByVal strText As String)

    Using writer As New System.IO.StreamWriter(Server.MapPath("test.txt"), True)
        Dim str As String
        str = (DateTime.Now.ToString() & " ") + strText
        writer.WriteLine(str)
        writer.Close()
    End Using

End Sub

</script>