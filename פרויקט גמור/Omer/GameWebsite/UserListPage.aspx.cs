using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserListPage : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService();
    static WebService.Users[] UsersArr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) // אם זו עלייה ראשונה של הדף
        {
            UsersArr = ws.GetAllUsers();
            for (int i = 0; i < 8; i++)
            {
                DropDownList1.Items.Add(UserGridView.Columns[i].HeaderText);
            }
            PopulateGrid(UsersArr.OrderBy(x => x.UserID));
        }
    }

    protected void PopulateGrid(object obj)
    {
        UserGridView.DataSource = obj;
        UserGridView.DataBind();
    }
    protected void UserGridView_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression == "UserID")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.UserID));
        }
        if (e.SortExpression == "UserName")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.UserName));
        }
        if (e.SortExpression == "UserPass")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.UserPass));
        }
        if (e.SortExpression == "Fname")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.Fname));
        }
        if (e.SortExpression == "Lname")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.Lname));
        }
        if (e.SortExpression == "CardNum")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.CardNum));
        }
        if (e.SortExpression == "Email")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.Email));
        }
        if (e.SortExpression == "BirthDate")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.BirthDate));
        }
        if (e.SortExpression == "picpath")
        {
            PopulateGrid(UsersArr.OrderBy(x => x.picpath));
        }
    }
    protected void UsersGridView_(object sender, GridViewEditEventArgs e)
    {

    }
    protected void UsersGridView_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void UserGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void Search()
    {
        if (DropDownList1.SelectedValue == "User ID")
        {
            PopulateGrid(UsersArr.Where(x => x.UserID.Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "UserName")
        {
            PopulateGrid(UsersArr.Where(x => x.UserName.Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "PassWord")
        {
            PopulateGrid(UsersArr.Where(x => x.UserPass.Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "First Name")
        {
            PopulateGrid(UsersArr.Where(x => x.Fname.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Last Name")
        {
            PopulateGrid(UsersArr.Where(x => x.Lname.Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Credit Card ID")
        {
            PopulateGrid(UsersArr.Where(x => x.CardNum.ToString().Contains(TextSearch.Text)));
        }
        if (DropDownList1.SelectedValue == "Email")
        {
            PopulateGrid(UsersArr.Where(x => x.Email.Contains(TextSearch.Text)));
        }
        if (DropDownList1.SelectedValue == "BirthDate")
        {
            PopulateGrid(UsersArr.Where(x => x.BirthDate.ToString().Contains(TextSearch.Text)));
        }
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
    protected void UserGridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
        UserGridView.EditIndex = e.NewEditIndex;
        if (TextSearch.Text != "")
            Search();
        else 
        PopulateGrid(UsersArr.OrderBy(x => x.UserID));
    }
    protected void UserGridView_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = UserGridView.Rows[e.RowIndex];
        WebService.Users u1 = new WebService.Users();
        u1.UserID = row.Cells[0].Text;
        u1.UserName = ((TextBox)(row.Cells[1].FindControl("TextBox1"))).Text;
        u1.UserPass = ((TextBox)(row.Cells[2].FindControl("TextBox2"))).Text;
        u1.Fname = ((TextBox)(row.Cells[3].FindControl("TextBox3"))).Text;
        u1.Lname = ((TextBox)(row.Cells[4].FindControl("TextBox4"))).Text;
        u1.CardNum = int.Parse(((TextBox)(row.Cells[5].FindControl("TextBox5"))).Text);
        u1.Email = ((TextBox)(row.Cells[6].FindControl("TextBox6"))).Text;
        u1.BirthDate = DateTime.Parse("#" + ((TextBox)(row.Cells[7].FindControl("TextBox8"))).Text + "#");
        u1.picpath = ((TextBox)(row.Cells[8].FindControl("TextBox7"))).Text;
        ws.UpdateUsers(u1.UserID, u1.UserName, u1.UserPass, u1.BirthDate, u1.Fname, u1.Lname, u1.CardNum, u1.Email, u1.picpath);
        UserGridView.EditIndex = -1;
        UsersArr = ws.GetAllUsers();
        PopulateGrid(UsersArr.OrderBy(x => x.UserID));
    }
    protected void UserGridView_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
    {
        UserGridView.EditIndex = -1;
        PopulateGrid(UsersArr.OrderBy(x => x.UserID));
    }
    protected void UserGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = UserGridView.Rows[e.RowIndex];
        string UserID = row.Cells[0].Text;
        ws.DeleteUser(UserID);
        Response.Redirect("UserListPage.aspx");
    }
    protected void UserGridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowType != DataControlRowType.Header) && (e.Row.RowType != DataControlRowType.Footer) && (e.Row.RowType != DataControlRowType.Pager))
        {
            Button DeleteButton = ((Button)(e.Row.Cells[10].FindControl("DeleteButton")));
            DeleteButton.Attributes["onclick"] = "javascript: return confirm('Are you sure you want to delete " + DataBinder.Eval(e.Row.DataItem, "UserName") + "?')";
        }
    }
}