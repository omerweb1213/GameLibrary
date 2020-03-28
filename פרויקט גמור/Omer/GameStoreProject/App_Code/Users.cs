using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public class Users
{
        private string userId;
        private string userName;
        private string userPass;
        private DateTime birthDate;
        private string fname;
        private string lname;
        private int cardNum;
        private string email;
        private string PicPath;
        private bool IsActive;
        private bool IsAdmin;

	    public Users()
	     { // פעולה בונה ללא פרמטרים
            this.userId = "";
            this.userName = "";
            this.userPass = "";
            this.birthDate = DateTime.Today;
            this.fname = "";
            this.lname = "";
            this.cardNum = 0;
            this.email = "";
            this.IsActive = true;
            this.IsAdmin = false;
 
         }
         public Users(string userid , string userName , string userPass , DateTime birthDate , string fname , string lname , int cardNum , string email)
         { // פעולה בונה עם פרמטרים
            this.userId = userid;
            this.userName = userName;
            this.userPass = userPass;
            this.birthDate = birthDate;
            this.fname = fname;
            this.lname = lname;
            this.cardNum = cardNum;
            this.email = email;
         }
         public Users(string userid, string userName, string userPass, DateTime birthDate, string fname, string lname, int cardNum, string email, string PicPath, bool IsAdmin)
         { // פעולה בונה עם פרמטרים
             this.userId = userid;
             this.userName = userName;
             this.userPass = userPass;
             this.birthDate = birthDate;
             this.fname = fname;
             this.lname = lname;
             this.cardNum = cardNum;
             this.email = email;
             this.PicPath = PicPath;
             this.IsActive = true;
             this.IsAdmin = IsAdmin;
         }

         public Users(string userName, string userPass, DateTime birthDate, string fname, string lname, int cardNum , string email)
         { 
             this.userName = userName;
             this.userPass = userPass;
             this.birthDate = birthDate;
             this.fname = fname;
             this.lname = lname;
             this.cardNum = cardNum;
             this.email = email;
         }

         public string UserID
         {
             get { return userId; }
             set { this.userId = value; }
         }

         public string UserName
         {
             get { return userName; }
             set { this.userName = value; }
         }

         public string UserPass
         {
             get { return userPass; }
             set { this.userPass = value; }
         }

         public DateTime BirthDate
         {
             get { return birthDate; }
             set { this.birthDate = value; }
         }

         public string Fname
         {
             get { return fname; }
             set { this.fname = value; }
         }

         public string Lname
         {
             get { return lname; }
             set { this.lname = value; }
         }

         public int CardNum
         {
             get { return cardNum; }
             set { this.cardNum = value; }
         }

         public string Email
         {
             get { return email; }
             set { this.email = value; }
         }

         public string picpath
         {
             get { return this.PicPath; }
             set { this.PicPath = value; }
         }

         public bool isAdmin
         {
             get { return this.IsAdmin; }
             set { this.IsAdmin = value; }
         }

         public override string ToString()
         {
             return this.userId + " " + this.userName + " " + this.userPass + " " + this.birthDate + " " + this.fname + " " + this.lname + " " + this.cardNum + " " + this.IsActive;
         }
}