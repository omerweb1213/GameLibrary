using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string db = "Database6.accdb";
        MyAdoHelperAccess.ConnectToDb(db);

        lists:

        List<Categories> categories = MyAdoHelperAccess.GetAllCategories();
        foreach (var item in categories)
        {
            Response.Write(item.ToString()+"<br>"); 
        }

        List<CreditCards> creditCards = MyAdoHelperAccess.GetAllCreditCards();
        foreach (var item in creditCards)
        {
            Response.Write(item.ToString() + "<br>");
        }

        List<CreditCardTypes> creditCardTypes = MyAdoHelperAccess.GetAllCreditCardTypes();
        foreach (var item in creditCardTypes)
        {
            Response.Write(item.ToString() + "<br>");
        }

        //List<Games> games = MyAdoHelperAccess.GetAllGames();
        //foreach (var item in games)
        //{
        //    Response.Write(item.ToString() + "<br>");
        //}

        List<Orders> orders = MyAdoHelperAccess.GetAllOrders();
        foreach (var item in orders)
        {
            Response.Write(item.ToString() + "<br>");
        }

        List<Producers> producers = MyAdoHelperAccess.GetAllProducers();
        foreach (var item in producers)
        {
            Response.Write(item.ToString() + "<br>");
        }

        List<Users> users = MyAdoHelperAccess.GetAllUsers();
        foreach (var item in users)
        {
            Response.Write(item.ToString() + "<br>");
        }

        --------------------------------------------------------------------------------------------------------------

        Users u = new Users("", "", DateTime.Today, "", "", 1111);
        MyAdoHelperAccess.AddUser(u);

        Categories c = new Categories("fhf");
        int id = MyAdoHelperAccess.AddCategory(c);
        c.CategoryID = id;

        Categories c = MyAdoHelperAccess.GetCategoryById(1);
        Response.Write(c.ToString());

        Response.Write(" ");

        CreditCards cc = MyAdoHelperAccess.GetCreditCardByCreditCounter(1);
        Response.Write(cc.ToString());

        Response.Write(" ");

        CreditCardTypes cct = MyAdoHelperAccess.GetCreditCardTypeByTypeID(1);
        Response.Write(cct.ToString());

        Response.Write(" ");

        Games g = MyAdoHelperAccess.GetGameByID(13);
        Response.Write(g.ToString());

        Response.Write(" ");

       Orders o = MyAdoHelperAccess.GetOrderByID(17);
       Response.Write(o.ToString());

        Producers p = MyAdoHelperAccess.GetProducerByID(9);
        Response.Write(p.ToString());

        Users u = MyAdoHelperAccess.GetUserByID("138460925");
        Response.Write(u.ToString());

        ----------------------------------------------------------------------------------------------------------------------------------

        Categories c = new Categories(13, "omer");
        MyAdoHelperAccess.UpdateCategories(c);

        CreditCards cc = new CreditCards(4, "1234561234561234", 5000, DateTime.Today , 663, 8);
        MyAdoHelperAccess.UpdateCreditCards(cc);

        CreditCardTypes cct = new CreditCardTypes(13, "DISCOVER");
        MyAdoHelperAccess.UpdateCreditCardType(cct);

        Games g = new Games(13, "PUBG", 30, 1400, DateTime.Today, 1, 9);
        MyAdoHelperAccess.UpdateGames(g);

        Orders o = new Orders(17, DateTime.Today, "205476531", 13);
        MyAdoHelperAccess.UpdateOrders(o);

        Producers p = new Producers(9, "Bluehole");
        MyAdoHelperAccess.UpdateProducers(p);

        Users u = new Users("138460925", "UserName2","11223345",DateTime.Today,"first","last",2);
        MyAdoHelperAccess.UpdateUsers(u);

        -----------------------------------------------------

        string sql = "select * from tbl_Categories";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        string sql = "select * from tbl_CreditCards";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        string sql = "select * from tbl_CreditCardType";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        string sql = "select * from tbl_Games";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        string sql = "select * from tbl_Orders";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        string sql = "select * from tbl_Producers";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);
 
        string sql = "select * from tbl_Users";
        string str = MyAdoHelperAccess.printDataTable(db, sql);
        Response.Write(str);

        --------------------------------------------------------------------------------------------------------------------

        string ir = "Fantasy";
        string sql2 = "insert into tbl_Categories (CategoryName) values ('" + ir + "')";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Category added");

        string CardNumber = "1122334455667788";
        int TotalMoney = 5000;
        DateTime ExpireDate = DateTime.Parse("10/7/2017");
        int CvvCode = 493;
        string TypeID = "3";
        string sql2 = "insert into tbl_CreditCards (CardNumber , TotalMoney , ExpireDate , CVVCode , TypeID) values ('" + CardNumber + "' , " + TotalMoney + " ,#" + ExpireDate + "#," + CvvCode + " , '" +TypeID+"')";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Credit Card added");

        string TypeName = "DISCOVER";
        string sql2 = "insert into tbl_CreditCardType (TypeName) values ('" + TypeName + "')";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Credit card type added");

        string GameName = "OVERWATCH";
        int GamePrice = 40;
        int GameCount = 300;
        DateTime ReleaseDate = DateTime.Parse("24/5/2016");
        int CategoryID = 1;
        int ProducerID = 10;
        string sql2 = "insert into tbl_Games (GameName , GamePrice , GameCount , GameReleaseDate , GameCategoryID , GameProducerID) values ('" + GameName + "' , " + GamePrice + " , " + GameCount + " , #" + ReleaseDate + "# ," + CategoryID + " , " + ProducerID + ")";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Game added");

        DateTime OrderDate = DateTime.Parse("30 / 10 / 2017");
        string UserID = "205476531";
        int GameID = 13;
        //string sql2 = "insert into tbl_Orders (OrderDate , UserID , GameID) values (#" + OrderDate + "# , '" + UserID + "' , " + GameID + ")";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Order added");

        string ProducerName = "EA";
        string sql2 = "insert into tbl_Producers (ProducerName) values ('" + ProducerName + "')";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("Producer added");

        string UserID = "55555555";
        string UserName = "User17";
        string Password = "Password17";
        DateTime BirthDate = DateTime.Parse("9/1/1990");
        string Firstname = "Fname";
        string LastName = "Lname";
        int CreditNumber = 4;
        string sql2 = "insert into tbl_Users (UserID , UserName , UserPass , BirthDate , FirstName , LastName , CreditNum) values ('" + UserID + "' , '" + UserName + "' , '" + Password + "','" + BirthDate + "' , '" + Firstname + "','" + LastName + "','" + CreditNumber + "')";
        MyAdoHelperAccess.DoQuery(db, sql2);
        Response.Write("User added");




        int CategoryID = 12;
        string CategoryName = "Fantasy";
        string sql3 = "update tbl_Categories set CategoryName ='" + CategoryName + "' where CategoryID = " + CategoryID + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Category updated");

        int CreditCounter = 1;
        string CardNumber = "1231231231231231";
        string sql3 = "update tbl_CreditCards set CardNumber = '" + CardNumber + "' where CreditCounter = " + CreditCounter + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Credit card updated");

        int TypeID = 13;
        string TypeName = "Discover";
        string sql3 = "update tbl_CreditCardType set TypeName = '" + TypeName + "' where TypeID = " + TypeID + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Credit card type updated");

        int GameID = 15;
        int GameCount = 1000;
        string sql3 = "update tbl_Games set GameCount = " + GameCount + " where GameID = " + GameID + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Game count updated");

        int OrderID = 17;
        int GameID = 15;
        string sql3 = "update tbl_Orders set GameID = " + GameID + " where OrderID = " + OrderID + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("The Game that was ordered has been changed");

        int ProducerID = 13;
        string ProducerName = "EA";
        string sql3 = "update tbl_Producers set ProducerName ='" + ProducerName + "' where ProducerID = " + ProducerID + "";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Producer name changed");

        string UserID = "55555555";
        string UserName = "NewUserName";
        string sql3 = "update tbl_Users set UserName = '" + UserName + "' where UserID = '" + UserID + "'";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Username changed");

        string UserID = "55555555";
        string UserPass = "NewUserPass";
        string sql3 = "update tbl_Users set UserPass = '" + UserPass + "' where UserID = '" + UserID + "'";
        MyAdoHelperAccess.DoQuery(db, sql3);
        Response.Write("Password changed");
    }
}