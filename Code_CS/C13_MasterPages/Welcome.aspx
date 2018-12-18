<%@ Page Language="C#" MasterPageFile="~/SiteMasterPage.master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TopPageContent" Runat="Server">
   <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
   <br />
   You can put anything you want to in the content box.
</asp:Content>

