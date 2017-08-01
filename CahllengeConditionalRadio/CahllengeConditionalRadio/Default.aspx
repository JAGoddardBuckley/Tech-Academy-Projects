<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CahllengeConditionalRadio.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="PencilButton" runat="server" GroupName="NoteTakers"  Text="Pencil" />
            <br />
            <asp:RadioButton ID="PenButton" runat="server" GroupName="NoteTakers"  Text="Pen" />
            <br />
            <asp:RadioButton ID="PhoneButton" runat="server" GroupName="NoteTakers" Text="Phone" />
            <br />
            <asp:RadioButton ID="TabletButton" runat="server" GroupName="NoteTakers"  Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="OK" Width="33px" />
            <br />
            <asp:Image ID="resultImage" runat="server" ImageAlign="Middle" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
