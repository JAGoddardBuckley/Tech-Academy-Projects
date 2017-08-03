<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="logo" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
        </div>
        <p style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: large">
            Spy New Assignment</p>
        <p>
            Spy Code Name:&nbsp;&nbsp;
            <asp:TextBox ID="NameBox" runat="server" Width="182px"></asp:TextBox>
        </p>
        <p>
            New Assignment Name:&nbsp;&nbsp;
            <asp:TextBox ID="AssignBox" runat="server" Width="164px"></asp:TextBox>
        </p>
        <p>
            End of Previous Assignment:<asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assingment:<asp:Calendar ID="Calendar3" runat="server"></asp:Calendar>
        </p>
        <p >
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
