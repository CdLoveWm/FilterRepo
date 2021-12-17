using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterRepo.Filters
{
    /// <summary>
    /// 授权过滤器
    /// </summary>
    public class MyAuthorizationFilter : IAuthorizationFilter
    {
        /// <summary>
        /// 这里可以进行权限的验证
        /// </summary>
        /// <param name="context"></param>
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            System.Console.WriteLine("OnAuthorization");
            // 这样对context.Result赋值，就是设置短路器，请求就会直接返回不继续往下执行了。
            //context.Result = new ContentResult()
            //{
            //    Content = "Resource unavailable - header not set."
            //};
        }
    }
}
