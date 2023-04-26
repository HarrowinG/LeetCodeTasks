using LeetCodeTasks.Utility;

namespace LeetCodeTasks._787CheapestFlightsWithinKStops
{
    public class Runner
    {
        public void Run()
        {
            var n = 4; var strFlights = "[[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]]"; var src = 0; var dst = 3; var k = 1;//700
            //var n = 3; var strFlights = "[[0,1,100],[1,2,100],[0,2,500]]"; var src = 0; var dst = 2; var k = 1;//200
            //var n = 3; var strFlights = "[[0,1,100],[1,2,100],[0,2,500]]"; var src = 0; var dst = 2; var k = 0;//500
            var flights = InputUtility.StringToIntArray2D(strFlights);
            var cl = new CheapestFlightsWithinKStops();
            var result = cl.FindCheapestPrice(n, flights, src, dst, k);
            Console.WriteLine(result);
        }
    }
}
