namespace LeetCodeTasks._134GasStation
{
    public class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var tank = 0;
            var total = 0;
            var res = 0;
            for (var i = 0; i < gas.Length; i++)
            {
                var delta = gas[i] - cost[i];
                tank += delta;
                total += delta;
                if (tank < 0)
                {
                    tank = 0;
                    res = i + 1;
                }
            }

            return total < 0 ? -1 : res;
        }
    }
}
