using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class ListBoxDemo : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //  Build 2 dimensional array for the lists       
            //  First dimension contains bookname       
            //  2nd dimension contains ISBN number       
            string[,] books = { 
            {"Learning ASP.NET 2.0 with AJAX", "9780596513976"},
            {"Beginning ASP.NET 2.0 with C#", "9780470042583"},          
            {"Programming C#","9780596527433"},            
            {"Programming .NET 3.5","978059652756X"},            
            {"Programming .NET Windows Applications","0596003218"},            
            {"Programming ASP.NET 3e","0596001711"},            
            {"WebClasses From Scratch","0789721260"},            
            {"Teach Yourself C++ in 21 Days","067232072X"},            
            {"Teach Yourself C++ in 10 Minutes","067231603X"},            
            {"XML & Java From Scratch","0789724766"},            
            {"Complete Idiot’s Guide to a Career in Computer Programming", "0789719959"},            
            {"XML Web Documents From Scratch","0789723166"},            
            {"Clouds To Code","1861000952"},            
            {"C++ Unleashed","0672312395"}         
        };

            //  Now populate the list.       
            for (int i = 0; i < books.GetLength(0); i++)
            {
                //  Add both Text and Value          
                lbxSingle.Items.Add(new ListItem(books[i, 0], books[i, 1]));
                lbxMulti.Items.Add(new ListItem(books[i, 0], books[i, 1]));
            }
        }
    }
    protected void lbxSingle_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  Check to verify that something has been selected.    
        if (lbxSingle.SelectedIndex > -1)
        {
            lblSingle.Text = lbxSingle.SelectedItem.Text + " ---> ISBN: " +
               lbxSingle.SelectedItem.Value;
        }
    }

    protected void lbxMulti_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbxMulti.SelectedItem == null)
        {
            lblMulti.Text = "No books selected.";
        }
        else
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListItem li in lbxMulti.Items)
            {
                if (li.Selected)
                {
                    sb.AppendFormat("<br/>{0} ---> ISBN: {1}", li.Text, li.Value);
                }
            }
            lblMulti.Text = sb.ToString();
        }

        //  Alternative technique 
        //  foreach (int i in lbxMulti.GetSelectedIndices()) 
        //  { 
        //     ListItem li = lbxMulti.Items[i]; 
        //     sb.AppendFormat("<br/>{0} ---> ISBN: {1}", li.Text, li.Value);
        //  }      
    }
}
