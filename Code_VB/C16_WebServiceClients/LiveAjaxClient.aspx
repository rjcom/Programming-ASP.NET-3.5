<%@ Page Language="VB" AutoEventWireup="true" CodeFile="LiveAjaxClient.aspx.vb" Inherits="LiveAjaxClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Ajax-Enabled Live Search Client</title>
      <script type="text/javascript">
    
    function Search(query)
    {
        LiveSearchWithAjax.Search(query, OnSearchSucceeds);
    }
    
    function OnSearchSucceeds(results)
    {
        var html = "";
        for (var i = 0; i < results.length; ++i) 
        {
            html += '<a href="'+results[i].url+'">'+results[i].title + "</a><br/>";
        }
        document.getElementById('pnlResults').innerHTML = html;
    }
    
  </script>
</head>
<body>
  <h1>
    Ajax-Enabled Live Search Client</h1>
  <form id="form1" runat="server">
  <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
      <Services>
        <asp:ServiceReference Path="~/LiveSearchWithAjax.svc" />
      </Services>
    </asp:ScriptManager>
    <input type="text" id="tbSearchFor" />
    <input type="button" id="btnSearch" value="Search" onclick="Search(document.getElementById('tbSearchFor').value);" />
    <div id="pnlResults">
    </div>
  </div>
  </form>
</body>
</html>
