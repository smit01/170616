<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="test0616_StateInfo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Write to Application" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read from Application" />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="Button3" runat="server" Text="Write to Session" OnClick="Button3_Click" />
        &nbsp;<asp:Button ID="Button4" runat="server" Text="Read from Session" OnClick="Button4_Click" />
    
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Write to Cookie" />
&nbsp;<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Read from Cookie" />
        <br />
    
    </div>
    </form>
</body>
</html>
