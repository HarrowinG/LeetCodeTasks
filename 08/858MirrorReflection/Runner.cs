using System;

namespace LeetCodeTasks._858MirrorReflection
{
    public class Runner
    {
        public void Run()
        {
            //var p = 2; var q = 1;//2
            var p = 3; var q = 1;//1
            var cl = new MirrorReflectionClass();
            var result = cl.MirrorReflection(p, q);
            Console.WriteLine(result);
        }
    }
}
