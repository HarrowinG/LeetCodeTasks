using LeetCodeTasks.Utility;

namespace LeetCodeTasks._2385AmountofTimeforBinaryTreetoBeInfected
{
    public class AmountofTimeforBinaryTreetoBeInfected
    {
        public int AmountOfTime(TreeNode root, int start)
        {
            var graph = BuildGraph(root);
            return Infect(graph, start);
        }

        private int Infect(Dictionary<int, HashSet<int>> graph, int infectedIndex)
        {
            var count = -1;
            var infected = new HashSet<int> { infectedIndex };
            var queue = new Queue<int>();
            queue.Enqueue(infectedIndex);
            while (queue.Count > 0)
            {
                var n = queue.Count;
                for (var i = 0; i < n; i++)
                {
                    var node = queue.Dequeue();
                    foreach (var neighbour in graph[node])
                    {
                        if (infected.Contains(neighbour)) continue;

                        infected.Add(neighbour);
                        queue.Enqueue(neighbour);
                    }
                }

                count++;
            }

            return count;
        }

        private Dictionary<int, HashSet<int>> BuildGraph(TreeNode root)
        {
            var graph = new Dictionary<int, HashSet<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            graph[root.val] = new HashSet<int>();
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    graph[node.val] = graph.GetValueOrDefault(node.val, new HashSet<int>());
                    graph[node.val].Add(node.left.val);
                    graph[node.left.val] = graph.GetValueOrDefault(node.left.val, new HashSet<int>());
                    graph[node.left.val].Add(node.val);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    graph[node.val] = graph.GetValueOrDefault(node.val, new HashSet<int>());
                    graph[node.val].Add(node.right.val);
                    graph[node.right.val] = graph.GetValueOrDefault(node.right.val, new HashSet<int>());
                    graph[node.right.val].Add(node.val);
                }
            }

            return graph;
        }
    }
}
