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
    int ProducerID;
    static WebService.Producers[] ProducersArr;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ProducersArr = ws.GetAllProducers();
            ProducersDDL.DataSource = ProducersArr;
            ProducersDDL.DataTextField = "ProducerName";
            ProducersDDL.DataValueField = "ProducerID";
            ProducersDDL.DataBind();
        }
       // object ProducerName = 
    }

    protected void AddGameButton_Click(object sender, EventArgs e)
    {
        ProducerID = int.Parse(ProducersDDL.SelectedValue);
        
        ws.AddGame(GameName.Text, int.Parse(Price.Text), int.Parse(Count.Text), DateTime.Parse(ReleaseDate.Text),  Categories.SelectedIndex + 1, ProducerID, GamePhoto.ImageUrl, Consoles.SelectedValue);

        Response.Redirect("MainPage.aspx");

    }

    protected void btnSavePic_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            GamePhoto.ImageUrl = "images/" + FileUpload1.FileName;
            SaveFile(FileUpload1.PostedFile);
        }
    }

    void SaveFile(HttpPostedFile file)
    {
        string savePath = HttpContext.Current.Server.MapPath("images/");
        string fileName = FileUpload1.FileName;
        savePath += fileName;
        FileUpload1.SaveAs(savePath);
    }

    protected void ProducersDDL_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}