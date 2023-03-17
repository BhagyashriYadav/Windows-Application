<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insert.aspx.cs" Inherits="insert" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
    <div>
        <label>ID</label>
        <asp:TextBox runat="server" ID="txtid"></asp:TextBox><br /><br />
        <label>F_NAME</label>
        <asp:TextBox runat="server" ID="txtfname"></asp:TextBox><br /><br />
        <label>M_NAME</label>
        <asp:TextBox runat="server" ID="txtmname"></asp:TextBox><br /><br />
        <label>L_NAME</label>
        <asp:TextBox runat="server" ID="Textlame"></asp:TextBox><br /><br />
        <label>STANDARD</label>
        <asp:TextBox runat="server" ID="Textstd"> </asp:TextBox><br /><br />
        <label>EMAIL</label>
        <asp:TextBox runat="server" ID="Textemail"></asp:TextBox><br /><br />
        <label>PRN</label>
        <asp:TextBox runat="server" ID="Textprn"></asp:TextBox><br /><br />
        <label>SUBJECT</label>
        <asp:TextBox runat="server" ID="Textsub"> </asp:TextBox><br /><br />
        <label>MARKS</label>
        <asp:TextBox runat="server" ID="Textmarks"></asp:TextBox><br /><br />
        <label>INSERT</label>
        <asp:TextBox runat="server" ID="Textintrest"></asp:TextBox><br /><br />
       
        <asp:Button  runat="server" ID="btninsert" OnClick="btninsert_Click" Text="INSERT"/>
        </div>
          </form>
</body>
</html>
