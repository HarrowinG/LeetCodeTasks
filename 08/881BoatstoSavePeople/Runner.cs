using LeetCodeTasks.Utility;

namespace LeetCodeTasks._881BoatstoSavePeople
{
    public class Runner
    {
        public void Run()
        {
            var cl = new BoatstoSavePeople();
            //var strPeople = "[1,2]"; var limit = 3;//1
            //var strPeople = "[3,2,2,1]"; var limit = 3;//3
            var strPeople = "[3,5,3,4]"; var limit = 5;//4
            var people = InputUtility.StringToIntArray(strPeople);
            var result = cl.NumRescueBoats(people, limit);
            Console.WriteLine(result);
        }
    }
}
