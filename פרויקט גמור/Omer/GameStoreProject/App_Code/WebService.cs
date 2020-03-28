using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public Categories GetCategoryById(int CategoryID)
    {
        return MyAdoHelperAccess.GetCategoryById(CategoryID);
    }

    [WebMethod]
    public CreditCards GetCreditCardByCreditCounter(int CreditCounter)
    {
        return MyAdoHelperAccess.GetCreditCardByCreditCounter(CreditCounter);
    }

    [WebMethod]
    public CreditCardTypes GetCreditCardTypeByTypeID(int TypeID)
    {
        return MyAdoHelperAccess.GetCreditCardTypeByTypeID(TypeID);
    }

    [WebMethod]
    public Games GetGameByID(int GameID)
    {
        return MyAdoHelperAccess.GetGameByID(GameID);
    }

    [WebMethod]
    public Orders GetOrderByID(int OrderID)
    {
        return MyAdoHelperAccess.GetOrderByID(OrderID);
    }

    [WebMethod]
    public Producers GetProducerByID(int ProducerID)
    {
        return MyAdoHelperAccess.GetProducerByID(ProducerID);
    }

    [WebMethod]
    public Users GetUserByID(string UserID)
    {
        return MyAdoHelperAccess.GetUserByID(UserID);
    }

    [WebMethod]
    public Users Login(string UserName, string UserPass)
    {
        return MyAdoHelperAccess.Login(UserName, UserPass);
    }

    [WebMethod]
    public double GetTotalMoneyByUserID(string UserID)
    { 
        return MyAdoHelperAccess.GetTotalMoneyByUserID(UserID);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    [WebMethod]
    public int AddCategory(string CategoryName)
    {
        Categories c = new Categories(CategoryName);
        return MyAdoHelperAccess.AddCategory(c);
    }

    [WebMethod]
    public int AddCreditCard(string CardNumber, int TotalMoney, int CVVCode, int TypeID)
    {
        CreditCards cc = new CreditCards(CardNumber, TotalMoney, DateTime.Today, CVVCode, TypeID);
        return MyAdoHelperAccess.AddCreditCard(cc);
    }

    [WebMethod]
    public int AddCreditCardType(string TypeName)
    {
        CreditCardTypes cct = new CreditCardTypes(TypeName);
        return MyAdoHelperAccess.AddCreditCardType(cct);
    }

    [WebMethod]
    public int AddGame(string GameName, int GamePrice, int GameCount, DateTime GameReleaseDate, int GameCategoryID, int GameProducerID, string GamePicPath, string GameConsole)
    {
        Games g = new Games(GameName, GamePrice, GameCount, GameReleaseDate, GameCategoryID, GameProducerID, GamePicPath, GameConsole);
        return MyAdoHelperAccess.AddGame(g);
    }

    [WebMethod]
    public int AddOrder(string UserID , int GameID)
    {
        Orders o = new Orders(DateTime.Today, UserID, GameID);
        return MyAdoHelperAccess.AddOrder(o);
    }

    [WebMethod]
    public int AddProducer(string ProducerName)
    {
        Producers p = new Producers(ProducerName);
        return MyAdoHelperAccess.AddProducer(p);
    }

    [WebMethod]
     public void AddUser(string UserID , string UserName, string UserPass, DateTime BirthDate, string Fname, string Lname, int CreditNum , string Email, string pic)
    {
        Users u = new Users(UserID, UserName, UserPass, BirthDate, Fname, Lname, CreditNum, Email, pic, false);
        MyAdoHelperAccess.AddUser(u);

    }


    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     
    [WebMethod]
    public void UpdateCategory(int CategoryID , string CategoryName)
    {
        Categories c = new Categories(CategoryID , CategoryName);
        MyAdoHelperAccess.UpdateCategories(c);
    }

    [WebMethod]
    public void UpdateCreditCards(int CreditCounter, string CardNumber, int TotalMoney, int CVVCode, int TypeID)
    {
        CreditCards cc = new CreditCards(CreditCounter, CardNumber, TotalMoney, DateTime.Today, CVVCode, TypeID);
        MyAdoHelperAccess.UpdateCreditCards(cc);
    }

    [WebMethod]
    public void UpdateCreditCardType(int TypeID , string TypeName)
    {
        CreditCardTypes cct = new CreditCardTypes(TypeID , TypeName);
        MyAdoHelperAccess.UpdateCreditCardType(cct);
    }

    [WebMethod]
    public void UpdateGames(int GameID, string GameName, int GamePrice, int GameCount, DateTime GameReleaseDate, int GameCategoryID, int GameProducerID , string GamePicPath , string GameConsole)
    {
        Games g = new Games(GameID, GameName, GamePrice, GameCount, GameReleaseDate, GameCategoryID, GameProducerID , GamePicPath , GameConsole);
        MyAdoHelperAccess.UpdateGames(g);
    }

    [WebMethod]
    public void UpdateOrders(int OrderID, string UserID, int GameID)
    {
        Orders o = new Orders(OrderID, DateTime.Today, UserID, GameID);
        MyAdoHelperAccess.UpdateOrders(o);
    }

    [WebMethod]
    public void UpdateProducers(int ProducerID, string ProducerName)
    {
        Producers p = new Producers(ProducerID, ProducerName);
        MyAdoHelperAccess.UpdateProducers(p);
    }

    [WebMethod]
    public void UpdateUsers(string UserID, string UserName, string UserPass, DateTime BirthDate, string Fname, string Lname, int CreditNum , string Email , string picpath)
    {
        Users u = new Users(UserID, UserName, UserPass, BirthDate, Fname, Lname, CreditNum, Email, picpath, false);
        MyAdoHelperAccess.UpdateUsers(u);
    }

    [WebMethod]
    public void DeleteUser(string UserID)
    {
        MyAdoHelperAccess.DeleteUser(UserID);
    }

    [WebMethod]
    public void DeleteGame(int GameID)
    {
        MyAdoHelperAccess.DeleteGame(GameID);
    }

    [WebMethod]
    public void DeleteProducer(int ProducerID)
    {
        MyAdoHelperAccess.DeleteProducer(ProducerID);
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    [WebMethod]
    public List<Categories> GetAllCategories()
    {
        return MyAdoHelperAccess.GetAllCategories();
    }

    [WebMethod]
    public List<CreditCards> GetAllCreditCards()
    {
        return MyAdoHelperAccess.GetAllCreditCards();
    }

    [WebMethod]
    public List<CreditCardTypes> GetAllCreditCardTypes()
    {
        return MyAdoHelperAccess.GetAllCreditCardTypes();
    }

    [WebMethod]
    public List<Games> GetAllGames()
    {
        return MyAdoHelperAccess.GetAllGames();
    }

    [WebMethod]
    public List<Orders> GetAllOrders()
    {
        return MyAdoHelperAccess.GetAllOrders();
    }

    [WebMethod]
    public List<Producers> GetAllProducers()
    {
        return MyAdoHelperAccess.GetAllProducers();
    }

    [WebMethod]
    public List<Users> GetAllUsers()
    {
        return MyAdoHelperAccess.GetAllUsers();
    }

    [WebMethod]
    public List<Games> GetPcGames()
    {
        return MyAdoHelperAccess.GetPcGames();
    }

    [WebMethod]
    public List<Games> GetPsGames()
    {
        return MyAdoHelperAccess.GetPsGames();
    }

    [WebMethod]
    public List<Games> GetXboxGames()
    {
        return MyAdoHelperAccess.GetXboxGames();
    }

    //[WebMethod]
    //public static photo GetPic(int ID)
    //{
    //    string sql = "select * from tbl_photos where ID = " + ID;
                
    //}
}

