namespace TestProject.Entity.Models;

public class User
{
    public int Id{get;set;}
    public string Email{get;set;} = null!;
    public string Password{get;set;} = null!;
    public int RoleId{get;set;}
    public virtual Role Role{get;set;} = null!;
    public DateTime CreatedAt{get;set;}
    public DateTime UpdatedAt{get;set;}
    public bool IsDeleted{get;set;}
}


