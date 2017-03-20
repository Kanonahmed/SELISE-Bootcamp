<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        What is your first name ?<asp:TextBox ID="text1" runat="server" Width="193px"></asp:TextBox>
        <br />
        <br />
        What is your last name ?
        <asp:TextBox ID="text2" runat="server" Width="186px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="button" runat="server" OnClick="button_Click" Text="Click Me" />
        <br />
    
    </div>
        <p>
            <asp:Label ID="result" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
