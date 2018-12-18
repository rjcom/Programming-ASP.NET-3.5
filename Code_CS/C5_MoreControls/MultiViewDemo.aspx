<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultiViewDemo.aspx.cs" Inherits="MultiViewDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>MultiView & View Controls</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         MultiView & View Controls</h1>
      <br />
      <asp:RadioButtonList AutoPostBack="True" ID="rblView" OnSelectedIndexChanged="rblView_SelectedIndexChanged"
         RepeatDirection="Horizontal" runat="server">
         <asp:ListItem Value="-1">Nothing</asp:ListItem>
         <asp:ListItem Value="0" Selected="True">First</asp:ListItem>
         <asp:ListItem Value="1">Second</asp:ListItem>
         <asp:ListItem Value="2">Third</asp:ListItem>
         <asp:ListItem Value="3">Last</asp:ListItem>
      </asp:RadioButtonList>
      <br />
      Current Index:
      <asp:Label ID="lblCurrentIndex" runat="server"></asp:Label>
      <br />
      <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">
         <asp:View ID="vwFirst" runat="server" OnActivate="ActivateView" OnDeactivate="DeactivateView">
            <h2>
               First View
            </h2>
            <asp:TextBox ID="txtFirstView" runat="server"></asp:TextBox>
            <asp:Button CommandName="NextView" ID="btnNext1" runat="server" Text="Go To Next" />
            <asp:Button CommandArgument="vwLast" CommandName="SwitchViewByID" ID="btnLast" runat="server"
               Text="Go to Last" />
         </asp:View>
         <asp:View ID="vwSecond" runat="server" OnActivate="ActivateView" OnDeactivate="DeactivateView">
            <h2>
               Second View
            </h2>
            <asp:TextBox ID="txtSecondView" runat="server"></asp:TextBox>
            <asp:Button CommandName="NextView" ID="btnNext2" runat="server" Text="Go To Next" />
            <asp:Button CommandName="PrevView" ID="btnPrevious2" runat="server" Text="Go to Previous" />
         </asp:View>
         <asp:View ID="vwThird" runat="server" OnActivate="ActivateView" OnDeactivate="DeactivateView">
            <h2>
               Third View</h2>
            <br />
            <asp:Button CommandName="NextView" ID="btnNext3" runat="server" Text="Go To Next" />
            <asp:Button CommandName="PrevView" ID="btnPrevious3" runat="server" Text="Go to Previous" />
         </asp:View>
         <asp:View ID="vwLast" runat="server" OnActivate="ActivateView" OnDeactivate="DeactivateView">
            <h2>
               Last View
            </h2>
            <asp:Button CommandName="PrevView" ID="btnPrevious4" runat="server" Text="Go to Previous" />
            <asp:Button CommandArgument="0" CommandName="SwitchViewByIndex" ID="btnFirst" runat="server"
               Text="Go to First" />
         </asp:View>
      </asp:MultiView>
      <br />
      <br />
      First TextBox:
      <asp:Label ID="lblFirstTextBox" runat="server" />
      <br />
      Second TextBox:
      <asp:Label ID="lblSecondTextBox" runat="server" />
      <br />
      <br />
      <strong><span style="text-decoration: underline">View Activation History:</span></strong>
      <br />
      <asp:Label ID="lblViewActivation" runat="server" />
   </div>
   </form>
</body>
</html>
