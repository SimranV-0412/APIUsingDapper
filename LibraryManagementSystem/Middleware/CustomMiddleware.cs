//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Http;
//using System.Threading.Tasks;

//namespace LibraryManagementSystem.Middleware
//{
//    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
//    public class CustomMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public CustomMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        //public Task Invoke(HttpContext httpContext)
//        //{

//        //    return _next(httpContext);
//        //}
//        public async Task InvokeAsync(HttpContext httpContext)
//        {
//            await httpContext.Response.WriteAsync("Hello Readers, this is from Custom Middleware...");
//        }
//    }

//    // Extension method used to add the middleware to the HTTP request pipeline.
//    public static class CustomMiddlewareExtensions
//    {
//        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
//        {
//            return builder.UseMiddleware<CustomMiddleware>();
//        }
//    }
//}
