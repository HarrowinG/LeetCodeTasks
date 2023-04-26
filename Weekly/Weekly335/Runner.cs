using LeetCodeTasks.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly335
{
    public class Runner
    {
        public void Run()
        {
            /*
            var cl = new PassthePillowClass();
            //var n = 4; var time = 5;//2
            var n = 3; var time = 2;//3
            var result = cl.PassThePillow(n, time);
            Console.WriteLine(result);
            */

            /*
            var cl = new KthLargestSuminaBinaryTree();
            var strRoot = "[5,8,9,2,1,3,7,4,6]"; var k = 2;//13
            //var strRoot = "[1,2,null,3]"; var k = 1;//3
            var root = TreeUtility.BuildBinaryTree(InputUtility.StringToNullIntArray(strRoot));
            var result = cl.KthLargestLevelSum(root, k);
            Console.WriteLine(result);
            */

            var cl = new SplittheArraytoMakeCoprimeProducts();
            //var strNums = "[4,7,8,15,3,5]";//2
            //var strNums = "[4,7,15,8,3,5]";//-1
            var strNums = "[557663,280817,472963,156253,273349,884803,756869,763183,557663,964357,821411,887849,891133,453379,464279,574373,852749,15031,156253,360169,526159,410203,6101,954851,860599,802573,971693,279173,134243,187367,896953,665011,277747,439441,225683,555143,496303,290317,652033,713311,230107,770047,308323,319607,772907,627217,119311,922463,119311,641131,922463,404773,728417,948281,612373,857707,990589,12739,9127,857963,53113,956003,363397,768613,47981,466027,981569,41597,87149,55021,600883,111953,119083,471871,125641,922463,562577,269069,806999,981073,857707,831587,149351,996461,432457,10903,921091,119083,72671,843289,567323,317003,802129,612373]";//18
            var nums = InputUtility.StringToIntArray(strNums);
            var result = cl.FindValidSplit(nums);
            Console.WriteLine(result);
        }
    }
}
