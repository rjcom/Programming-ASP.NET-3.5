<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StateHistoryDemo.aspx.cs"
    Inherits="StateHistoryDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>State History Demo</title>

    <script type="text/javascript">

        function pageLoad() {
        }
    
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="sm" runat="server" EnableHistory="true" EnableSecureHistoryState="false"
            OnNavigate="RestoreHistoryPoint" />
        <asp:UpdatePanel runat="server" ID="updHistory" UpdateMode="Always">
            <ContentTemplate>
                Authors :
                <asp:DropDownList ID="ddlAuthors" runat="server">
                    <asp:ListItem Text="Jesse Liberty" Value="JL" Selected="True" />
                    <asp:ListItem Text="Dan Hurwitz" Value="DH" />
                    <asp:ListItem Text="Dan Maharry" Value="DM" />
                    <asp:ListItem Text="Douglas Adams" Value="DA" />
                </asp:DropDownList>
                <br />
                Books :&nbsp;
                <asp:RadioButtonList ID="rblBooks" runat="server">
                    <asp:ListItem Text="Professional C# 3.0" Value="Pro C#3" Selected="True" />
                    <asp:ListItem Text="Object Oriented Design Heuristics" Value="O-ODH" />
                    <asp:ListItem Text="The Meaning of Liff" Value="Liff" />
                </asp:RadioButtonList>
                <br />
                <asp:Button ID="btnSave" runat="server" OnClick="SaveHistoryPoint" Text="Save" />
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>
    </form>
</body>
</html>
