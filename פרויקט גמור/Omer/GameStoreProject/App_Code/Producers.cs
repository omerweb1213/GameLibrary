using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Producers
/// </summary>
public class Producers
{
    private int producerID;
    private string producerName;
    private bool IsActive;

	public Producers()
	{
        this.producerID = 0;
        this.producerName = "";
        this.IsActive = true;
	}

    public Producers(int producerID , string producerName)
    {
        this.producerID = producerID;
        this.producerName = producerName;
        this.IsActive = true;
    }

    public Producers(string producerName)
    {
        this.producerName = producerName;
    }

    public int ProducerID
    {
        get { return producerID; }
        set { this.producerID = value; }
    }

    public string ProducerName
    {
        get { return producerName; }
        set { this.producerName = value; }
    }

    public override string ToString()
    {
        return this.producerID + " " + this.producerName;
    }
}