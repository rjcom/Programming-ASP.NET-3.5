<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="BookCounter.aspx.cs" Inherits="BookCounter" %>
<%@ Register TagPrefix="OReilly" 
   Namespace="CustomControls" Assembly="CustomControls" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Book Counter</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <div>
         <OReilly:BookInquiryList ID="bookInquiry1" Runat="Server">
            <OReilly:BookCounter ID="Bookcounter1" 
               Runat="server" BookName="Programming ASP.NET" />
            <OReilly:BookCounter ID="Bookcounter2" 
               Runat="server" BookName="Programming C#" />
            <OReilly:BookCounter ID="Bookcounter3" 
               Runat="server" BookName="Programming Visual Basic.NET" />
            <OReilly:BookCounter ID="Bookcounter4" 
               Runat="server" BookName="Visual C#: A Developers Notebook" />
            <OReilly:BookCounter ID="BookCounter5" 
               Runat="server" BookName="Teach Yourself C++ 21 Days" />
            <OReilly:BookCounter ID="Bookcounter6" 
               Runat="server" BookName="Teach Yourself C++ 24 Hours" />
            <OReilly:BookCounter ID="Bookcounter7" 
               Runat="server" BookName="Clouds To Code" />
         </OReilly:BookInquiryList>
      </div>
   </form>
</body>
</html>
