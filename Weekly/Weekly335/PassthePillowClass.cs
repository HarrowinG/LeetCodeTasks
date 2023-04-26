using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly335
{
    public class PassthePillowClass
    {
        public int PassThePillow(int n, int time)
        {
            var person = 1;
            var forward = true;
            while (time > 0)
            {
                if (person == n) forward = false;
                else if (person == 1) forward = true;

                if (forward) person++;
                else person--;

                time--;
            }

            return person;
        }
    }
}
