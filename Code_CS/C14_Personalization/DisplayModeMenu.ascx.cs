using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class DisplayModeMenu : UserControl
{

   // will reference the current WebPartManager control.    
   WebPartManager webPartManager;

   public void Page_Init(object sender, EventArgs e)
   {
      Page.InitComplete += new EventHandler(InitComplete);
   }

   // when the page is fully initialized    
   public void InitComplete(object sender, EventArgs e)
   {
      webPartManager = WebPartManager.GetCurrentWebPartManager(Page);
      String browseModeName = WebPartManager.BrowseDisplayMode.Name;
      foreach (WebPartDisplayMode mode in webPartManager.SupportedDisplayModes)
      {
         String modeName = mode.Name;
         if (mode.IsEnabled(webPartManager))
         {
            ListItem listItem = new ListItem(modeName, modeName);
            ddlDisplayMode.Items.Add(listItem);
         }
      }
   }

   // Change the page to the selected display mode.    
   public void ddlDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
   {
      String selectedMode = ddlDisplayMode.SelectedValue;
      WebPartDisplayMode mode = webPartManager.SupportedDisplayModes[selectedMode];
      if (mode != null)
      {
         webPartManager.DisplayMode = mode;
      }
   }

   // Set the selected item equal to the current display mode.   
   public void Page_PreRender(object sender, EventArgs e)
   {
      ListItemCollection items = ddlDisplayMode.Items;
      int selectedIndex = items.IndexOf(items.FindByText(webPartManager.DisplayMode.Name));
      ddlDisplayMode.SelectedIndex = selectedIndex;
   }
}

