﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RecoverPW.aspx.vb" Inherits="RecoverPW" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recover Password</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" 
            onsendingmail="PasswordRecovery1_SendingMail">
        </asp:PasswordRecovery>
    </div>
    </form>
</body>
</html>