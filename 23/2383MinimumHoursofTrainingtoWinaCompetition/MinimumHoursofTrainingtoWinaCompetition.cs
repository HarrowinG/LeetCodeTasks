namespace LeetCodeTasks._2383MinimumHoursofTrainingtoWinaCompetition
{
    public class MinimumHoursofTrainingtoWinaCompetition
    {
        public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var hours = 0;
            var energySum = 0;
            for (var i = 0; i < energy.Length; i++)
            {
                energySum += energy[i];

                if (initialExperience <= experience[i])
                {
                    var delta = experience[i] - initialExperience;
                    initialExperience += delta + 1;
                    hours += delta + 1;
                }

                initialExperience += experience[i];
            }

            if (energySum >= initialEnergy)
            {
                hours += energySum - initialEnergy + 1;
            }
            
            return hours;
        }
    }
}
