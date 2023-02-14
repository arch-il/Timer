namespace Timer.CustomMiddleware
{
    using System.Diagnostics;

    using Timer.Interfaces;
    using Timer.Services;

    public class StopWatchMiddleware
    {
        private readonly RequestDelegate _next;

        private int ElapsedMiliseconds = 0;
        private Stopwatch stopwatch;

        public StopWatchMiddleware(RequestDelegate next)
        {
            _next = next;

            stopwatch = new();
            stopwatch.Start();
        }

        public async Task InvokeAsync(HttpContext httpContext, IStopWatch stopWatch, StopWatchService stopWatchService)
        {
            ElapsedMiliseconds = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Request {ElapsedMiliseconds}; StopWatch: {stopWatch.ElapsedMiliseconds}; Service: {stopWatchService._stopWatch.ElapsedMiliseconds}");
        }
    }
}
