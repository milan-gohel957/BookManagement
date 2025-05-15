public class ResultObject
{
    public bool Status{get;set;}
    public string Message{get;set;} = string.Empty;
    public object? Model {get;set;}= null;
    public string? RedirectUrl {get;set;}
}