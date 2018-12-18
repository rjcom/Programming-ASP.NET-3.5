using System;
using System.IO;		//  necessary for Stream
using System.Web.UI;
using System.Text;

public partial class FileUploadDemo : Page
{
    protected void btnSave_Click(object sender, EventArgs e)
    {
        StringBuilder str = new StringBuilder();
        if (FileUpload1.HasFile)
        {
            try
            {
                str.AppendFormat("Uploaded file: {0}", FileUpload1.FileName);

                //  Save the file
                FileUpload1.SaveAs("d:\\desktop\\screenshots\\" + FileUpload1.FileName);

                //  show info about the file
                str.AppendFormat("<br/>Saved As: {0}", FileUpload1.PostedFile.FileName);
                str.AppendFormat("<br/>File Type: {0}", FileUpload1.PostedFile.ContentType);
                str.AppendFormat("<br/>File Length (bytes): {0}", FileUpload1.PostedFile.ContentLength);
                str.AppendFormat("<br/>PostedFile File Name: {0}", FileUpload1.PostedFile.FileName);
            }
            catch (Exception ex)
            {
                str.Append("<br/><b>Error</b><br/>");
                str.AppendFormat("Unable to save d:\\documents\\{0}<br />{1}",
                    FileUpload1.FileName, ex.Message);
            }
        }
        else
        {
            lblMessage.Text = "No file uploaded.";
        }
        lblMessage.Text = str.ToString();
        lblDisplay.Text = "";
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        StringBuilder str = new StringBuilder();
        str.AppendFormat("<u>File:  {0}</u><br/>", FileUpload1.FileName);
        if (FileUpload1.HasFile)
        {
            try
            {
                Stream stream = FileUpload1.FileContent;
                StreamReader reader = new StreamReader(stream);
                string strLine = "";
                do
                {
                    strLine = reader.ReadLine();
                    str.Append(strLine);
                } while (strLine != null);
            }
            catch (Exception ex)
            {
                str.AppendFormat("<br/><b>Error</b><br/>");
                str.AppendFormat("Unable to display {0}<br/>{1}", 
                    FileUpload1.FileName, ex.Message);
            }
        }
        else
        {
            lblDisplay.Text = "No file uploaded.";
        }
        lblDisplay.Text = str.ToString();
        lblMessage.Text = "";
    }
}