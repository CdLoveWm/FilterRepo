using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 异常过滤器
    /// </summary>
    public class MyExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// 产生异常后进入
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            System.Console.WriteLine("OnException");
            // 通过context.Exception可以获取产生的异常，然后做日志记录、消息通知等操作
        }
    }
}
