<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllGames.aspx.cs" Inherits="AllGames" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <a href=Login.aspx>Back To Login</a>
        <br />
        <br />
        <br />
    </div>
<asp:DataList ID="PcDataList" runat="server" RepeatDirection="Horizontal"
RepeatColumns="3" style="color: #FF0000" 
        Height="712px" Width="859px">

        <ItemTemplate>
        <table>
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
        <form action=Login.aspx>
        <td><asp:Button ID="SelectItem" text="Select" runat="server" ></asp:Button></td>
        </form>
        </tr>
    </table>
    </ItemTemplate>
    </asp:DataList>
   
    </form>
</body>
</html>
