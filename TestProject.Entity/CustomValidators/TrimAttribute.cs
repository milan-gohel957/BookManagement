using Microsoft.AspNetCore.Mvc.Filters;

namespace TestProject.Entity.CustomValidators;

public class TrimAttribute:ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var parameters = context.ActionArguments;
        foreach(var param in parameters)
        {
            TrimStringProps(param);
        }
        base.OnActionExecuting(context);
    }

    private static void TrimStringProps(object obj)
    {
        if(obj == null) return;
        foreach(var prop in obj.GetType().GetProperties())
        {
            if(prop.PropertyType == typeof(string) && prop.CanWrite)
            {
                string? value = (string?)prop.GetValue(obj);
                if(value != null)
                {
                    prop.SetValue(obj, value.Trim());
                }
            }
        }
    }
}
