namespace LeetCodeTasks._2409CountDaysSpentTogether
{
    public class Runner
    {
        public void Run()
        {
            //var arriveAlice = "08-15"; var leaveAlice = "08-18"; var arriveBob = "08-16"; var leaveBob = "08-19";//3
            //var arriveAlice = "10-01"; var leaveAlice = "10-31"; var arriveBob = "11-01"; var leaveBob = "12-31";//0
            //var arriveAlice = "09-01"; var leaveAlice = "10-19"; var arriveBob = "06-19"; var leaveBob = "10-20";//49
            var arriveAlice = "03-05"; var leaveAlice = "07-14"; var arriveBob = "04-14"; var leaveBob = "09-21";//92
            var cl = new CountDaysSpentTogether();
            var result = cl.CountDaysTogether(arriveAlice, leaveAlice, arriveBob, leaveBob);
            Console.WriteLine(result);
        }
    }
}
