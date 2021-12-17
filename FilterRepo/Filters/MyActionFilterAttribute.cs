using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 实现IActionFilter的同时继承Attribute
    /// 可作用于控制器和Action的Filter
    /// </summary>
    public class MyActionFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("OnActionExecuting Attribute");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted Attribute");
        }
    }
}
