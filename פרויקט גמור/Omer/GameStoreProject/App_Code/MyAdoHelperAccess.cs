using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Collections.Generic;

/// <summary>
/// Summary description for MyAdoHelper
/// פעולות עזר לשימוש במסד נתונים מסוג אקסס
///  App_Data המסד ממוקם בתקיה 
/// </summary>

public class MyAdoHelperAccess
{
    static string db = "Database6.accdb";
    
    public MyAdoHelperAccess()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static OleDbConnection ConnectToDb(string fileName)
    {
        string path = HttpContext.Current.Server.MapPath("App_Data/");//מיקום מסד בפורוייקט
        path += fileName;
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + path;//נתוני ההתחברות הכוללים מיקום וסוג המסד
        OleDbConnection conn = new OleDbConnection(connString);
        return conn;
    }

    public static void  DoQuery(string fileName, string sql)//הפעולה מקבלת שם מסד נתונים ומחרוזת מחיקה/ הוספה/ עדכון
    //ומבצעת את הפקודה על המסד הפיזי
    {
        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
      
    }


    /// <summary>
    /// To Execute update / insert / delete queries
    ///  הפעולה מקבלת שם קובץ ומשפט לביצוע ומחזירה את מספר השורות שהושפעו מביצוע הפעולה
    /// </summary>
    public int RowsAffected(string fileName, string sql)//הפעולה מקבלת מסלול מסד נתונים ופקודת עדכון
    //ומבצעת את הפקודה על המסד הפיזי
    {

        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        int rowsA = com.ExecuteNonQuery();
        conn.Close();
        return rowsA;
    }

    /// <summary>
    /// הפעולה מקבלת שם קובץ ומשפט לחיפוש ערך - מחזירה אמת אם הערך נמצא ושקר אחרת
    /// </summary>
    public static bool IsExist(string fileName, string sql)//הפעולה מקבלת שם קובץ ומשפט בחירת נתון ומחזירה אמת אם הנתונים קיימים ושקר אחרת
    {

        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        OleDbDataReader data = com.ExecuteReader();
        bool found;
        found=(bool) data.Read();// אם יש נתונים לקריאה יושם אמת אחרת שקר - הערך קיים במסד הנתונים
        conn.Close();
        return found;

    }
   

