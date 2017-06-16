<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingUI.aspx.cs" Inherits="ShoppingWEB.ShoppingUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
            <asp:Button ID="btnNewProduct" runat="server" server="" Text="Add New Product" />
            
            <asp:TextBox ID="txtNewProduct" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate="txtNewProduct"
             Display="Dynamic" ErrorMessage="RequiredFieldValidator">* This is required!</asp:RequiredFieldValidator>
            
            <asp:Button ID="btnSubmit" runat="server" Text="Done" />

        </div>
    </form>
</body>
</html>
