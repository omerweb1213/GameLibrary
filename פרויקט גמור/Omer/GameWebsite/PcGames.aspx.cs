using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PcGames : System.Web.UI.Page
{
    WebService.WebService webs = new WebService.WebService();
    static WebService.Games[] GamesArr;
    static ShoppingCart SalKniyot;
    static ProductInBag[] ProductsArr = new ProductInBag[1];

    protected void Page_Load(object sender, EventArgs e)
    {
        GvShoppingCart.Visible = true;

        if (SalKniyot == null)//אם אין מוצרים בסל
            SalKniyot = new ShoppingCart();
           
        
        if (!IsPostBack)
        {
            //ProductsArr[0] = new ProductInBag(100, "miri", 25);
            //PopulateSalKniyot(ProductsArr);

           
            
            //SalKniyot.AddToList(new ProductInBag(100, "miri", 25));
            //SalKniyot.AddToList(new ProductInBag(101, "omer", 45));
            //PopulateSalKniyot(SalKniyot.ProductList.ToArray());

            GamesArr = webs.GetPcGames();
            PopulateGrid(GamesArr.OrderBy(x => x.GameName));
            Currency.Text = webs.GetTotalMoneyByUserID(((WebService.Users)(Session["u"])).UserID).ToString() + "$";
        }
    }

    protected void PopulateSalKniyot(object obj)
    {
        GvShoppingCart.DataSource = obj;
        GvShoppingCart.DataBind();
    }

    protected void PopulateGrid(object obj)
    {
        PcDataList.DataSource = obj;
        PcDataList.DataBind();
    }

    protected void PcDataList_ItemCommand(object source, DataListCommandEventArgs e)
    {
        DataListItem item = PcDataList.Items[e.Item.ItemIndex];
        if (e.CommandName == "SelectItem")
        {
            int GameID = int.Parse(((Label)item.FindControl("GameID")).Text);
            string exname = ((Label)item.FindControl("GameName")).Text;
            int lblGamePrice = int.Parse(((Label)item.FindControl("lblGamePrice")).Text);
            ProductInBag p = new ProductInBag(GameID, exname, lblGamePrice);//בניית שורה בסל קניות
            SalKniyot.AddToList(p);//הוספת השורה לסל הקניות
            PopulateSalKniyot(SalKniyot.ProductList.ToArray());
   
        }
    }

    protected void PcDataList_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        
    }
    protected void GvShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}