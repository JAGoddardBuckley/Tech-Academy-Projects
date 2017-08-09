<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" OnDataBinding="Page_Load" />
            <asp:Image ID="Image2" runat="server" Height="150px" OnDataBinding="Page_Load" />
            <asp:Image ID="Image3" runat="server" Height="150px" OnDataBinding="Page_Load" />
        </div>
        <p>
            Your Bet:
            <asp:TextBox ID="betBox" runat="server" OnTextChanged="betBox_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="pullButton" runat="server" OnClick="pullButton_Click" Text="Pull The Lever!" />
        <br />
        <br />
&nbsp;<asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1Cherry - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        <br />
        3 7&#39;s - Jackpot - x10 Your Bet<br />
        <br />
        HOWEVER<br />
        <br />
        If there&#39;s even one BAR you win nothing</form>
</body>
</html>
