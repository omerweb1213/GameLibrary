using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Games
/// </summary>
public class Games
{
    private int gameID;
    private string gameName;
    private int gamePrice;
    private int gameCount;
    private DateTime gameReleaseDate;
    private int gameCategoryID;
    private int gameProducerID;
    private string gamePicPath;
    private bool IsActive;
    private string gameConsole;

	public Games()
	{
        this.gameID = 0;
        this.gameName = "";
        this.gamePrice = 0;
        this.gameCount = 0;
        this.gameReleaseDate = DateTime.Today;
        this.gameCategoryID = 0;
        this.gameProducerID = 0;
        this.GamePicPath = "";
        this.IsActive = true;
        this.gameConsole = "";
	}

    public Games(int gameID, string gameName, int gamePrice, int gameCount, DateTime gameReleaseDate , int gameCategoryID , int gameProducerID , string GamePicPath , string gameConsole)
    {
        this.gameID =  gameID;
        this.gameName = gameName;
        this.gamePrice = gamePrice;
        this.gameCount = gameCount;
        this.gameReleaseDate = gameReleaseDate;
        this.gameCategoryID = gameCategoryID;
        this.gameProducerID = gameProducerID;
        this.GamePicPath = GamePicPath;
        this.IsActive = true;
        this.gameConsole = gameConsole;
    }

    public Games(string gameName, int gamePrice, int gameCount, DateTime gameReleaseDate, int gameCategoryID, int gameProducerID, string GamePicPath, string gameConsole)
    {
        this.gameName = gameName;
        this.gamePrice = gamePrice;
        this.gameCount = gameCount;
        this.gameReleaseDate = gameReleaseDate;
        this.gameCategoryID = gameCategoryID;
        this.gameProducerID = gameProducerID;
        this.GamePicPath = GamePicPath;
        this.IsActive = true;
        this.gameConsole = gameConsole;
    }

    public Games(string gameName, int gamePrice, int gameCount, DateTime gameReleaseDate, int gameCategoryID, int gameProducerID)
    {
        this.gameName = gameName;
        this.gamePrice = gamePrice;
        this.gameCount = gameCount;
        this.gameReleaseDate = gameReleaseDate;
        this.gameCategoryID = gameCategoryID;
        this.gameProducerID = gameProducerID;
        this.IsActive = true;
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

    public int GameCount
    {
        get { return gameCount; }

        set { this.gameCount = value; }
    }

    public DateTime GameReleaseDate
    {
        get { return gameReleaseDate; }

        set { this.gameReleaseDate = value; }
    }

    public int GameCategoryID
    {
        get { return gameCategoryID; }

        set { this.gameCategoryID = value; }
    }

    public int GameProducerID
    {
        get { return gameProducerID; }

        set { this.gameProducerID = value; }
    }

    public string GamePicPath
    {
        get { return this.gamePicPath; }
        set { this.gamePicPath = value; }
    }

    public string GameConsole
    {
        get { return this.gameConsole; }
        set { this.gameConsole = value; }
    }

    public override string ToString()
    {
        return this.gameID + " " + this.gameName + " " + this.gamePrice + " " + this.gameCount + " " + this.gameReleaseDate + " " + this.gameCategoryID + " " + this.gameProducerID;
    }
}