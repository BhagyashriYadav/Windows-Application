<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
    <div>
        <label>id</label>
    <asp:TextBox runat="server" ID="id"></asp:TextBox><br /><br />
        <label>fname</label>
        <asp:TextBox runat="server" ID="Fname"> </asp:TextBox><br /><br />
        <label>lname</label>
        <asp:TextBox runat="server" ID="Lname"></asp:TextBox><br /><br />
        <asp:Button  runat="server" ID="btnsave" OnClick="btnsave_Click" Text="save"/>
        </div>
          </form>
</body>
</html>
