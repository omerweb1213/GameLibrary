using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Currency.Text = ws.GetTotalMoneyByUserID(((WebService.Users)(Session["u"])).UserID).ToString() + "$";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}