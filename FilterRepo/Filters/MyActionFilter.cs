using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterRepo.Filters
{
    public class MyActionFilter : IActionFilter
    {
        /// <summary>
        /// Action执行前
        /// </summary>
        /// <param name="context"></param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("OnActionExecuting");
        }
        /// <summary>
        /// Action执行后
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("OnActionExecuted");
        }
    }
}
