<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
            font-size: large;
        }
        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: 700">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/PapaBob.png" />
            Papa Bob&#39;s Pizza and Software</div>
       
        
        
       
        <p style="font-weight: 700">
        <asp:RadioButton ID="BabyBobButton" runat="server" GroupName="pizzaSize" Text="Baby Bob Size (10&quot;) - $10" /><br />
        
            <asp:RadioButton ID="MamaBobButton" runat="server" GroupName="pizzaSize" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Mama Bob Size (13&quot;) - $13" /><br />
        
        <asp:RadioButton ID="PapaBobButton" runat="server" GroupName="pizzaSize" Text="Papa Bob Size (16&quot;) - $16 " />
       </p>
        <p style="height: 50px">
            <strong>
            <asp:RadioButton ID="ThinButton" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" GroupName="Crust" Text="Thin Crust" /><br />
            <asp:RadioButton ID="DeepButton" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged1" GroupName="Crust" Text="Deep Dish (+2)" /><br />
            </strong>
       </p>
        <p style="font-size: medium; font-weight: 700">
            <asp:CheckBox ID="PepperoniBox" runat="server" Text="Pepperoni (+$1.50)" /><br />
            <asp:CheckBox ID="OnionBox" runat="server" Text="Onions (+$0.75)" /><br />
            <asp:CheckBox ID="GreenBox" runat="server" Text="Green Peppers (+$0.50)" /><br />
            <asp:CheckBox ID="RedBox" runat="server" Text="Red Peppers (+$0.75)" /><br />
            <asp:CheckBox ID="FishBox" runat="server" Text="Anchovies (+$2)" />
        </p>
        <p class="auto-style3" style="font-size: medium; font-weight: 700">
            <span class="auto-style2">Papa Bob&#39;s</span> <span class="auto-style1">Special Deal</span></p>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers, and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
        
        
       
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Purchase" />
        <br />
        <br />
        Total: <asp:Label ID="resultLabel" runat="server" Text="$0.00"></asp:Label>
        
        
       
        
    </form>
    <p>
        Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!
    </p>
</body>
</html>
