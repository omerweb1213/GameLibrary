using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Categories
/// </summary>
public class Categories
{
    private int categoryID;
    private string categoryName;

	public Categories()
	{
        this.categoryID = 0;
        this.categoryName = "";
	}

    public Categories(int categoryID , string categoryName)
    {
        this.categoryID = categoryID;
        this.categoryName = categoryName;
    }

    public Categories(string categoryName)
    {
        this.categoryName = categoryName;
    }

    public int CategoryID
    {
        get { return categoryID; }

        set { this.categoryID = value; }
    }

    public string CategoryName
    {
        get { return categoryName; }

        set { this.categoryName = value; }
    }

    public override string ToString()
    {
        return this.categoryID + " " + this.categoryName;
    }
}