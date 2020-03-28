using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCardTypes
/// </summary>
public class CreditCardTypes
{
    private int typeID;
    private string typeName;

	public CreditCardTypes()
	{
        this.typeID = 0;
        this.typeName = "";
	}

    public CreditCardTypes(int typeID , string typeName)
    {
        this.typeID = typeID;
        this.typeName = typeName;
    }
    public CreditCardTypes(string typeName)
    {
        this.typeName = typeName;
    }

    public int TypeID
    {
        get { return typeID; }
        set { this.typeID = value; }
    }

    public string TypeName
    {
        get { return typeName; }
        set { this.typeName = value; }
    }

    public override string ToString()
    {
        return this.typeID + " " + this.typeName;
    }
}