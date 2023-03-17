<%@ Page Language="C#" AutoEventWireup="true" CodeFile="update.aspx.cs" Inherits="update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--- <asp:TextBox runat="server" ID="txtid"></asp:TextBox>--->
        <label>F_NAME</label>
        <asp:TextBox runat="server" ID="txtfname"></asp:TextBox><br /><br />
     <!---   <asp:TextBox runat="server" ID="txtmname"></asp:TextBox>
        <asp:TextBox runat="server" ID="Textlame"></asp:TextBox>
        <asp:TextBox runat="server" ID="Textstd"> </asp:TextBox>-->
        <label>EMIAL</label>
        <asp:TextBox runat="server" ID="Textemail"></asp:TextBox><br /><br />
        <label>PRN</label>
        <asp:TextBox runat="server" ID="Textprn"></asp:TextBox><br /><br />
      <!---  <asp:TextBox runat="server" ID="Textsub"> </asp:TextBox>
        <asp:TextBox runat="server" ID="Textmarks"></asp:TextBox>
        <asp:TextBox runat="server" ID="Textintrest"></asp:TextBox>--->
       
        <asp:Button  runat="server" ID="btnupdate" OnClick="btnupdate_Click" Text="update"/>
    </div>
    </form>
</body>
</html>
