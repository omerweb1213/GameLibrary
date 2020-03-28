<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GameAddPage.aspx.cs" Inherits="GameAddPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {}
        .style3
        {
            text-decoration: underline;
            font-size: xx-large;
            color: #FF0000;
        }
        .style5
        {
            color: #FF0000;
            font-size: medium;
        }
        .style6
        {
            text-decoration: underline;
            font-size: medium;
            color: #FF0000;
        }
        .style7
        {
            color: #FF0000;
        }
        .style8
        {
            text-decoration: underline;
            color: #FF0000;
            font-size: medium;
        }
        .style9
        {
            direction: ltr;
        }
        .style10
        {
            text-decoration: underline;
        }
        .style11
        {
            color: #FF003A;
        }
    </style>
</head>
<body background="AddGamePhoto.jpg" style="background-repeat:no-repeat;">
<form id="form1" runat="server">
    
    
    <br />
    <a href=MainPage.aspx>Back to main page</a>
    <br />
        
    <p style="direction: ltr">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style3">Add A New Game:</span><br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <span class="style6">Game Name:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="GameName" runat="server" CssClass="style5" Height="25px" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Please enter game name" ControlToValidate="GameName" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>
    <p>
        &nbsp;</p>
    <p class="style1">
        <span class="style6">Price:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Price" runat="server" CssClass="style5" Height="25px" Width="170px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Please enter game price" ControlToValidate="Price" 
            EnableViewState="False" ForeColor="#0099FF"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="Price" ErrorMessage="Please enter a valid price" 
            ForeColor="#0099FF" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
    </p>
    <span class="style5">
    <br />
    <br />
    <span class="style10">Count:</span></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Count" runat="server" CssClass="style5" Height="25px" 
            Width="170px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ErrorMessage="Please enter game count" ControlToValidate="Count" 
        ForeColor="#0099FF"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="Count" ErrorMessage="Please enter a valid count" 
        ForeColor="#0099FF" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
    <br />
    <br />
    <br />
    <p>
        <span class="style7"><span class="style8">Release Date:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;<asp:TextBox 
            ID="ReleaseDate" runat="server" type="date" CssClass="style5" 
            Width="170px" Height="25px"></asp:TextBox> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ErrorMessage="Please enter release date" ControlToValidate="ReleaseDate" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <span class="style6">Category:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Categories" runat="server" Height="25px" Width="100px" 
            ForeColor="Red">
            <asp:ListItem>FPS</asp:ListItem>
            <asp:ListItem>Racing</asp:ListItem>
            <asp:ListItem>MOBA</asp:ListItem>
            <asp:ListItem>MMORPG</asp:ListItem>
            <asp:ListItem>Adventure</asp:ListItem>
            <asp:ListItem>Horror</asp:ListItem>
            <asp:ListItem>Indie</asp:ListItem>
            <asp:ListItem>Strategy</asp:ListItem>
            <asp:ListItem>Sport</asp:ListItem>
            <asp:ListItem>Fantasy</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p class="style11">
        <span class="style10">Console:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="Consoles" runat="server" style="color: #FF0000">
            <asp:ListItem>All</asp:ListItem>
            <asp:ListItem>PC</asp:ListItem>
            <asp:ListItem>PS</asp:ListItem>
            <asp:ListItem>Xbox</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnSavePic" runat="server" onclick="btnSavePic_Click" 
            Text="Save Photo" Width="100px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
        <asp:Image ID="GamePhoto" runat="server" Height="139px" Width="213px" />
    </p>
    <p>
        &nbsp;</p>
        <p class="style9">
            <span class="style6">Producer Name:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ProducersDDL" runat="server" Height="20px" 
                 Width="170px">
            </asp:DropDownList>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="AddGameButton" runat="server" Text="Add Game" Width="108px" 
            onclick="AddGameButton_Click" />
    </p>
    <p>
    <a href="GameGridView.aspx">View All Games</a>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    
    </form>
    
    </body>
</html>
