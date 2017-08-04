<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        </div>
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: 700;">
        Asset Performace Tracker</p>
    <p>
        Asset Name:&nbsp;
        <asp:TextBox ID="NameBox" runat="server" Width="151px"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:&nbsp; <asp:TextBox ID="ElectionsBox" runat="server" Height="20px" Width="143px"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="ActsBox" runat="server" Width="140px"></asp:TextBox>
        </p>
        <asp:Button ID="AddButton" runat="server" OnClick="AddButton_Click" Text="Add Asset" />
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
    </body>
</html>
