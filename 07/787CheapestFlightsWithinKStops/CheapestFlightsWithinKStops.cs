namespace LeetCodeTasks._787CheapestFlightsWithinKStops
{
    public class CheapestFlightsWithinKStops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            //return Bfs(n, flights, src, dst, k);
            return BellmanFord(n, flights, src, dst, k);
        }

        private int BellmanFord(int n, int[][] flights, int src, int dst, int k)
        {
            var prices = new int[n];
            Array.Fill(prices, int.MaxValue);
            prices[src] = 0;

            for (var i = 0; i <= k; i++)
            {
                var tmpPrices = prices.ToArray();
                foreach (var flight in flights)
                {
                    if (prices[flight[0]] == int.MaxValue) continue;

                    var sum = prices[flight[0]] + flight[2];
                    if (sum < tmpPrices[flight[1]])
                        tmpPrices[flight[1]] = sum;
                }

                prices = tmpPrices;
            }

            return prices[dst] == int.MaxValue ? -1 : prices[dst];
        }

        //TLE
        private int Bfs(int n, int[][] flights, int src, int dst, int k)
        {
            var graph = BuildGraph(flights);
            var minCost = int.MaxValue;
            var queue = new PriorityQueue<(int City, int Stop, int Cost), int>();
            if (graph.ContainsKey(src))
                foreach (var (City, Cost) in graph[src])
                    queue.Enqueue((City, 0, Cost), Cost);

            while (queue.Count > 0)
            {
                var (City, Stop, Cost) = queue.Dequeue();

                if (City == dst)
                {
                    minCost = Math.Min(minCost, Cost);
                    continue;
                }

                if (graph.ContainsKey(City))
                    foreach (var flight in graph[City])
                        if (Stop < k && Cost + flight.Cost < minCost)
                            queue.Enqueue((flight.City, Stop + 1, Cost + flight.Cost), Cost + flight.Cost);
            }

            return minCost == int.MaxValue ? -1 : minCost;
        }

        private Dictionary<int, List<(int City, int Cost)>> BuildGraph(int[][] flights)
        {
            var graph = new Dictionary<int, List<(int City, int Cost)>>();
            foreach (var flight in flights)
            {
                if (!graph.ContainsKey(flight[0]))
                    graph[flight[0]] = new List<(int City, int Cost)>();

                graph[flight[0]].Add((flight[1], flight[2]));
            }

            return graph;
        }
    }
}
