using LeetCodeTasks.Utility;

namespace LeetCodeTasks.BiWeekly94
{
    public class Runner
    {
        public void Run()
        {
            /*
            //var strForts = "[1,0,0,-1,0,0,0,0,1]";//4
            var strForts = "[0,0,1,-1]";//0
            var forts = InputUtility.StringToIntArray(strForts);
            var cl = new _6273MaximumEnemyFortsThatCanBeCaptured();
            var result = cl.CaptureForts(forts);
            Console.WriteLine(result);
            */

            /*
            
            var positive_feedback = new[] { "smart", "brilliant", "studious" }; var negative_feedback = new[] { "not" };
            var report = new[] { "this student is studious", "the student is smart" };
            var student_id = new[] { 1, 2 }; var k = 2;//[1,2]
            
            
            var positive_feedback = new[] { "smart", "brilliant", "studious" }; var negative_feedback = new[] { "not" };
            var report = new[] { "this student is not studious", "the student is smart" };
            var student_id = new[] { 1, 2 }; var k = 2;//[2,1]
            
            var cl = new _6274RewardTopKStudents();
            var result = cl.TopStudents(positive_feedback, negative_feedback, report, student_id, k);
            Console.WriteLine(ResultUtility.List(result));
            */

            //var divisor1 = 2; var divisor2 = 7; var uniqueCnt1 = 1; var uniqueCnt2 = 3;//4
            //var divisor1 = 3; var divisor2 = 5; var uniqueCnt1 = 2; var uniqueCnt2 = 1;//3
            var divisor1 = 2; var divisor2 = 4; var uniqueCnt1 = 8; var uniqueCnt2 = 2;//15
            //var divisor1 = 9; var divisor2 = 4; var uniqueCnt1 = 8; var uniqueCnt2 = 3;//11
            var cl = new _6295MinimizetheMaximumofTwoArrays();
            var result = cl.MinimizeSet(divisor1, divisor2, uniqueCnt1, uniqueCnt2);
            Console.WriteLine(result);
        }
    }
}
