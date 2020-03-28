<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserListPage.aspx.cs" Inherits="UserListPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #FF0000;
            font-size: medium;
        }
        .style2
        {
            color: #FF0000;
        }
        .style3
        {
            text-decoration: underline;
            color: #FF0000;
            font-size: medium;
        }
    </style>
</head>
<body background="UserListPhoto.jpg" style="background-repeat:no-repeat;">>
<a href=MainPage.aspx>Back to main page</a><br />
&nbsp;<form id="form1" runat="server">
    <span class="style3">All current users:</span><br />
    <br />
    <span class="style1">Search By:</span>&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <span class="style2">Text:</span>&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextSearch" runat="server" Height="25px" Width="170px"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Button ID="BtnSearch" runat="server" onclick="BtnSearch_Click" 
        Text="Search" />
    <br />
    <br />
    <br />
    <div style="position:absolute; height:100% ; width: 100% ">
    <div>
    <asp:GridView ID="UserGridView" runat="server" Height="333px" Width="1144px" 
            AllowSorting="True" AutoGenerateColumns="False" 
            onsorting="UserGridView_Sorting" onrowediting="UserGridView_RowEditing" 
            onrowcancelingedit="UserGridView_RowCancelingEdit1" 
            onrowupdating="UserGridView_RowUpdating1" 
            onrowdatabound="UserGridView_RowDataBound" 
            onrowdeleting="UserGridView_RowDeleting" style="color: #FF0000" >
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="User ID" 
                SortExpression="UserID" ReadOnly="True" />
            <asp:TemplateField HeaderText="UserName" SortExpression="UserName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("UserName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("UserName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PassWord" SortExpression="UserPass">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("UserPass") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("UserPass") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="First Name" SortExpression="Fname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Fname") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Fname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Last Name" SortExpression="Lname">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Lname") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("Lname") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Credit Card ID" SortExpression="CardNum">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("CardNum") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("CardNum") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email" SortExpression="Email">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="BirthDate" SortExpression="BirthDate">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("BirthDate") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("BirthDate") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Picture" SortExpression="PicPath">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("picpath") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Image ID="UserImage" heigh="50" Width="50" ImageUrl='<%# Bind("picpath")%>' runat="server" /></asp:Image>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False" HeaderText="Edit">
                <EditItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="True" 
                        CommandName="Update" Text="Update" />
                    &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" 
                        CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                        CommandName="Edit" Text="Edit" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:Button ID="DeleteButton" runat="server" CausesValidation="False" 
                        CommandName="Delete" Text="Delete"></asp:Button>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    </div>
    </div>
    <br />
    <br />
    <br />
    </form>
</body>
</html>
