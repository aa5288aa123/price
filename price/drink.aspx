<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="drink.aspx.cs" Inherits="price.drink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <h2><asp:Label ID="Label1" runat="server" Text="菜單"></asp:Label></h2>
            


        
        <asp:CheckBox ID="CheckBox1" runat="server" Text="珍珠奶茶"/>      
        <asp:Label ID="Label2" runat="server" Text="45元"></asp:Label>
        <asp:HiddenField id="A_text" runat="server" value="45元"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="紅茶"/>
        <asp:Label ID="Labe3" runat="server" Text="20元"></asp:Label>
        <asp:HiddenField id="B_text" runat="server" value="20元"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" Text="冬瓜茶"/>
        <asp:Label ID="Label4" runat="server" Text="25元"></asp:Label>
        <asp:HiddenField id="C_text" runat="server" value="25元"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox4" runat="server" Text="奶茶"/>
        <asp:Label ID="Label5" runat="server" Text="25元"></asp:Label>
        <asp:HiddenField id="D_text" runat="server" value="25元"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox5" runat="server" Text="養樂多綠茶"/>
        <asp:Label ID="Label6" runat="server" Text="30元"></asp:Label>
        <asp:HiddenField id="E_text" runat="server" value="30元"/>
        <asp:Button ID="Button1" runat="server" Text="送出" PostBackUrl="drink2.aspx"/>
        </div>
    </form>
</body>
</html>
