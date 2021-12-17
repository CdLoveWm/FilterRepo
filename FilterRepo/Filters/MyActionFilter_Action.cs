using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterRepo.Filters
{
    /// <summary>
    /// Action上的Filter
    /// 和全局Filter一样，这里新建这个Filter只是为了打印不同的内容加以区分
    /// </summary>
    public class MyActionFilter_Action : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("MyActionFilter_Action OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("MyActionFilter_Action OnActionExecuted");
        }
    }
}
