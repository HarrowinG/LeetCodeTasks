namespace LeetCodeTasks._146LRUCache
{
    public class Runner
    {
        public void Run()
        {
            /*
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1); // cache is {1=1}
            lRUCache.Put(2, 2); // cache is {1=1, 2=2}
            Console.WriteLine(lRUCache.Get(1));    // return 1
            lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
            Console.WriteLine(lRUCache.Get(2));    // returns -1 (not found)
            lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
            Console.WriteLine(lRUCache.Get(1));    // return -1 (not found)
            Console.WriteLine(lRUCache.Get(3));    // return 3
            Console.WriteLine(lRUCache.Get(4));    // return 4
            */

            
            LRUCache lRUCache = new LRUCache(2);
            Console.WriteLine(lRUCache.Get(2)); //-1
            lRUCache.Put(2, 6); // cache is {2=6}
            Console.WriteLine(lRUCache.Get(1));    //-1
            lRUCache.Put(1, 5); // {2=6, 1=5}
            lRUCache.Put(1, 2); // {2=6, 1=2}
            Console.WriteLine(lRUCache.Get(1));    // 2
            Console.WriteLine(lRUCache.Get(2));    // 6
            
        }
    }
}
