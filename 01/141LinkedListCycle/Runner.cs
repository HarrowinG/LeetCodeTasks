using LeetCodeTasks.Utility;

namespace LeetCodeTasks._141LinkedListCycle
{
    public class Runner
    {
        public void Run()
        {
            //var nums = new int[] { 3, 2, 0, -4 }; var pos = 1;//true
            //var nums = new int[] { 1, 2 }; var pos = 0;//true
            var nums = new int[] { 1 }; var pos = -1;//false

            var head = LinkedListUtility.BuildList(nums);
            var cur = head;
            var link = head;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            if (pos >= 0)
            {
                for (var i = 0; i < pos; i++)
                {
                    link = link.next;
                }
                cur.next = link;
            }
            
            var cl = new LinkedListCycle();
            var result = cl.HasCycle(head);
            Console.WriteLine(result);
        }
    }
}
