using System;
using System.IO;

public class GlobalMembers
{
    public static int successRate = 50;

    public GlobalMembers()
    {
    }

    protected void Application_Start(Object sender, EventArgs e)
    {
        WriteFile("Application Starting");
    }

    protected void Application_End(Object sender, EventArgs e)
    {
        WriteFile("Application Ending");
    }

    public void WriteFile(string strText)
    {
        using (StreamWriter writer =
           new StreamWriter(@"C:\Users\Public\test.txt", true))
        {
            string str;
            str = DateTime.Now.ToString() + " " + strText;
            writer.WriteLine(str);
            writer.Close();
        }
    }

    public static void StaticWriteFile(string strText)
    {
        using (StreamWriter writer =
           new StreamWriter(@"C:\Users\Public\test.txt", true))
        {
            string str;
            str = DateTime.Now.ToString() + " " + strText;
            writer.WriteLine(str);
            writer.Close();
        }
    }
}

