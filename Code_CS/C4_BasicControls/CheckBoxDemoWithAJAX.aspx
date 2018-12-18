<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxDemoWithAJAX.aspx.cs"
   Inherits="CheckBoxDemoWithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>CheckBox Demo With AJAX</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Add new AJAX web form CheckBoxDemoWithAJAX.aspx to web site
      Going to demo mutuallyexclusivecheckbox and togglebutton extenders
      Copy across the CheckBoxes and Label from CheckBoxDemo.aspx to below scriptmanager.
      Copy across the event handlers from CheckBoxDemo.aspx.cs to CheckBoxDemoWithAJAX.aspx.cs
      Run to make sure all is working
      
      Add ToggleButton_Checked.gif and ToggleButton_Unchecked.gif to the website. In toolkit sample website.
      Add ToggleButtonExtender from toolkit. Set targetControlId to chkStrikeOut.
      Set two ImageUrl values and ImageHeight,ImageWidth which are also mandatory.
      Optionally set alttext properties for checked and unchecked images.
      Run page. See how the images now take place of the standard checkbox.
      
      Now to make chkOverline and chkUnderline boxes mutually exclusive.
      Add MutuallyExclusiveCheckBoxExtender to page under togglebuttonextender. Set targetControlId to chkUnderline
      Add 2nd MutuallyExclusiveCheckBoxExtender to page under togglebuttonextender. Set targetControlId to chkOverline
      Make two checkboxes mutually exclusive by giving extenders the same Key value - "decoration" in this case.
      Run page. Note how you can't add overlines and underlines to label if you try and that the label updates correctly when one box is ticked and the other unticks automatically.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:CheckBox ID="chkUnderline" runat="server" Text="Underline?" OnCheckedChanged="chkUnderline_CheckedChanged"
         AutoPostBack="true" />
      <asp:CheckBox ID="chkOverline" runat="server" Text="Overline?" OnCheckedChanged="chkOverline_CheckedChanged"
         AutoPostBack="true" />
      <asp:CheckBox ID="chkStrikeout" runat="server" Text="Strikeout?" OnCheckedChanged="chkStrikeout_CheckedChanged"
         AutoPostBack="true" />
      <cc1:ToggleButtonExtender ID="ToggleButtonExtender1" runat="server" TargetControlID="chkStrikeout"
         CheckedImageUrl="ToggleButton_Checked.gif" CheckedImageAlternateText="Disable Strikeout"
         UncheckedImageUrl="togglebutton_unchecked.gif" UncheckedImageAlternateText="Enable Strikeout"
         ImageWidth="19" ImageHeight="19" >
      </cc1:ToggleButtonExtender>   
      <cc1:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender1" runat="server"
         targetControlId="chkUnderline" Key="Decoration">
      </cc1:MutuallyExclusiveCheckBoxExtender>
      <cc1:MutuallyExclusiveCheckBoxExtender ID="MutuallyExclusiveCheckBoxExtender2" runat="server"
         targetControlId="chkOverline" Key="Decoration">
      </cc1:MutuallyExclusiveCheckBoxExtender>
      <br />
      <br />
      <asp:Label ID="lblTime" runat="server" OnInit="lblTime_Init" />
   </div>
   </form>
</body>
</html>
