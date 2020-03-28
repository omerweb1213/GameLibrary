using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductInBag
/// </summary>
public class ProductInBag
{
    protected int gameID;
    protected string gameName;
    protected int gamePrice;

    public ProductInBag()
    {
        this.gameID = 0;
        this.gameName = "";
        this.gamePrice = 0;
    }

    public ProductInBag(int GameID, string GameName, int GamePrice)
    {
        this.gameID = GameID;
        this.gameName = GameName;
        this.gamePrice = GamePrice;
    }

    public int GameID
    {
        get { return gameID; }

        set { this.gameID = value; }
    }

    public string GameName
    {
        get { return gameName; }

        set { this.gameName = value; }
    }

    public int GamePrice
    {
        get { return gamePrice; }

        set { this.gamePrice = value; }
    }

    public string ToString()
    {
        return "ID = " + gameID + "Name = " + gameName + "Price = " + gamePrice;
    }
}