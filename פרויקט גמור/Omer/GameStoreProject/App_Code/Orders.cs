using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Orders
/// </summary>
public class Orders
{
    private int orderID;
    private DateTime orderDate;
    private string userID;
    private int gameID;

	public Orders()
	{
        this.orderID = 0;
        this.orderDate = DateTime.Today;
        this.userID = "";
        this.gameID = 0;
	}

    public Orders(int orderID , DateTime orderDate , string userID , int gameID)
    {
        this.orderID = orderID;
        this.orderDate = orderDate;
        this.userID = userID;
        this.gameID = gameID;
    }

    public Orders(DateTime orderDate, string userID, int gameID)
    {
        this.orderDate = orderDate;
        this.userID = userID;
        this.gameID = gameID;
    }

    public int OrderID
    {
        get { return orderID; }
        set { this.orderID = value; }
    }

    public DateTime OrderDate
    {
        get { return orderDate; }
        set { this.orderDate = value; }
    }

    public string UserID
    {
        get { return userID; }
        set { this.userID = value; }
    }

    public int GameID
    {
        get { return gameID; }
        set { this.gameID = value; }
    }

    public override string ToString()
    {
        return this.orderID + " " + this.orderDate + " " + this.userID + " " + this.gameID;
    }
}