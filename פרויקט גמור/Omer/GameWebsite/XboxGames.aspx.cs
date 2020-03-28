using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class XboxGames : System.Web.UI.Page
{
    WebService.WebService webs = new WebService.WebService();
    static WebService.Games[] GamesArr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GamesArr = webs.GetXboxGames();
            PopulateGrid(GamesArr.OrderBy(x => x.GameName));
            Currency.Text = webs.GetTotalMoneyByUserID(((WebService.Users)(Session["u"])).UserID).ToString() + "$";
        }
    }

    protected void PopulateGrid(object obj)
    {
        XboxDataList.DataSource = obj;
        XboxDataList.DataBind();
    }

    protected void XboxDataList_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataListItem item = XboxDataList.Items[e.Item.ItemIndex];
        if (e.CommandName == "SelectItem")
        {
            string exname = ((Label)item.FindControl("GameName")).Text;
        }
    }

    protected void XboxDataList_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
}