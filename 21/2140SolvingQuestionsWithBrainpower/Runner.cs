using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2140SolvingQuestionsWithBrainpower
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SolvingQuestionsWithBrainpower();
            //var strQuestions = "[[3,2],[4,3],[4,4],[2,5]]";//5
            var strQuestions = "[[1,1],[2,2],[3,3],[4,4],[5,5]]";//7
            var questions = InputUtility.StringToIntArray2D(strQuestions);
            var result = cl.MostPoints(questions);
            Console.WriteLine(result);
        }
    }
}
