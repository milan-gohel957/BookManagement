namespace TestProject.Entity.ViewModels;
public partial class PaginationViewModel<T> where T:class
{
    public int Page{get;set;}
    public int PageSize{get;set;}
    public string Search{get;set;} = string.Empty;
    public string Order{get;set;} = string.Empty;
    public bool IsAscending{get;set;} = true;
    public int TotalPages{get;set;}
    public int From {get;set;}   
    public int To{get;set;}
    public List<T> Items{get;set;} = new();
    
}