<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test0616_DataReaderOnWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <% while (dr.Read()) { %>
            <li><%= dr["ProductName"]  %></li>
            <% } %>
        </ul>
    </div>
    </form>
</body>
</html>
