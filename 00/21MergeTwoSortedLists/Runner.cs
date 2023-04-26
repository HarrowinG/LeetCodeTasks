using LeetCodeTasks.Utility;

namespace LeetCodeTasks._21MergeTwoSortedLists
{
    public class Runner
    {
        public void Run()
        {
            var list1 = new int[] { 1, 2, 4 }; var list2 = new int[] { 1, 3, 4 }; //1,1,2,3,4,4
            //var list1 = new int[] {  }; var list2 = new int[] {  }; //
            //var list1 = new int[] {  }; var list2 = new int[] { 0 }; //0
            var head1 = LinkedListUtility.BuildList(list1);
            var head2 = LinkedListUtility.BuildList(list2);
            var cl = new MergeTwoSortedLists();
            var result = cl.MergeTwoLists(head1, head2);
            var str = "[";
            while (result != null)
            {
                str += $"{result.val},";
                result = result.next;
            }
            str = str.Trim(',');
            str += "]";
            Console.WriteLine(str);
        }
    }
}
