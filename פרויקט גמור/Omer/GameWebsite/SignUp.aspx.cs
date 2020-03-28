using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    WebService.WebService ws = new WebService.WebService();
    WebService.CreditCardTypes[] CreditCardTypes;
    int CreditCardCounter;
    protected bool CheckID()
    {
        return false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CreditCardTypes = ws.GetAllCreditCardTypes();
            CreditCardTypesDDL.DataSource = CreditCardTypes;
            CreditCardTypesDDL.DataTextField = "TypeName";
            CreditCardTypesDDL.DataValueField = "TypeID";
            CreditCardTypesDDL.DataBind();
        }

    }
    protected void SignUpButton_Click1(object sender, EventArgs e)
    {

    }
    protected void btnSavePic_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            Image1.ImageUrl = "images/" + FileUpload1.FileName;
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
    protected void SignUpButton_Click(object sender, EventArgs e)
    {
        CreditCardCounter = ws.AddCreditCard(CreditCardNum.Text, int.Parse(TotalMoney.Text), int.Parse(CVVCode.Text), int.Parse(CreditCardTypesDDL.SelectedValue));

        ws.AddUser(UserID.Text, UserName.Text, PassWord.Text, DateTime.Parse(BirthDate.Text), FirstName.Text, LastName.Text, CreditCardCounter, Email.Text, Image1.ImageUrl);

        Response.Redirect("Login.aspx");
    }
}