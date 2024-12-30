using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _09ActionResultFilter.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew(); // Start the stopwatch when the action is executing

            if (context.Controller is Controller controller)
            {
                controller.ViewData["OnActionExecuting"] = "Action is executing";
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop(); // Stop the stopwatch when the action has executed
            var time = _stopwatch.ElapsedTicks;

            if (context.Controller is Controller controller)
            {
                controller.ViewData["ElapsedTicks"] = $"Time taken = {time} ticks";
                controller.ViewData["OnActionExecuted"] = "Action Execution Stopped";
            }
        }
    }
}