    public static DataTable ExecuteDataTable(string fileName, string sql)
    { // פעולה המקבלת מסד נתונים ושאילתת - מפעילה את השאילתה ומחזירה את התוצאה בטבלה
        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbDataAdapter tableAdapter = new OleDbDataAdapter(sql,conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        return dt;
    }

    public static int ExecuteScalar(string fileName, string sql)
    { // פעולה המקבלת מסד נתונים ושאילתת - מפעילה את השאילתה ומחזירה את התוצאה בתור מספר
        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbCommand com = new OleDbCommand(sql, conn);
        return  (int)com.ExecuteScalar();
    }



    public void ExecuteNonQuery(string fileName, string sql)
    {
        OleDbConnection conn = ConnectToDb(fileName);
        conn.Open();
        OleDbCommand command = new OleDbCommand(sql, conn);
        command.ExecuteNonQuery();
        conn.Close();
    }


    public static string printDataTable(string fileName, string sql)
    {    // הפעולה המקבלת מסד נתונים ושאילתה
        // HTML הפעולה מחזירה מחרוזת השומרת את הטבלה בתור
        DataTable dt = ExecuteDataTable(fileName, sql);
       
        string printStr = "<table border='1'>";
        
        foreach (DataRow row in dt.Rows)
        {
            printStr += "<tr>";
            foreach (object myItemArray in row.ItemArray)
            {

                printStr += "<td>" + myItemArray.ToString() +"</td>";
            }
            printStr += "</tr>";
        }
        printStr += "</table>";
        
        return printStr;
    }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public static Categories GetCategoryById(int CategoryID)
    {
        string sql = "select * from tbl_Categories where CategoryID =" + CategoryID;
        DataTable dtCategroies = new DataTable();
        dtCategroies = ExecuteDataTable(db, sql);
        DataRow dr = dtCategroies.Rows[0];
        return new Categories(int.Parse(dr["CategoryID"].ToString()), dr["CategoryName"].ToString());
    }


    public static CreditCards GetCreditCardByCreditCounter(int CreditCounter)
    {
        string sql = "select * from tbl_CreditCards where CreditCounter =" + CreditCounter;
        DataTable dtCredit = new DataTable();
        dtCredit = ExecuteDataTable(db, sql);
        DataRow dr = dtCredit.Rows[0];
        return new CreditCards(int.Parse(dr["CreditCounter"].ToString()), dr["CardNumber"].ToString(), int.Parse(dr["TotalMoney"].ToString()), DateTime.Parse(dr["ExpireDate"].ToString()), int.Parse(dr["CVVCode"].ToString()), int.Parse(dr["TypeID"].ToString()));
    }

    public static CreditCardTypes GetCreditCardTypeByTypeID(int TypeID)
    {
        string sql = "select * from tbl_CreditCardType where TypeID =" + TypeID;
        DataTable dtCreditType = new DataTable();
        dtCreditType = ExecuteDataTable(db, sql);
        DataRow dr = dtCreditType.Rows[0];
        return new CreditCardTypes(int.Parse(dr["TypeID"].ToString()), dr["TypeName"].ToString());
    }

    public static Games GetGameByID(int GameID)
    {
        string sql = "select * from tbl_Games where GameID =" + GameID;
        DataTable dtGames = new DataTable();
        dtGames = ExecuteDataTable(db, sql);
        DataRow dr = dtGames.Rows[0];
        return new Games(int.Parse(dr["GameID"].ToString()) , dr["GameName"].ToString() , int.Parse(dr["GamePrice"].ToString()) , int.Parse(dr["GameCount"].ToString()) , DateTime.Parse(dr["GameReleaseDate"].ToString()) , int.Parse(dr["GameCategoryID"].ToString()) , int.Parse(dr["GameProducerID"].ToString()) , dr["GamePicturePath"].ToString() , dr["GameConsole"].ToString());
    }

    public static Orders GetOrderByID(int OrderID)
    {
        string sql = "select * from tbl_Orders where OrderID =" + OrderID;
        DataTable dtOrders = new DataTable();
        dtOrders = ExecuteDataTable(db, sql);
        DataRow dr = dtOrders.Rows[0];
        return new Orders(int.Parse(dr["OrderID"].ToString()), DateTime.Parse(dr["OrderDate"].ToString()), dr["UserID"].ToString(), int.Parse(dr["GameID"].ToString()));
    }

    public static Producers GetProducerByID(int ProducerID)
    {
        string sql = "select * from tbl_Producers where ProducerID =" + ProducerID;
        DataTable dtProducers = new DataTable();
        dtProducers = ExecuteDataTable(db, sql);
        DataRow dr = dtProducers.Rows[0];
        return new Producers(int.Parse(dr["ProducerID"].ToString()), dr["ProducerName"].ToString());
    }

    public static Users GetUserByID(string UserID)
    {
        string sql = "select * from tbl_Users where UserID ='" + UserID+"'";
        DataTable dtUsers = new DataTable();
        dtUsers = ExecuteDataTable(db, sql);
        DataRow dr = dtUsers.Rows[0];
        return new Users(dr["UserID"].ToString(), dr["UserName"].ToString(), dr["UserPass"].ToString(), DateTime.Parse(dr["BirthDate"].ToString()), dr["FirstName"].ToString(), dr["LastName"].ToString(), int.Parse(dr["CreditNum"].ToString()), dr["Email"].ToString());
    }

    public static Users Login(string UserName, string UserPass)
    {
        string sql = "SELECT * FROM tbl_Users WHERE UserName='" + UserName + "' And UserPass= '" + UserPass + "'";
        DataTable dtUsers = new DataTable();
        dtUsers = ExecuteDataTable(db, sql);

        if (dtUsers.Rows.Count == 0)
        {
            return null;
        }
        else
        {
            DataRow dr = dtUsers.Rows[0];
            return new Users(dr["UserID"].ToString(), dr["UserName"].ToString(), dr["UserPass"].ToString(), DateTime.Parse(dr["BirthDate"].ToString()), dr["FirstName"].ToString(), dr["LastName"].ToString(), int.Parse(dr["CreditNum"].ToString()), dr["Email"].ToString(), dr["PicturePath"].ToString(), bool.Parse(dr["IsAdmin"].ToString()));
        }
    }

    public static int GetTotalMoneyByUserID(string UserID) 
    {
        string sql = "SELECT TotalMoney FROM tbl_CreditCards INNER JOIN tbl_Users ON tbl_CreditCards.CreditCounter = tbl_Users.CreditNum where UserID = '" + UserID + "'";
        return ExecuteScalar(db, sql);
    }

    
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------   
    public static int AddCategory(Categories c)
    {
        int id;
        string sql = "insert into tbl_Categories (CategoryName) values ('" + c.CategoryName + "')";
        DoQuery(db, sql);
        sql = "select max(CategoryID) from tbl_Categories";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static int AddCreditCard(CreditCards credit)
    {
        int id;
        string sql = "insert into tbl_CreditCards (CardNumber , TotalMoney , ExpireDate , CVVCode , TypeID) values ('" + credit.CardNumber + "' , " + credit.TotalMoney + " ,#" + credit.ExpireDate + "#," + credit.CvvCode + " , " + credit.TypeID + ")";
        DoQuery(db, sql);
        sql = "select max(CreditCounter) from tbl_CreditCards";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static int AddCreditCardType(CreditCardTypes CreditType)
    {
        int id;
        string sql = "insert into tbl_CreditCardType (TypeName) values ('" + CreditType.TypeName + "')";
        DoQuery(db, sql);
        sql = "select max(TypeID) from tbl_CreditCardType";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static int AddGame(Games g)
    {
        int id;
        string sql = "insert into tbl_Games (GameName , GamePrice , GameCount , GameReleaseDate , GameCategoryID , GameProducerID , GamePicturePath , GameConsole , IsActive) values ('" + g.GameName + "' , " + g.GamePrice + " , " + g.GameCount + " , #" + g.GameReleaseDate + "# ," + g.GameCategoryID + " , " + g.GameProducerID + " , '" + g.GamePicPath + "' , '"+g.GameConsole+"' , true)";
        DoQuery(db, sql);
        sql = "select max(GameID) from tbl_Games";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static int AddOrder(Orders o)
    {
        int id;
        string sql = "insert into tbl_Orders (OrderDate , UserID , GameID) values (#" + o.OrderDate + "# , '" + o.UserID + "' , " + o.GameID + ")";
        DoQuery(db, sql);
        sql = "select max(OrderID) from tbl_Orders";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static int AddProducer(Producers p)
    {
        int id;
        string sql = "insert into tbl_Producers (ProducerName) values ('" + p.ProducerName + "')";
        DoQuery(db, sql);
        sql = "select max(ProducerID) from tbl_Producers";
        DataTable dt = ExecuteDataTable(db, sql);
        id = int.Parse(dt.Rows[0][0].ToString());
        return id;
    }

    public static void AddUser(Users u)
    {
        string sql = "INSERT INTO tbl_Users (UserID, UserName, UserPass, BirthDate, FirstName, LastName, CreditNum , Email, PicturePath) VALUES ('" + u.UserID + "', '" + u.UserName + "', '" + u.UserPass + "', #" + u.BirthDate + "#, '" + u.Fname + "', '" + u.Lname + "', '" + u.CardNum + "' , '" + u.Email + "','"+u.picpath+"');";
        DoQuery(db, sql);
    }
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public static void UpdateCategories(Categories c)
    {
        string sql = "update tbl_Categories set CategoryName = '" + c.CategoryName + "' where CategoryID = " + c.CategoryID;
        DoQuery(db, sql);
    }

    public static void UpdateCreditCards(CreditCards cc)
    {
        string sql = "update tbl_CreditCards set CardNumber = '" + cc.CardNumber + "' , TotalMoney = " + cc.TotalMoney + " , ExpireDate =  #" + cc.ExpireDate + "# , CVVCode = " + cc.CvvCode + " , TypeID = " + cc.TypeID + " where creditcounter = " + cc.CreditCounter;
        DoQuery(db, sql);
    }

    public static void UpdateCreditCardType(CreditCardTypes cct)
    {
        string sql = "update tbl_CreditCardType set TypeName = '" + cct.TypeName + "' where TypeID = " + cct.TypeID;
        DoQuery(db, sql);
    }

    public static void UpdateGames(Games g)
    {
        string sql = "update tbl_Games set GameName = '" + g.GameName + "' , GamePrice = " + g.GamePrice + " , GameCount = " + g.GameCount + " , GameReleaseDate = #" + g.GameReleaseDate + "# , GameCategoryID = " + g.GameCategoryID + " , GameProducerID = " + g.GameProducerID + "  , GamePicturePath = '" + g.GamePicPath + "' , GameConsole = '" + g.GameConsole+"' where GameID = " + g.GameID;
        DoQuery(db, sql);
    }

    public static void DeleteGame(int GameID)
    {
        string sql = "update tbl_Games set IsActive=false where GameID = " + GameID + "";
        DoQuery(db, sql);
    }

    public static void UpdateOrders(Orders o)
    {
        string sql = "update tbl_Orders set OrderDate = #" + o.OrderDate + "# , UserID = '" + o.UserID + "' , GameID = " + o.GameID + " where OrderID = " + o.OrderID;
        DoQuery(db, sql);
    }

    public static void UpdateProducers(Producers p)
    {
        string sql = "update tbl_Producers set ProducerName = '" + p.ProducerName + "' where ProducerID = " + p.ProducerID;
        DoQuery(db, sql);
    }

    public static void UpdateUsers(Users u)
    {
        string sql = "update tbl_Users set UserName = '" + u.UserName + "' , UserPass = '" + u.UserPass + "' , BirthDate = #" + u.BirthDate + "# , FirstName = '" + u.Fname + "' , LastName = '" + u.Lname + "' , CreditNum = " + u.CardNum + " , Email = '" + u.Email + "' , PicturePath = '" +u.picpath + "'  where UserID = '" + u.UserID+"'";
        DoQuery(db, sql);
    }

    public static void DeleteUser(string UserID)
    {
        string sql = "update tbl_Users set IsActive=false where UserID = '" + UserID + "'";
        DoQuery(db, sql);
    }

    public static void DeleteProducer(int ProducerID)
    {
        string sql = "update tbl_Producers set IsActive=false where ProducerID = " + ProducerID + "";
        DoQuery(db, sql);
    }

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    public static List<Categories> GetAllCategories()
    {
        string sql = "select * from tbl_Categories";
        DataTable dtCategories = new DataTable();
        dtCategories = ExecuteDataTable(db, sql);

        List<Categories> categories = new List<Categories>();
        foreach (DataRow dr in dtCategories.Rows)
        {
            categories.Add(new Categories(int.Parse(dr["CategoryID"].ToString()), dr["CategoryName"].ToString()));
        }

        return categories;
    }

    public static List<CreditCards> GetAllCreditCards()
    {
        string sql = "select * from tbl_CreditCards";
        DataTable dtCreditCards = new DataTable();
        dtCreditCards = ExecuteDataTable(db, sql);

        List<CreditCards> creditCards = new List<CreditCards>();
        foreach (DataRow dr in dtCreditCards.Rows)
        {
            creditCards.Add(new CreditCards(int.Parse(dr["CreditCounter"].ToString()), dr["CardNumber"].ToString(), int.Parse(dr["TotalMoney"].ToString()), DateTime.Parse(dr["ExpireDate"].ToString()), int.Parse(dr["CVVCode"].ToString()), int.Parse(dr["TypeID"].ToString())));
        }

        return creditCards;
    }

    public static List<CreditCardTypes> GetAllCreditCardTypes()
    {
        string sql = "select * from tbl_CreditCardType";
        DataTable dtCreditCardTypes = new DataTable();
        dtCreditCardTypes = ExecuteDataTable(db, sql);

        List<CreditCardTypes> creditCardTypes = new List<CreditCardTypes>();
        foreach (DataRow dr in dtCreditCardTypes.Rows)
        {
            creditCardTypes.Add(new CreditCardTypes(int.Parse(dr["TypeID"].ToString()), dr["TypeName"].ToString()));
        }

        return creditCardTypes;
    }

    public static List<Games> GetAllGames()
    {
        string sql = "select * from tbl_Games where IsActive = true";
        DataTable dtGames = new DataTable();
        dtGames = ExecuteDataTable(db, sql);

        List<Games> games = new List<Games>();
        foreach (DataRow dr in dtGames.Rows)
        {
            games.Add(new Games(int.Parse(dr["GameID"].ToString()), dr["GameName"].ToString(), int.Parse(dr["GamePrice"].ToString()), int.Parse(dr["GameCount"].ToString()), DateTime.Parse(dr["GameReleaseDate"].ToString()), int.Parse(dr["GameCategoryID"].ToString()), int.Parse(dr["GameProducerID"].ToString()), dr["GamePicturePath"].ToString(), dr["GameConsole"].ToString()));
        }

        return games;
    }

    public static List<Orders> GetAllOrders()
    {
        string sql = "select * from tbl_Orders";
        DataTable dtOrders = new DataTable();
        dtOrders = ExecuteDataTable(db, sql);

        List<Orders> orders = new List<Orders>();
        foreach (DataRow dr in dtOrders.Rows)
        {
            orders.Add(new Orders(int.Parse(dr["OrderID"].ToString()), DateTime.Parse(dr["OrderDate"].ToString()), dr["UserID"].ToString(), int.Parse(dr["GameID"].ToString())));
        }

        return orders;
    }

    public static List<Producers> GetAllProducers()
    {
        string sql = "select * from tbl_Producers where IsActive = true";
        DataTable dtProducers = new DataTable();
        dtProducers = ExecuteDataTable(db, sql);

        List<Producers> producers = new List<Producers>();
        foreach (DataRow dr in dtProducers.Rows)
        {
            producers.Add(new Producers(int.Parse(dr["ProducerID"].ToString()), dr["ProducerName"].ToString()));
        }

        return producers;
    }

    public static List<Users> GetAllUsers()
    {
        string sql = "select * from tbl_Users where IsActive = true";
        DataTable dtUsers = new DataTable();
        dtUsers = ExecuteDataTable(db, sql);

        List<Users> users = new List<Users>();
        foreach (DataRow dr in dtUsers.Rows)
        {
            users.Add(new Users(dr["UserID"].ToString(), dr["UserName"].ToString(), dr["UserPass"].ToString(), DateTime.Parse(dr["BirthDate"].ToString()), dr["FirstName"].ToString(), dr["LastName"].ToString(), int.Parse(dr["CreditNum"].ToString()) , dr["Email"].ToString() , dr["PicturePath"].ToString(), false));
        }

        return users;
    }

    public static List<Games> GetPcGames()
    {
        string sql = "SELECT * FROM tbl_Games WHERE IsActive = true and GameConsole = 'PC' or GameConsole = 'All';";
        DataTable dtGames = new DataTable();
        dtGames = ExecuteDataTable(db, sql);

        List<Games> games = new List<Games>();
        foreach (DataRow dr in dtGames.Rows)
        {
            games.Add(new Games(int.Parse(dr["GameID"].ToString()), dr["GameName"].ToString(), int.Parse(dr["GamePrice"].ToString()), int.Parse(dr["GameCount"].ToString()), DateTime.Parse(dr["GameReleaseDate"].ToString()), int.Parse(dr["GameCategoryID"].ToString()), int.Parse(dr["GameProducerID"].ToString()), dr["GamePicturePath"].ToString(), dr["GameConsole"].ToString()));
        }

        return games;
    }

    public static List<Games> GetPsGames()
    {
        string sql = "SELECT * FROM tbl_Games WHERE IsActive = true and GameConsole = 'PS' or GameConsole = 'All';";
        DataTable dtGames = new DataTable();
        dtGames = ExecuteDataTable(db, sql);

        List<Games> games = new List<Games>();
        foreach (DataRow dr in dtGames.Rows)
        {
            games.Add(new Games(int.Parse(dr["GameID"].ToString()), dr["GameName"].ToString(), int.Parse(dr["GamePrice"].ToString()), int.Parse(dr["GameCount"].ToString()), DateTime.Parse(dr["GameReleaseDate"].ToString()), int.Parse(dr["GameCategoryID"].ToString()), int.Parse(dr["GameProducerID"].ToString()), dr["GamePicturePath"].ToString(), dr["GameConsole"].ToString()));
        }

        return games;
    }

    public static List<Games> GetXboxGames()
    {
        string sql = "SELECT * FROM tbl_Games WHERE IsActive = true and GameConsole = 'Xbox' or GameConsole = 'All';";
        DataTable dtGames = new DataTable();
        dtGames = ExecuteDataTable(db, sql);

        List<Games> games = new List<Games>();
        foreach (DataRow dr in dtGames.Rows)
        {
            games.Add(new Games(int.Parse(dr["GameID"].ToString()), dr["GameName"].ToString(), int.Parse(dr["GamePrice"].ToString()), int.Parse(dr["GameCount"].ToString()), DateTime.Parse(dr["GameReleaseDate"].ToString()), int.Parse(dr["GameCategoryID"].ToString()), int.Parse(dr["GameProducerID"].ToString()), dr["GamePicturePath"].ToString(), dr["GameConsole"].ToString()));
        }

        return games;
    }

    public static void Subtract(int Price, int CreditCounter)
    {
        string sql = "UPDATE tbl_CreditCards SET TotalMoney = TotalMoney - " + Price + " where CreditCounter= " + CreditCounter + ";";
        DoQuery(db, sql);
    }
}
