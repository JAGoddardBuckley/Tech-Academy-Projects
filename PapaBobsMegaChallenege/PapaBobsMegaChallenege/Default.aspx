<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsMegaChallenege.Presentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div class ="container">

            <div class="page=header">
                <h1>Papa Bob's Pizza</h1>
                <p class="lead">Pizza to Code By</p>
            </div>
            <div class="form-group">
                <label>Size: </label>
                <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Value="">Select a size... </asp:ListItem>
                    <asp:ListItem Value="Small">Small (12 inch - $12)</asp:ListItem>
                    <asp:ListItem Value="Medium">Medium (14 inch - $14)</asp:ListItem>
                    <asp:ListItem Value="Large">Large (16 inch - $16)</asp:ListItem>
                </asp:DropDownList>
             </div>
            <div class="form-group">
                <label>Crust: </label>
                <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="recalculateTotalCost">
                    <asp:ListItem Value="">Select a crust... </asp:ListItem>
                    <asp:ListItem Value ="Regular">Regular</asp:ListItem>
                    <asp:ListItem Value ="Thin">Thin</asp:ListItem>
                    <asp:ListItem Value="Thick">Thick</asp:ListItem>
                </asp:DropDownList>
            </div>

        
            <div class="checkbox"><label><asp:CheckBox ID="sausageCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Sausage</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="pepperoniCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Pepperoni</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="onionsCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Onions</label></div>
            <div class="checkbox"><label><asp:CheckBox ID="peppersCheckBox" runat="server" AutoPostBack="true" OnCheckedChanged="recalculateTotalCost"/> Green Peppers</label></div>

            <h3>Deliver To:</h3>
            <div class="form-group">
                <label>Name:</label>
                <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class ="form-group">
                <label>Address:</label>
                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Zip:</label>
                <asp:TextBox ID="zipTextBox" runat="server" CssClass="form-control" AutoPostBack="true"></asp:TextBox>
            </div>
            <div class="form-group">
                <label>Phone:</label>
                <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control" AutoPostBack="true"> </asp:TextBox>
            </div>


            <h3>Payment:</h3>
            <div class="radio"><label><asp:RadioButton ID="cashRadioButton" runat="server" Checked="true" GroupName="PaymentGroup"/> Cash</label></div>
            <div class="radio"><label><asp:RadioButton ID="creditRadioButton" runat="server" GroupName="PaymentGroup"/> Credit</label></div>

            <asp:Button ID="orderButton" runat="server" Text="Order" CssClass="btn btn-lrg btn-primary" OnClick="orderButton_Click"/>
            <br />
            <br />
            <asp:Label ID="validLabel" runat="server" Text="" CssClass="bg-danger" Visible="false"></asp:Label>
             
            
            <h3>Total Cost:<asp:Label ID="totalLabel" runat="server" Text=""></asp:Label></h3>


            <br />
            <br />


        </div>
    </form>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
