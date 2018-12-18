using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

public partial class ProfileInfo : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Profile.IsAnonymous == true)
            {
                pnlNonAnonymousInfo.Visible = false;
            }
            else
            {
                txtLastName.Text = Profile.lastName;
                txtFirstName.Text = Profile.firstName;
                txtPhone.Text = Profile.phoneNumber;
                txtBirthDate.Text = Profile.birthDate.ToShortDateString();
            }

            if (Profile.favoriteBooks != null)
            {
                foreach (string bookName in Profile.favoriteBooks)
                {
                    cblFavoriteBooks.Items.FindByText(bookName).Selected = true;
                }
            }
        }
    }



    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Profile.IsAnonymous == false)
        {
            Profile.lastName = txtLastName.Text;
            Profile.firstName = txtFirstName.Text;
            Profile.phoneNumber = txtPhone.Text;
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
            Profile.birthDate = birthDate;
        }

        Profile.favoriteBooks = new StringCollection();
        foreach (ListItem li in cblFavoriteBooks.Items)
        {
            if (li.Selected)
            {
                Profile.favoriteBooks.Add(li.Value.ToString());
            }
        }

        Response.Redirect("Welcome.aspx");
    }

    protected void Set_Theme(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        if (btn.Text == "Psychedelic")
        {
            Profile.Theme = "Psychedelic";
        }
        else
        {
            Profile.Theme = "DarkBlue";
        }
    }
}
