using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace EmployeeManagment.Common.Filters
{
    public class LogExecution : ActionFilterAttribute, IExceptionFilter
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public LogExecution(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogMessage($"Entering: {context.RouteData.Values["controller"]} " +
                $"-> {context.RouteData.Values["action"]} -> {DateTime.Now} \n");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogMessage($"Completing: {context.RouteData.Values["controller"]} " +
                $"-> {context.RouteData.Values["action"]} -> {DateTime.Now} \n");
            LogMessage("------------------------------------------------------------------------------\n\n");
        }

        private void LogMessage(string message)
        {
            File.AppendAllText($"{_hostingEnvironment.ContentRootPath}/wwwroot/logs/ExecutionLog.txt", message);
        }

        public void OnException(ExceptionContext context)
        {
            LogMessage($"Exception Ocurred: {context.Exception.Message} \n" +
                $"StackTrace: {context.Exception.StackTrace} \n");
            LogMessage("------------------------------------------------------------------------------\n\n");
        }
    }
}
