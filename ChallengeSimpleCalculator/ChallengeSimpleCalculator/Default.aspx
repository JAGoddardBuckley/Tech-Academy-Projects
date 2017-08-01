<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                <span class="auto-style1">First Value: </span>&nbsp;<asp:TextBox ID="TextBoxOne" runat="server"></asp:TextBox>
            </p>
            <p>
                <span class="auto-style1">Second Value: </span>&nbsp;<asp:TextBox ID="TextBoxTwo" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="+" Width="26px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="SubButton" runat="server" OnClick="SubButton_Click" style="margin-left: 0px" Text="-" Width="25px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="MultButton" runat="server" OnClick="MultButton_Click" style="margin-left: 0px" Text="*" Width="25px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="DivButton" runat="server" OnClick="DivButton_Click" Text="/" Width="28px" />
            </p>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="resultLabel" runat="server" BackColor="#6699FF" Font-Bold="True" Font-Names="Arial Black" Font-Size="Larger"></asp:Label>
            </p>
            <br />
        </div>
    </form>
</body>
</html>
