namespace LeetCodeTasks._2336SmallestNumberinInfiniteSet
{
    public class Runner
    {
        public void Run()
        {
            var smallestInfiniteSet = new SmallestInfiniteSet();
            smallestInfiniteSet.AddBack(2);    // 2 is already in the set, so no change is made.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 1, since 1 is the smallest number, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 2, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 3, and remove it from the set.
            smallestInfiniteSet.AddBack(1);    // 1 is added back to the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 1, since 1 was added back to the set and
                                                                  // is the smallest number, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 4, and remove it from the set.
            Console.WriteLine(smallestInfiniteSet.PopSmallest()); // return 5, and remove it from the set.
        }
    }
}
