using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 控制器上的Filter
    /// 和全局Filter一样，这里新建这个Filter只是为了打印不同的内容加以区分
    /// </summary>
    public class MyActionFilter_Controller : IActionFilter
    {
        private readonly ILogger<MyActionFilter_Controller> _logger;
        public MyActionFilter_Controller(ILogger<MyActionFilter_Controller> logger)
        {
            _logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("MyActionFilter_Controller OnActionExecuting");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("MyActionFilter_Controller OnActionExecuted");
        }
    }
}
