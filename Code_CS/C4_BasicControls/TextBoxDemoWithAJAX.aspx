<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextBoxDemoWithAJAX.aspx.cs"
   Inherits="TextBoxesWithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>TextBoxes With Ajax</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>
   <style type="text/css">
      .watermark 
      {
         color : Gray;
         background-color : #dddddd;
         font-size: smaller;
         font-style:italic;
      }
   </style>
</head>
<body>
   <!-- 
      Create AJAX WebForm called textboxeswithajax.aspx
      Copy textbox code into <div> under scriptmanager (brief reminder about scriptmanager from chapter 3
      Copy event code from original here as well.
      Problems with original demo. You have to delete "Enter some text" before you can write what you want
      Start with TextboxWatermarkExtender 
      Either into design view, use common tasks dialog to add extender directly to txtInput and choose TextBoxWatermarkExtender or
      Drag onto source view and set TargetControlId
      Either way, in source view, add watermarktext and watermarkcssclass and delete text from txtInput
      Add watermark css class into page.
      Run page and see how once you click into the textbox the watermark disappears and only reappears when nothing in the box.
      
      Now let's suppose you want someone to add a date to your textbox. You could just use a calendar control (see next chapter) true, but this is neater.
      Method 1. Use a CalendarExtender. Drag a calendarextender onto the page under the textboxwatermarkextender.
      Set the targetControlId and change the watermark text to enter a date.
      Run page and see that when you click into textbox, a calendar appears to make it easier for you to select a date.
      Text reflects chosen date in default format - MM/dd/yyyy. To change the format, use the Format property of the calendarextender. For example, format = "dd/MM/yy"
      
      This helps people write the date in the format you want, but doesn't preclude them writing their own version of the date directly into the textbox
      We could use watermark to give a better hint, MaskedEditExtender to enforce the format and MaskedEditValidator to check the validation. (See more on validation on Chapter 12)
      Drag MaskedEditExtender onto page under calendarextender. set targetcontrolid to textInput, masktype to date (can check dates, times, numbers), mask to 99/99/9999 (sidebar about mask characters and delimiters? Might change before going to press) and errortooltipenabled to true so the validator's errors are visible
      Drag MaskedEditValidator under MaskedEditValidator. set targetcontrolid to txtInput, controlextender to maskededitextender1, and display to dynamic so messages are inserted as appropriate.
      Then add messages with emptyvaluemessage, invalidvaluemessage and tooltipmessage properties.
      Run page. See how masked edit enforces itself when writing directly into textbox and fits nicely with calendarextender.
      Note: take care of the date format used here. Calendarextender and maskededitextender might use different ones depending on how you set the culturename property for the MEE and the format propoerty for the CE.
      When you let the value into txtEcho, txtEcho by default will show the date in the default format for the default culture on the server. In my case, that's en-gb. Moral is that you may need to experiment before the extenders and txtEco all show the same date in the same format. See I18N chapter for more on cultures.
      
      Not showing the AutoCompleteExtender here which calls a web service to offer "intellisense" and suggest how to fill in a textbox based on what's already in it. Forwaard ref to 
      Not showing the NumericUpDown box here which at it's simplest puts a number in a textbox with two buttons next to it. Pushing one increments the number by one and the other decrements it by one. More interestingly this can be used with a webservice to push through a set of values defined in RefValues and incremented \ decremented by the web service.
      Could also show the FilteredTextBox which allows you to specify a list of valid (or invalid) characters for the textbox. Invalid characters simply can't be typed into the textbox
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:TextBox ID="txtInput" runat="server" AutoPostBack="true" OnTextChanged="txtInput_TextChanged"></asp:TextBox>
      <asp:TextBox ID="txtEcho" runat="server" BackColor="lightgray" ReadOnly="true"></asp:TextBox>
      <cc1:TextBoxWatermarkExtender ID="TextBoxWatermarkExtender1" runat="server" TargetControlID="txtInput" WatermarkText="Enter a date" WatermarkCssClass="watermark">
      </cc1:TextBoxWatermarkExtender>
      <cc1:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtInput" Format="MM/dd/yyyy" />
      <cc1:MaskedEditExtender ID="MaskedEditExtender1" runat="server"
            TargetControlID="txtInput" CultureName="en-us"
            Mask="99/99/9999" MaskType="Date" ErrorTooltipEnabled="True" />
      <cc1:MaskedEditValidator ID="MaskedEditValidator1" runat="server" ControlExtender="MaskedEditExtender1" ControlToValidate="txtInput"
            EmptyValueMessage="Date is required" InvalidValueMessage="Date is invalid" Display="Dynamic" TooltipMessage="Enter a date" /> 
   </div>
   </form>
</body>
</html>
