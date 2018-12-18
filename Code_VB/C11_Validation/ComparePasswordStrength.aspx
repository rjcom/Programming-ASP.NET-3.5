<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ComparePasswordStrength.aspx.vb" Inherits="ComparePasswordStrength" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Using the Password Strength Control</title>

    <script type="text/javascript">

        function pageLoad() {
        }
    
    </script>

    <style media="screen" type="text/css">
        .VPoor
        {
            background-color: Gray;
            color: White;
            font-family: Arial;
            font-size: x-small;
            font-style: italic;
            padding: 2px 3px 2px 3px;
            font-weight: bold;
        }
        .Weak
        {
            background-color: Gray;
            color: Yellow;
            font-family: Arial;
            font-size: x-small;
            font-style: italic;
            padding: 2px 3px 2px 3px;
            font-weight: bold;
        }
        .Average
        {
            background-color: Gray;
            color: #FFCAAF;
            font-family: Arial;
            font-size: x-small;
            font-style: italic;
            padding: 2px 3px 2px 3px;
            font-weight: bold;
        }
        .Strong
        {
            background-color: Gray;
            color: Aqua;
            font-family: Arial;
            font-size: x-small;
            font-style: italic;
            padding: 2px 3px 2px 3px;
            font-weight: bold;
        }
        .Excellent
        {
            background-color: Gray;
            color: #93FF9E;
            font-family: Arial;
            font-size: x-small;
            font-style: italic;
            padding: 2px 3px 2px 3px;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <h1>
        Password Strength Demo
    </h1>
    <form runat="server" id="frmBugs">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <table cellpadding="3" border="1">
            <tr>
                <td colspan="3" align="center">
                    <asp:Label ID="lblMsg" Text="Please report your bug here" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    Book
                </td>
                <td>
                    <!-- Drop down list with the books (must pick one) -->
                    <asp:DropDownList ID="ddlBooks" runat="server">
                        <asp:ListItem>-- Please Pick A Book --</asp:ListItem>
                        <asp:ListItem>Programming ASP.NET</asp:ListItem>
                        <asp:ListItem>Learning ASP.NET With AJAX</asp:ListItem>
                        <asp:ListItem>Programming C# 2008</asp:ListItem>
                        <asp:ListItem>Programming Visual Basic 2008</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <!-- Validator for the drop down -->
                    <asp:RequiredFieldValidator ID="rfvBooks" ControlToValidate="ddlBooks" Display="Static"
                        InitialValue="-- Please Pick A Book --" runat="server" ErrorMessage="Please choose a book"
                        Text="*" />
                </td>
            </tr>
            <tr>
                <td>
                    Edition:
                </td>
                <td>
                    <asp:RadioButtonList ID="rblEdition" RepeatLayout="Flow" runat="server">
                        <asp:ListItem>1st</asp:ListItem>
                        <asp:ListItem>2nd</asp:ListItem>
                        <asp:ListItem>3rd</asp:ListItem>
                        <asp:ListItem>4th</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <!-- Validator for editions -->
                <td>
                    <asp:RequiredFieldValidator ID="rfvEdition" runat="server" ControlToValidate="rblEdition"
                        Display="Static" ErrorMessage="Please pick an edition" Text="*" />
                </td>
            </tr>
            <tr>
                <td>
                    Bug:
                </td>
                <!-- Multi-line text for the bug entry -->
                <td>
                    <asp:TextBox ID="txtBug" runat="server" TextMode="MultiLine" />
                </td>
                <!-- Validator for the text box-->
                <td>
                    <asp:RequiredFieldValidator ID="rfvBug" ControlToValidate="txtBug" Display="Static"
                        runat="server" ErrorMessage="Please provide bug details" Text="*" />
                </td>
            </tr>
            <tr>
                <td>
                    Page Number:
                </td>
                <td>
                    <asp:TextBox ID="txtPageNumber" runat="server" />
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="rfvPageNumber" ControlToValidate="txtPageNumber"
                        ErrorMessage="You did not enter the page number" Text="*" />
                    <asp:CompareValidator runat="server" ID="cmpPageNumber" ControlToValidate="txtPageNumber"
                        ErrorMessage="Invalid page number" Type="Integer" Operator="DataTypeCheck" Text="*" />
                </td>
            </tr>
            <!-- Text fields for passwords -->
            <tr>
                <td>
                    Enter your password:
                </td>
                <td>
                    <asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" />
                    <cc1:PasswordStrength ID="txtPassword1_PasswordStrength" runat="server" Enabled="True"
                        TargetControlID="txtPassword1" DisplayPosition="RightSide" StrengthIndicatorType="Text"
                        PreferredPasswordLength="10" PrefixText="Strength:" 
                        TextStrengthDescriptions="Very Poor;Weak;Average;Strong;Excellent" StrengthStyles="VPoor;Weak;Average;Strong;Excellent"
                        MinimumNumericCharacters="0" MinimumSymbolCharacters="0" RequiresUpperAndLowerCaseCharacters="false">
                    </cc1:PasswordStrength>
                </td>
                <td>
                    <!-- required to enter the password -->
                    <asp:RequiredFieldValidator runat="server" ID="rfvPassword1" ControlToValidate="txtPassword1"
                        ErrorMessage="Please enter your password" Text="*" />
                </td>
            </tr>
            <!-- Second password for comparison -->
            <tr>
                <td>
                    Re-enter your password:
                </td>
                <td>
                    <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" />
                </td>
                <td>
                    <!-- Second password is required -->
                    <asp:RequiredFieldValidator runat="server" ID="rfvPassword2" ControlToValidate="txtPassword2"
                        ErrorMessage="Please re-enter your password" Text="*" />
                    <!-- Second password must match the first -->
                    <asp:CompareValidator runat="server" ID="cmpPasswords" ControlToValidate="txtPassword2"
                        ErrorMessage="Passwords do not match" Type="String" Operator="Equal" ControlToCompare="txtPassword1"
                        Text="*" />
                </td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Button ID="btnSubmit" Text="Submit Bug" runat="server" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList"
            HeaderText="The following errors were found: " ShowSummary="true" />
    </form>
</body>
</html>
