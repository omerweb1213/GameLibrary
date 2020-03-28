<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="free-white.css">
    <title></title>
    <style type="text/css">
        .style3
        {
            color: #FF0000;
        }
        .style4
        {
            font-size: large;
        }
        .style5
        {
            color: #FF0000;
            font-size: large;
            margin-left: 0px;
        }
        .style7
        {
            color: #FF0000;
            font-size: medium;
            text-decoration: underline;
        }
        .style8
        {
            color: #FF0000;
            font-size: large;
        }
        .style9
        {
            color: #FF0000;
            font-size: large;
            direction: ltr;
        }
        .style10
        {
            color: #FF0000;
            margin-left: 0px;
        }
        .style11
        {
            text-decoration: underline;
            font-size: medium;
        }
        .style12
        {
            font-size: large;
        }
        .style13
        {
            font-size: x-large;
            color: #00FFFF;
            text-align: justify;
        }
        .style14
        {
            text-decoration: underline;
            color: #FF0000;
        }
        .style15
        {
            text-align: center;
            font-size: xx-large;
            text-decoration: underline;
            color: #FF0000;
        }
        .style16
        {
            text-decoration: underline;
            color: #FF0000;
        }
    </style>
</head>
<body background="SignUpPhoto.jpg" style="background-repeat:no-repeat;">
    <form id="form1" runat="server">
        <p class="style15">
            SignUp Page:</p>
    <p>
        <a href=Login.aspx>Already registered?</a></p>
    <p>
        <span class="style10"><span class="style11">UserName:</span></span><span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="UserName" runat="server" CssClass="style5" Width="170px" 
            Height="25px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName" 
            ErrorMessage="please enter username" ForeColor="#0099FF"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;
        </p>
    <p>
        <span class="style3"><span class="style11">PassWord:</span><span class="style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span> 
        </span> 
        <asp:TextBox ID="PassWord" runat="server" CssClass="style5" Width="170px" 
            Height="25px" type="password"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="PassWord" ErrorMessage="please enter password" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>
    <p>
        <span class="style16">Confirm PassWord:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="PassWordConfirm" runat="server" CssClass="style5" Width="170px" 
            Height="25px" type="password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
            ControlToValidate="PassWordConfirm" 
            ErrorMessage="please enter password confirmation" ForeColor="#0099FF"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="PassWord" ControlToValidate="PassWordConfirm" 
            ErrorMessage="passwords don't match" ForeColor="#0099FF"></asp:CompareValidator>
    </p>
    <p>
        <span class="style7">Birth Date:</span><span class="style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:TextBox ID="BirthDate" runat="server" type="date" CssClass="style5" 
            Width="170px" Height="25px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="BirthDate" ErrorMessage="please enter BirthDate" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>
    <p>
        <span class="style10"><span class="style11">First Name:</span></span><span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        </span>
        <asp:TextBox ID="FirstName" runat="server" CssClass="style5" Height="25px" 
            Width="170px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="FirstName" ErrorMessage="please enter first name" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>
    <p>
        <span class="style10"><span class="style11">Last Name:</span></span><span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
        <asp:TextBox ID="LastName" runat="server" CssClass="style5" Height="25px" 
            Width="170px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="LastName" ErrorMessage="please enter last name" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
        <span class="style5">&nbsp;&nbsp;&nbsp; &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        </span>
    </p>
    <p>
        <span class="style10"><span class="style11">ID Number:</span></span><span class="style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;</span><span 
            class="style4">&nbsp;
        </span>
        <asp:TextBox ID="UserID" runat="server" CssClass="style5" Height="25px" 
            Width="170px" ForeColor="#FF3300"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="UserID" ErrorMessage="please enter ID" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p class="style9">
        <span class="style11">Email:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Email" runat="server" CssClass="style5" Width="170px" Height="25px" ForeColor="#FF3300"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
            ControlToValidate="Email" ErrorMessage="please enter email" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="Email" ErrorMessage="please enter a valid email" 
            ForeColor="#0099FF" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p class="style9">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnSavePic" runat="server" onclick="btnSavePic_Click" 
            Text="Save Photo" />
    </p>
    <p class="style9">
        <asp:Image ID="Image1" runat="server" Height="139px" style="margin-left: 117px" 
            Width="213px" />
    </p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<p class="style13">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="style14">Credit card details:</span></p>
    <p class="style12">
        <span class="style14">Credit Card Number:</span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="CreditCardNum" runat="server" CssClass="style5" Height="25px" Width="170px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
            ControlToValidate="CreditCardNum" ErrorMessage="please enter card number" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style14">CVV Code:</span>&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style14">
        <asp:TextBox ID="CVVCode" runat="server" CssClass="style5" Height="25px" Width="170px"></asp:TextBox>
        </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
            ControlToValidate="CVVCode" ErrorMessage="please enter Cvv Code" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>

    
    <p class="style12">
        <span class="style14">Expire Date:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ExpireDate" runat="server" type="date" CssClass="style5" 
            Width="170px" Height="25px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
            ControlToValidate="ExpireDate" ErrorMessage="please enter expire date" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style14">Total Money:</span>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TotalMoney" runat="server" CssClass="style5" Height="25px" Width="170px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
            ControlToValidate="TotalMoney" ErrorMessage="please enter total money" 
            ForeColor="#0099FF"></asp:RequiredFieldValidator>
    </p>
    <p class="style12">
        <asp:DropDownList ID="CreditCardTypesDDL" runat="server">
        </asp:DropDownList>
    </p>
    <p class="style12">
        &nbsp;</p>
    <p class="style12">
        <asp:Button ID="SignUpButton" runat="server" Height="34px" 
            onclick="SignUpButton_Click" Text="Sign Up" Width="93px" />
    </p>
    </div>
    </form>
</body>
</html>
