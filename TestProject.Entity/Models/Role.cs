namespace TestProject.Entity.Models;

public partial class Role
{
    public int Id { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public ICollection<User> Users { get; set; } = new List<User>();
}
