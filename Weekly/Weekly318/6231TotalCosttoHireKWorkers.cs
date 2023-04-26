using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTasks.Weekly318
{
    public class _6231TotalCosttoHireKWorkers
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            var l = 0;
            var r = costs.Length - 1;
            var lHeap = new PriorityQueue<(int val, int id), (int val, int id)>(Comparer<(int val, int id)>.Create((a, b) => a.val != b.val ? a.val.CompareTo(b.val) : a.id.CompareTo(b.id)));
            var rHeap = new PriorityQueue<(int val, int id), (int val, int id)>(Comparer<(int val, int id)>.Create((a, b) => a.val != b.val ? a.val.CompareTo(b.val) : a.id.CompareTo(b.id)));
            for (var i = 0; i < candidates && i < costs.Length; i++)
            {
                var item = (costs[i], i);
                lHeap.Enqueue(item, item);
                l++;
            }
            for (var i = costs.Length - 1; i >= 0 && i > costs.Length - 1 - candidates; i--)
            {
                var item = (costs[i], i);
                rHeap.Enqueue(item, item);
                r--;
            }

            long result = 0;
            var set = new HashSet<int>();
            while (lHeap.Count > 0 && rHeap.Count > 0)
            {
                if (k <= 0) break;

                var lPeek = lHeap.Peek();
                var rPeek = rHeap.Peek();
                if (lPeek.val == rPeek.val && lPeek.id == rPeek.id)
                {
                    var item = lHeap.Dequeue();
                    rHeap.Dequeue();
                    set.Add(item.id);
                    result += item.val;
                    while (l < costs.Length && set.Contains(l)) l++;
                    if (l < costs.Length)
                    {
                        var newItem = (costs[l], l);
                        lHeap.Enqueue(newItem, newItem);
                        l++;
                    }
                    while (r >= 0 && set.Contains(r)) r--;
                    if (r >= 0)
                    {
                        var newItem = (costs[r], r);
                        rHeap.Enqueue(newItem, newItem);
                        r--;
                    }
                }
                else
                {
                    if (lPeek.val < rPeek.val)
                    {
                        var item = lHeap.Dequeue();
                        set.Add(item.id);
                        result += item.val;
                        while (l < costs.Length && set.Contains(l)) l++;
                        if (l < costs.Length)
                        {
                            var newItem = (costs[l], l);
                            lHeap.Enqueue(newItem, newItem);
                            l++;
                        }
                    }
                    else
                    {
                        var item = rHeap.Dequeue();
                        set.Add(item.id);
                        result += item.val;
                        while (r >= 0 && set.Contains(r)) r--;
                        if (r >= 0)
                        {
                            var newItem = (costs[r], r);
                            rHeap.Enqueue(newItem, newItem);
                            r--;
                        }
                    }
                }

                k--;
            }

            return result;
        }
    }
}
