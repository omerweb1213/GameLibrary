using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService(); // יצירת מופע של שירות הרשת
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        WebService.Users u = ws.Login(UserName.Text, Userpass.Text);
        Session["u"] = u;

        if (u != null)
        {
            Response.Write(u.Fname);
            Response.Redirect("MainPage.aspx");
        }

        else
            ErrorSummary.InnerHtml = "wrong username or password";
    }
}