namespace Timer.Services
{
    using Timer.Interfaces;

    public class StopWatchService
    {
        public IStopWatch _stopWatch { get; }

        public StopWatchService(IStopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
    }
}
