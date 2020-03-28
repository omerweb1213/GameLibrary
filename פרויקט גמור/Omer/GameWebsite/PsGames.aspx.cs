using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PsGames : System.Web.UI.Page
{
    WebService.WebService webs = new WebService.WebService();
    static WebService.Games[] GamesArr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GamesArr = webs.GetPsGames();
            PopulateGrid(GamesArr.OrderBy(x => x.GameName));
            Currency.Text = webs.GetTotalMoneyByUserID(((WebService.Users)(Session["u"])).UserID).ToString() + "$";
        }
    }

    protected void PopulateGrid(object obj)
    {
        PsDataList.DataSource = obj;
        PsDataList.DataBind();
    }

    protected void PsDataList_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataListItem item = PsDataList.Items[e.Item.ItemIndex];
        if (e.CommandName == "SelectItem")
        {
            int GameID = int.Parse(((Label)item.FindControl("GameID")).Text);
            string exname = ((Label)item.FindControl("GameName")).Text;
            int lblGamePrice = int.Parse(((Label)item.FindControl("lblGamePrice")).Text);
        }
    }

    protected void PsDataList_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
}