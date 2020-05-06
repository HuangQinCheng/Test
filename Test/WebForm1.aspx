<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:red;">
            <asp:GridView ID="GridView1" AllowPaging="true" PageSize="2" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging">

              <PagerTemplate>

              </PagerTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
