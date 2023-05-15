<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
  
        <asp:TextBox runat="server" ID="Lname"></asp:TextBox><br /><br />
   
       
        <asp:Button  runat="server" ID="btndelete" OnClick="btndelete_Click" Text="delete" />

    </div>
    </form>
    
</body>
</html>
