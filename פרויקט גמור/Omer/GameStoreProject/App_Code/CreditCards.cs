using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCards
/// </summary>
public class CreditCards
{
    private int creditCounter;
    private string cardNumber;
    private int totalMoney;
    private DateTime expireDate;
    private int cvvCode;
    private int typeID;

	public CreditCards()
	{
        this.creditCounter = 0;
        this.cardNumber = "";
        this.totalMoney = 0;
        this.expireDate = DateTime.Today;
        this.cvvCode = 0;
        this.typeID = 0;

	}

    public CreditCards(int creditCounter, string cardNumber, int totalMoney, DateTime expireDate, int cvvCode, int typeID)
    {
        this.creditCounter = creditCounter;
        this.cardNumber = cardNumber;
        this.totalMoney = totalMoney;
        this.expireDate = expireDate;
        this.cvvCode = cvvCode;
        this.typeID = typeID;
    }

    public CreditCards(string cardNumber, int totalMoney, DateTime expireDate, int cvvCode, int typeID)
    {
        this.cardNumber = cardNumber;
        this.totalMoney = totalMoney;
        this.expireDate = expireDate;
        this.cvvCode = cvvCode;
        this.typeID = typeID;
    }

    public int CreditCounter
    {
    get {return creditCounter; }

    set { this.creditCounter = value; }
    }

    public string CardNumber
    {
        get { return cardNumber; }

        set { this.cardNumber = value; }
    }

    public int TotalMoney
    {
        get { return totalMoney; }

        set { this.totalMoney = value; }
    }

    public DateTime ExpireDate
    {
        get { return expireDate; }

        set { this.expireDate = value; }
    }

    public int CvvCode
    {
        get { return cvvCode; }

        set { this.cvvCode = value; }
    }

    public int TypeID
    {
        get { return typeID; }

        set { this.typeID = value; }
    }

    public override string ToString()
    {
        return this.creditCounter + " " + this.cardNumber + " " + this.totalMoney + " " + this.expireDate + " " + this.cvvCode + " " + this.typeID;
    }
}