namespace Timer.Helpers
{
    using System.Diagnostics;

    using Timer.Interfaces;
    
    public class StopWatch : IStopWatch
    {
        private Stopwatch stopwatch;

        public int ElapsedMiliseconds
        {
            get
            {
                return Convert.ToInt32(stopwatch.ElapsedMilliseconds);
            }
        }

        public StopWatch()
        {
            stopwatch = new();
            stopwatch.Start();
        }

    }
}
