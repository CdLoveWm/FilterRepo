using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 资源过滤器
    /// </summary>
    public class MyResourceFilter : IResourceFilter
    {
        /// <summary>
        /// 执行前
        /// </summary>
        /// <param name="context"></param>
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            System.Console.WriteLine("OnResourceExecuting");
            // 可以在这里做缓存，如果发现有缓存，就直接取缓存数据返回
        }
        /// <summary>
        /// 执行后
        /// </summary>
        /// <param name="context"></param>
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            System.Console.WriteLine("OnResourceExecuted");
            // 可以在这里做缓存，在这里将数据加入缓存中，以便下次请求读取
        }
    }
}
