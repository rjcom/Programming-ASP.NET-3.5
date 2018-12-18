using System;

public partial class CheckBoxDemo : System.Web.UI.Page
{
    protected void lblTime_Init(object sender, EventArgs e)
    {
        lblTime.Font.Name = "Verdana";
        lblTime.Font.Size = 20;
        lblTime.Font.Bold = true;
        lblTime.Font.Italic = true;
        lblTime.Text = DateTime.Now.ToString();
    }
    protected void chkUnderline_CheckedChanged(object sender, EventArgs e)
    {
        lblTime.Font.Underline = chkUnderline.Checked;
    }

    protected void chkOverline_CheckedChanged(object sender, EventArgs e)
    {
        lblTime.Font.Overline = chkOverline.Checked;
    }


    protected void chkStrikeout_CheckedChanged(object sender, EventArgs e)
    {
        lblTime.Font.Strikeout = chkStrikeout.Checked;
    }
}
