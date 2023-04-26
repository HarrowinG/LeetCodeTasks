namespace LeetCodeTasks._1416RestoreTheArray
{
    public class Runner
    {
        public void Run()
        {
            var cl = new RestoreTheArray();
            //var s = "1000"; var k = 10000;//1
            //var s = "1000"; var k = 10;//0
            //var s = "1317"; var k = 2000;//8
            var s = "407780786171321121429620765476840275495357129574174233567552131453038760763182952432348422252546559691171161181440370120987634895458140447952079749439961325982629462531738374032416182281868731817661954890417245087359968833257550123324827240537957646002494771036413572415"; var k = 823924906;//427125123
            var result = cl.NumberOfArrays(s, k);
            Console.WriteLine(result);
        }
    }
}
