using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GameAddPage : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService();
    static WebService.Games[] GamesArr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GamesArr = ws.GetAllGames();
            for (int i = 0; i < 7; i++)
			{
                DropDownList1.Items.Add(GamesGridView.Columns[i].HeaderText);
			}
            PopulateGrid(GamesArr.OrderBy(x => x.GameID));
        }
    }

    protected void PopulateGrid(object obj)
    {
        GamesGridView.DataSource = obj;
        GamesGridView.DataBind();
    }

    protected void GamesGridView_Sorting(object sender, GridViewSortEventArgs e)
    {
        if (e.SortExpression == "GameID")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameID));
        }
        if (e.SortExpression == "GameName")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameName));
        }
        if (e.SortExpression == "GamePrice")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GamePrice));
        }
        if (e.SortExpression == "GameCount")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameCount));
        }
        if (e.SortExpression == "GameReleaseDate")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameReleaseDate));
        }
        if (e.SortExpression == "GameCategoryID")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameCategoryID));
        }
        if (e.SortExpression == "GameProducerID")
        {
            PopulateGrid(GamesArr.OrderBy(x => x.GameProducerID));
        }
    }

    protected void GamesGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void GamesGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GamesGridView.EditIndex = -1;
        PopulateGrid(GamesArr.OrderBy(x => x.GameID));
    }
    protected void Search()
    {
        if (DropDownList1.SelectedValue == "Game Name")
        {
            PopulateGrid(GamesArr.Where(x => x.GameName.Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Game ID")
        {
            PopulateGrid(GamesArr.Where(x => x.GameID.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Game Price")
        {
            PopulateGrid(GamesArr.Where(x => x.GamePrice.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Game Count")
        {
            PopulateGrid(GamesArr.Where(x => x.GameCount.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Game Category ID")
        {
            PopulateGrid(GamesArr.Where(x => x.GameCategoryID.ToString().Contains(TextSearch.Text)));
        }

        if (DropDownList1.SelectedValue == "Game Producer ID")
        {
            PopulateGrid(GamesArr.Where(x => x.GameProducerID.ToString().Contains(TextSearch.Text)));
        }
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        Search();
    }
    protected void GamesGridView_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GamesGridView.EditIndex = e.NewEditIndex;
        if (TextSearch.Text != "")
            Search();
        else
            PopulateGrid(GamesArr.OrderBy(x => x.GameID));
    }
    protected void GamesGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GamesGridView.Rows[e.RowIndex];
        WebService.Games g1 = new WebService.Games();
        g1.GameID = int.Parse(row.Cells[0].Text);
        g1.GameName = ((TextBox)(row.Cells[1].FindControl("TextBox1"))).Text;
        g1.GamePrice = int.Parse(((TextBox)(row.Cells[2].FindControl("TextBox2"))).Text);
        g1.GameCount = int.Parse(((TextBox)(row.Cells[3].FindControl("TextBox3"))).Text);
        g1.GameReleaseDate = DateTime.Parse("#" + ((TextBox)(row.Cells[4].FindControl("TextBox4"))).Text + "#");
        g1.GameCategoryID = int.Parse(((TextBox)(row.Cells[5].FindControl("TextBox5"))).Text);
        g1.GameProducerID = int.Parse(((TextBox)(row.Cells[6].FindControl("TextBox6"))).Text);
        g1.GamePicPath = ((TextBox)(row.Cells[7].FindControl("TextBox7"))).Text;
        g1.GameConsole = ((TextBox)(row.Cells[8].FindControl("TextBox8"))).Text;
        ws.UpdateGames(g1.GameID, g1.GameName, g1.GamePrice, g1.GameCount, g1.GameReleaseDate, g1.GameCategoryID, g1.GameProducerID, g1.GamePicPath , g1.GameConsole);
        GamesGridView.EditIndex = -1;
        GamesArr = ws.GetAllGames();
        PopulateGrid(GamesArr.OrderBy(x => x.GameID));
    }
    protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow row = GamesGridView.Rows[e.RowIndex];
        int GameID = int.Parse(row.Cells[0].Text);
        ws.DeleteGame(GameID);
        GamesGridView.EditIndex = -1;
        GamesArr = ws.GetAllGames();
        PopulateGrid(GamesArr.OrderBy(x => x.GameID));
    }
    protected void GamesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if ((e.Row.RowType != DataControlRowType.Header) && (e.Row.RowType != DataControlRowType.Footer) && (e.Row.RowType != DataControlRowType.Pager))
        {
            Button DeleteButton = ((Button)(e.Row.Cells[9].FindControl("DeleteButton")));
            DeleteButton.Attributes["onclick"] = "javascript: return confirm('Are you sure you want to delete " + DataBinder.Eval(e.Row.DataItem, "GameName") + "?')";
        }
    }
}