using System;
using System.Web.UI;
using System.Web.Profile;

public partial class Welcome : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Profile.UserName != null && Profile.IsAnonymous == false)
        {
            pnlInfo.Visible = true;
            lblFullName.Text = Profile.firstName + " " + Profile.lastName;
            lblPhone.Text = Profile.phoneNumber;
            lblBirthDate.Text = Profile.birthDate.ToShortDateString();

            lbBooks.Items.Clear();

        }
        else
        {
            pnlInfo.Visible = false;
        }

        if (Profile.favoriteBooks != null)
        {
            foreach (string bookName in Profile.favoriteBooks)
            {
                lbBooks.Items.Add(bookName);
            }
        }
    }

    public override string StyleSheetTheme
    {
        get
        {
            if ((!Profile.IsAnonymous) && Profile.Theme != null)
            {
                return Profile.Theme;
            }
            else
            {
                return "DarkBlue";
            }
        }
        set
        {
            Profile.Theme = value;
        }
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (!Profile.IsAnonymous)
        {
            Page.Theme = Profile.Theme;
        }
    }
}
