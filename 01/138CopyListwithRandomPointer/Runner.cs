namespace LeetCodeTasks._138CopyListwithRandomPointer
{
    public class Runner
    {
        public void Run()
        {
            var nums = new int?[][]
            {
                new int?[] {7, null},
                new int?[] {13, 0},
                new int?[] {11, 4},
                new int?[] {10, 2},
                new int?[] {1, 0},
            };
            var head = Dfs(nums, 0);
            var cl = new CopyListwithRandomPointer();
            var result = cl.CopyRandomList(head);
        }

        private Dictionary<int, Node> _dict = new();
        private Node Dfs(int?[][] nums, int i)
        {
            if (i == nums.Length) return null;

            var node = new Node((int)nums[i][0]);
            _dict[i] = node;
            var item = Dfs(nums, i + 1);
            node.next = item;
            if (nums[i][1] != null) node.random = _dict[(int)nums[i][1]];
            return node;
        }
    }
}
