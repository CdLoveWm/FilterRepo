using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 结果过滤器
    /// 可以对返回的结果执行格式化、大小写转换等操作
    /// </summary>
    public class MyResultFilter : IResultFilter
    {
        /// <summary>
        /// 结果执行之前
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuting(ResultExecutingContext context)
        {
            System.Console.WriteLine("OnResultExecuting");
        }
        /// <summary>
        /// 结果执行之后
        /// </summary>
        /// <param name="context"></param>
        public void OnResultExecuted(ResultExecutedContext context)
        {
            System.Console.WriteLine("OnResultExecuted");
        }
    }
}
