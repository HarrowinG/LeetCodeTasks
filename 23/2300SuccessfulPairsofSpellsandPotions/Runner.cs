using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2300SuccessfulPairsofSpellsandPotions
{
    public class Runner
    {
        public void Run()
        {
            var cl = new SuccessfulPairsofSpellsandPotions();
            //var strSpells = "[5,1,3]"; var strPotions = "[1,2,3,4,5]"; long success = 7;//[4,0,3]
            var strSpells = "[3,1,2]"; var strPotions = "[8,5,8]"; long success = 16;//[2,0,2]
            var spells = InputUtility.StringToIntArray(strSpells);
            var potions = InputUtility.StringToIntArray(strPotions);
            var result = cl.SuccessfulPairs(spells, potions, success);
            Console.WriteLine(ResultUtility.Array(result));
        }
    }
}
