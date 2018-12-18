<script runat="server">
    void WriteFile(string strText)
    {
        using (System.IO.StreamWriter writer =
            new System.IO.StreamWriter(@"C:\users\public\test.txt", true))
        {
            string str;
            str = DateTime.Now.ToString() + "  " + strText;
            writer.WriteLine(str);
            writer.Close();
        }
    }
</script>
