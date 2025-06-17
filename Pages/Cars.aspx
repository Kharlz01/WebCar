<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="True" />
    </div>
</form>

</body>
</html>
