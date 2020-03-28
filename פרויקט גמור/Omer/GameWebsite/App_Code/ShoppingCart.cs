using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    private List<ProductInBag> productList = new List<ProductInBag>();
	
    public ShoppingCart()
	{
       // productList = new List<ProductInBag>();
	}

    public List<ProductInBag> ProductList
    {
        get { return this.productList; }
        set { this.productList = value; }
    }

    public void AddToList(ProductInBag P)
    {
        productList.Add(P);
    }

    public void RemoveFromList(ProductInBag P)
    {
        productList.Remove(P);
    }

    public int ListCount()
    {
        return productList.Count;
    }

    public void ClearList()
    {
        productList.RemoveRange(0, ListCount());
    }
}