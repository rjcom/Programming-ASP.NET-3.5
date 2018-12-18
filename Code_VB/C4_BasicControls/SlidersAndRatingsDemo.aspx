<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SlidersAndRatingsDemo.aspx.vb" Inherits="SlidersAndRatingsDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Slider and Ratings Demo</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

   <style type="text/css">
      .ratingStar
      {
         font-size: 0pt;
         width: 25px;
         height: 25px;
         margin: 0px;
         padding: 0px;
         cursor: pointer;
         display: block;
         background-repeat: no-repeat;
      }
      .filledRatingStar
      {
         background-color: Black;
      }
      .emptyRatingStar
      {
         background-color: Yellow;
      }
      .savedRatingStar
      {
         background-color: Green;
      }
   </style>
</head>
<body>
   <!--
      Add new AJAX Web Form to the website called SlidersAndRatingsDemo.aspx
      Add a ratings control to the form (with some explanatory text). ID = Rating1
      Need to define how the stars will be displayed in the ratings class
      Add styles for a generic star first, then selected, deselected and saved star for more interaction.
      Set StarCssClass, FilledStarCssClass, EmptyStarCssClass and WaitingStarCssClass to those styles.
      Add a button (btnSubmit) and a Label (lblChoices) to display the results of the rating.
      Add an event handler for the button's click handler with the code given to update the label.
      Run form, change rating and press button.
      Try altering currentrating and maxrating, ratingalign and rating direction.
      
      Now for the slider. This control is actually an extender for a textbox control, which stores the actual slider value.
      It also requires a second control, Label or Textbox which is bound to it and displays the numeric value of the slider.
      Add two textboxes to the page called txtHiddenSlider and txtVisibleSlider with empty text properties.
      Add the slider to the page. Set targetControlId and boundcontrolid to txtHiddenSlider and txtVisibleSlider respectively.
      
      Run the page. Notice the value in the text box changes with the slider. 
      If you change the value in the textbox the slider will update once you click out of the textbox.
      Set Minimum and Maximum to set the value bounds on the slider, steps to a value greater than 1 for sliding up the values
      and Orientation to draw the slider horizontal or vertical.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      Rate Luciano Pavarotti :
      <cc1:Rating ID="Rating1" runat="server" StarCssClass="ratingStar" FilledStarCssClass="filledRatingStar"
         EmptyStarCssClass="emptyRatingStar" WaitingStarCssClass="savedRatingStar" CurrentRating="3"
         MaxRating="10" />
      <br />
      <br />
      How loud is he? : 
      <asp:TextBox ID="txtHiddenSlider" runat="server"></asp:TextBox>
      <asp:TextBox ID="txtVisibleSlider" runat="server"></asp:TextBox>      
      <cc1:SliderExtender ID="SliderExtender1" runat="server" 
         TargetControlID="txtHiddenSlider" BoundControlID="txtVisibleSlider" />
      <br />
      <br />
      <asp:Label ID="lblChoices" runat="server"></asp:Label>
      <asp:Button ID="btnSubmit" runat="server" Text="Go" OnClick="btnSubmit_Click" />
   </div>
   </form>
</body>
</html>
