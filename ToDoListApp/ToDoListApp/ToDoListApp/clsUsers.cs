using System;



public partial class DataUsers
{

    
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserPassword { get; }
    public string ImagePass { get; set; }

    public DataUsers() 
    {
        
    }

    public DataUsers(string FirstName , string LastName, string Password, string ImagePass)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.UserPassword = Password;
        this.ImagePass = ImagePass;
    }





}