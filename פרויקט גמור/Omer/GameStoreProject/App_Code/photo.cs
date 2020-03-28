using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Photo
/// </summary>
public class photo
{
    private int Num;
    private string PicPath;
	public photo(int Num,string PicPath)
	{
        this.Num = Num;
        this.PicPath = PicPath;
	}
}