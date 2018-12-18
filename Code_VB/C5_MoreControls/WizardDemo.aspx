<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WizardDemo.aspx.vb" Inherits="WizardDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Wizard Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="1" BackColor="#E6E2D8" BorderColor="#999999"
         BorderStyle="Solid" BorderWidth="1px" DisplayCancelButton="True" Font-Names="Verdana"
         Font-Size="0.8em" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnCancelButtonClick="Wizard1_CancelButtonClick"
         OnFinishButtonClick="Button_Click" OnNextButtonClick="Button_Click" OnPreviousButtonClick="Button_Click"
         OnSideBarButtonClick="Button_Click">
         <StepStyle BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px" />
         <WizardSteps>
            <asp:WizardStep ID="stpWakeUp" runat="server" Title="Step 1" StepType="Start">
               <h2>
                  Wake Up</h2>
               Rise and shine sleepy head.
            </asp:WizardStep>
            <asp:WizardStep ID="stpShower" runat="server" Title="Step 2">
               <h2>
                  Shower</h2>
               Make it cold!
            </asp:WizardStep>
            <asp:WizardStep ID="stpTakeMeds" runat="server" Title="Step 3" AllowReturn="false">
               <h2>
                  Take Medicine</h2>
               Only do this once.
            </asp:WizardStep>
            <asp:WizardStep ID="stpBrushTeeth" runat="server" Title="Step 4">
               <h2>
                  Brush Teeth</h2>
               Don&#8217;t forget to floss.
            </asp:WizardStep>
            <asp:WizardStep ID="stpGetDressed" runat="server" Title="Step 5">
               <h2>
                  Get Dressed</h2>
               Got to look good.
            </asp:WizardStep>
            <asp:WizardStep ID="stpEatBreakfast" runat="server" Title="Step 6">
               <h2>
                  Eat Breakfast</h2>
               The most important meal of the day.
            </asp:WizardStep>
            <asp:WizardStep ID="stpFinish" runat="server" Title="Step 7" StepType="Finish">
               <h2>
                  Out The Door</h2>
               Meet the world!
            </asp:WizardStep>
            <asp:WizardStep ID="stpComplete" runat="server" Title="Complete" StepType="Complete">
               <h2>
                  Complete!</h2>
               Your morning routine is now complete.
            </asp:WizardStep>
         </WizardSteps>
         <SideBarButtonStyle ForeColor="White" />
         <NavigationButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid"
            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
         <SideBarStyle BackColor="#1C5E55" Font-Size="0.9em" VerticalAlign="Top" />
         <HeaderStyle BackColor="#666666" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="2px"
            Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" Font-Bold="True" />
      </asp:Wizard>
      <br />
      Select a step:&nbsp;
      <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
         <asp:ListItem>1</asp:ListItem>
         <asp:ListItem>2</asp:ListItem>
         <asp:ListItem>3</asp:ListItem>
         <asp:ListItem>4</asp:ListItem>
         <asp:ListItem>5</asp:ListItem>
         <asp:ListItem>6</asp:ListItem>
         <asp:ListItem>7</asp:ListItem>
      </asp:DropDownList>
      <p>
         Active Step:&nbsp;
         <asp:Label ID="lblActiveStep" runat="server" />
      </p>
      <p>
         ActiveStepIndex:&nbsp;
         <asp:Label ID="lblActiveStepIndex" runat="server" />
      </p>
      <p>
         StepType:&nbsp;
         <asp:Label ID="lblStepType" runat="server" />
      </p>
      <p>
         Button Info:&nbsp;
         <asp:Label ID="lblButtonInfo" runat="server" />
      </p>
      <p>
         <u>History</u>
      </p>
      <p>
         <asp:Label ID="lblHistory" runat="server" />
      </p>
   </div>
   </form>
</body>
</html>
