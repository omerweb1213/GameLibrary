using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AllGames : System.Web.UI.Page
{
    WebService.WebService webs = new WebService.WebService();
    static WebService.Games[] GamesArr;
    protected void Page_Load(object sender, EventArgs e)
    {
        GamesArr = webs.GetAllGames();
        PopulateGrid(GamesArr.OrderBy(x => x.GameName));
    }

    protected void PopulateGrid(object obj)
    {
        PcDataList.DataSource = obj;
        PcDataList.DataBind();
    }

    protected void PcDataList_ItemDataBound(object sender, DataListItemEventArgs e)
    {

    }
}