namespace LeetCodeTasks._1396DesignUndergroundSystem
{
    public class UndergroundSystem
    {
        readonly Dictionary<int, (string station, int time)> _checkIns = new();
        readonly Dictionary<string, (double sumTime, int count)> _travels = new();

        public UndergroundSystem() { }

        public void CheckIn(int id, string stationName, int t)
        {
            _checkIns[id] = (stationName, t);
        }

        public void CheckOut(int id, string stationName, int t)
        {
            var checkIn = _checkIns[id];
            var key = $"{checkIn.station}-{stationName}";
            double time = t - checkIn.time;
            var count = 1;
            if (_travels.ContainsKey(key))
            {
                time += _travels[key].sumTime;
                count += _travels[key].count;
            }

            _travels[key] = (time, count);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var key = $"{startStation}-{endStation}";
            return _travels[key].sumTime / _travels[key].count;
        }
    }
}
