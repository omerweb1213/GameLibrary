<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProducerGridView.aspx.cs" Inherits="ProducerGridView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            text-decoration: underline;
            font-size: medium;
            color: #FF0000;
        }
        .style2
        {
            font-size: medium;
            color: #FF0000;
        }
    </style>
</head>
<body background="ProducerListPhoto.jpg" style="background-repeat:no-repeat;">>
    <form id="form1" runat="server">
    <div>
        <a href="MainPage.aspx">Back to main page</a>
        <br />
        <br />
        <span class="style1">All current producers:<br />
        </span>
        <br />
        <br />
        <span class="style2">Search By:&nbsp;&nbsp; </span>&nbsp;<asp:DropDownList 
            ID="DropDownList1" runat="server" style="margin-bottom: 0px">
        </asp:DropDownList>
        <br />
        <br />
        <span class="style2">Text:&nbsp;&nbsp; </span>
        <asp:TextBox ID="TextSearch" runat="server" Height="25px" Width="170px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
        <br />
        <br />
    </div>
    <div>
    <asp:GridView ID="ProducersGridView" runat="server" AutoGenerateColumns="False" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" Height="452px" 
            onrowediting="ProducersGridView_RowEditing" Width="287px" 
            onrowdatabound="ProducersGridView_RowDataBound" 
            onrowdeleting="ProducersGridView_RowDeleting" 
            onrowupdating="ProducersGridView_RowUpdating" 
            onsorting="ProducersGridView_Sorting" AllowSorting="True" 
            onrowcancelingedit="ProducersGridView_RowCancelingEdit" 
            style="color: #FF0000">
        <Columns>
            <asp:BoundField DataField="ProducerID" HeaderText="ProducerID" 
                SortExpression="ProducerID" ReadOnly="True" />
            <asp:TemplateField HeaderText="ProducerName" SortExpression="ProducerName">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProducerName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProducerName") %>'></asp:Label>
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
    </div>
    </form>
</body>
</html>
