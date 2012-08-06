<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 453px; width: 907px;">
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="CustomerID"></asp:Label>
        <asp:TextBox ID="CustomerID" runat="server" style="margin-left: 49px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Region"></asp:Label>
        <asp:TextBox ID="Region" runat="server" style="margin-left: 78px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="CompanyName"></asp:Label>
        <asp:TextBox ID="CompanyName" runat="server" style="margin-left: 28px"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="PostalCode"></asp:Label>
        <asp:TextBox ID="PostalCode" runat="server" style="margin-left: 49px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="ContactName"></asp:Label>
        <asp:TextBox ID="ContactName" runat="server" style="margin-left: 39px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Country"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Country" runat="server" style="margin-left: 49px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="ContactTitle"></asp:Label>
        <asp:TextBox ID="ContactTitle" runat="server" style="margin-left: 50px"></asp:TextBox>
        <asp:Label ID="Label10" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="Phone" runat="server" style="margin-left: 81px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="Address" runat="server" style="margin-left: 72px"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Fax"></asp:Label>
        <asp:TextBox ID="Fax" runat="server" style="margin-left: 97px"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="City"></asp:Label>
        <asp:TextBox ID="City" runat="server" style="margin-left: 97px"></asp:TextBox>
        <br />
&nbsp;<br />
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="Them " />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Sua" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Xoa" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" 
            CellPadding="4" ForeColor="#333333" GridLines="None" Width="514px">
            <RowStyle BackColor="#EFF3FB" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
