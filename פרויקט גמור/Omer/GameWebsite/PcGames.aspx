﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PcGames.aspx.cs" Inherits="PcGames" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

        
    <title></title>
    <style>
        
a {
    color: red;
}
        .style2
        {
            text-decoration: underline;
            font-size: medium;
        }
        .style3
        {
            color: #3366FF;
        }
    </style>
</head>
<body background="PcGamesPhoto.jpg" style="background-repeat:no-repeat;">
<form runat="server">
   
    <a href="MainPage.aspx">Back to main page</a>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style2"><span class="style3">your currency: <% %></span></span>&nbsp;<asp:Label 
    ID="Currency" runat="server" CssClass="style3" Text="Label"></asp:Label>
<br />
<br />
<br />
<asp:DataList ID="PcDataList" runat="server" RepeatDirection="Horizontal"
RepeatColumns="3" onitemcommand="PcDataList_ItemCommand" 
    onitemdatabound="PcDataList_ItemDataBound" style="color: #FF0000">

        <ItemTemplate>
        <table>
        <tr>
        <td><asp:Label ID="GameID" runat="server" Text='<%# Bind("GameID") %>'></asp:Label></td>
        </tr>
        <tr>
        <td><asp:Label ID="GameName" runat="server" Text='<%# Bind("GameName") %>'></asp:Label></td>
        </tr>
        <tr>
        <td><asp:Image ID="ExeImage" Height="150" Width="200" ImageUrl='<%# Bind("GamePicPath") %>' runat="server"></asp:Image></td>
        </tr>
         <tr>
        <td><asp:Label ID="lblGameConsole" runat="server" Text='<%# Bind("GameConsole") %>'></asp:Label>
        <asp:Label ID = "Rlbl" runat ="server" Text=", "></asp:Label>
        <asp:Label ID ="lblGamePrice" runat="server" Text='<%# Bind("GamePrice") %>'></asp:Label>
        <asp:Label ID = "Dollar" runat ="server" Text="$"></asp:Label></td>
        </tr>
        <tr>
        <td><asp:Button ID="SelectItem" CommandName="SelectItem" text="Select" runat="server" ></asp:Button></td>
        </tr>
    </table>
    </ItemTemplate>
    </asp:DataList>
     
    <asp:GridView ID="GvShoppingCart" runat="server" Height="119px" Width="233px" >
    </asp:GridView>
   
    <br />
    <br />
   
    </form>
</body>
</html>
