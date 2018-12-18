using System;
using System.Text;
using System.Web.UI;

public partial class String_Concat : Page
{
   void Page_Load(Object Source, EventArgs E)
   {
      int intLimit = 10000;
      DateTime startTime;
      DateTime endTime;
      TimeSpan elapsedTime;
      string strSub;
      string strWhole = "";

      //  Do string concat first
      startTime = DateTime.Now;
      for (int i=0; i < intLimit; i++)
      {
         strSub = i.ToString();
         strWhole = strWhole + " " + strSub;
      }
      endTime = DateTime.Now;

      elapsedTime = endTime - startTime;
      lblConcat.Text = elapsedTime.ToString();
      //lblConcatString.Text = strWhole;

      //  Do stringBuilder next
      startTime = DateTime.Now;
      StringBuilder sb = new StringBuilder();
      for (int i=0; i < intLimit; i++)
      {
         strSub = i.ToString();
         sb.Append(" ");
         sb.Append(strSub);
      }
      endTime = DateTime.Now;
      elapsedTime = endTime - startTime;
      lblBuild.Text = elapsedTime.ToString();
      //lblBuildString.Text = sb.ToString();
   }
}
