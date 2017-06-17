<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingUI.aspx.cs" Inherits="ShoppingWEB.ShoppingUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
   <script type ="text/javascript">
       function ValidateForBlanks()
       {
           var textBox = document.getElementById("txtNewProduct");
           if (textBox.value.trim() == '')
           {
               alert('Product name cannot be blank..');
               textBox.style.backgroundColor = "red";
               textBox.focus();
               return false;
           }
       }

      

   </script>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
            <asp:Button ID="btnNewProduct" runat="server" server="" Text="Add New Product" />
            
            <asp:TextBox ID="txtNewProduct" runat="server"></asp:TextBox>
            
            
            <asp:Button ID="btnSubmit" runat="server" Text="Done" OnClientClick =" return ValidateForBlanks()" />

        </div>
    </form>
</body>
</html>
