namespace LeetCodeTasks._2383MinimumHoursofTrainingtoWinaCompetition
{
    public class Runner
    {
        public void Run()
        {
            //var initialEnergy = 5; var initialExperience = 3; var energy = new int[] { 1, 4, 3, 2 }; var experience = new int[] { 2, 6, 3, 1 };//8
            //var initialEnergy = 2; var initialExperience = 4; var energy = new int[] { 1 }; var experience = new int[] { 3 };//0
            var initialEnergy = 1; var initialExperience = 1; var energy = new int[] { 1, 1, 1, 1 }; var experience = new int[] { 1, 1, 1, 50 };//51
            var cl = new MinimumHoursofTrainingtoWinaCompetition();
            var result = cl.MinNumberOfHours(initialEnergy, initialExperience, energy, experience);
            Console.WriteLine(result);
        }
    }
}
