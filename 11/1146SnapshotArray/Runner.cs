namespace LeetCodeTasks._1146SnapshotArray
{
    public class Runner
    {
        public void Run()
        {
            /*
            var snapshotArr = new SnapshotArray(3); // set the length to be 3
            snapshotArr.Set(0, 5);  // Set array[0] = 5
            snapshotArr.Snap();  // Take a snapshot, return snap_id = 0
            snapshotArr.Set(0, 6);
            Console.WriteLine(snapshotArr.Get(0, 0));  // Get the value of array[0] with snap_id = 0, return 5
            */
            /*
            var snapshotArr = new SnapshotArray(4);
            snapshotArr.Snap();
            snapshotArr.Snap();
            Console.WriteLine(snapshotArr.Get(3, 1));
            snapshotArr.Set(2, 4);
            snapshotArr.Snap();
            snapshotArr.Set(1, 4);
            */
            var snapshotArr = new SnapshotArray(4);
            snapshotArr.Snap();
            snapshotArr.Snap();
            snapshotArr.Set(0, 4);
            snapshotArr.Snap();
            Console.WriteLine(snapshotArr.Get(0, 1));
            snapshotArr.Set(0, 12);
            Console.WriteLine(snapshotArr.Get(0, 1));
            snapshotArr.Snap();
            Console.WriteLine(snapshotArr.Get(0, 3));
        }
    }
}
