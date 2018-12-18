using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WizardDemo : Page
{
   protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
   {
      lblActiveStep.Text = Wizard1.ActiveStep.Title;
      lblActiveStepIndex.Text = Wizard1.ActiveStepIndex.ToString();
      lblStepType.Text = Wizard1.ActiveStep.StepType.ToString();

      //  get the history
      ICollection steps = Wizard1.GetHistory();
      string str = "";
      foreach (WizardStep step in steps)
      {
         str += step.Title + "<br/>";
      }
      lblHistory.Text = str;
   }
   protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
   {
      lblActiveStep.Text = "";
      lblActiveStepIndex.Text = "";
      lblStepType.Text = "";
      lblButtonInfo.Text = "Canceled";
      Wizard1.Visible = false;
   }
   protected void Button_Click(object sender, WizardNavigationEventArgs e)
   {
      string str = "Current Index: " +
      e.CurrentStepIndex.ToString() +
      ".   Next Step: " + e.NextStepIndex.ToString();
      lblButtonInfo.Text = str;
   }
   protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
   {
      int index = DropDownList1.SelectedIndex;
      WizardStepBase step = Wizard1.WizardSteps[index];
      Wizard1.MoveTo(step);
   }
}
