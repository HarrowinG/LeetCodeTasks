using System.Collections.Generic;

namespace LeetCodeTasks._729MyCalendarI
{
    public class MyCalendar
    {
        //private SegmentTree _tree = new SegmentTree(0, (int)1e9); //exercise bounds;
        //private SortedSet<int[]> _sortedSet = new SortedSet<int[]>(Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
        private List<int[]> _list = new List<int[]>();

        public MyCalendar()
        {

        }

        public bool Book(int start, int end)
        {
            //return BookSortedSet(start, end);
            //return BookSegmentTree(start, end);
            return BookBinarySearch(start, end);
        }

        public bool BookBinarySearch(int start, int end)
        {
            if (_list.Count == 0 || _list[_list.Count - 1][1] <= start)
            {
                _list.Add(new int[] { start, end });
                return true;
            }
            else if (_list[0][0] >= end)
            {
                _list.Insert(0, new int[] { start, end });
                return true;
            }
            else
            {
                var low = 0;
                var hight = _list.Count - 1;
                while (low <= hight)
                {
                    var mid = low + (hight - low) / 2;
                    if (_list[mid][0] == start) return false;
                    else if (end <= _list[mid][0])
                    {
                        hight = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }

                if (start >= _list[low - 1][1] && end <= _list[low][0])
                {
                    _list.Insert(low, new int[] { start, end });
                    return true;
                }
            }

            return false;
        }

        /*
        public bool BookSortedSet(int start, int end)
        {
            var floor = _sortedSet.GetViewBetween(new int[] { 0, int.MaxValue }, new int[] { start, int.MaxValue }).Max;
            var ceiling = _sortedSet.GetViewBetween(new int[] { start, int.MaxValue }, new int[] { end, int.MaxValue }).Min;

            if (floor != null && start < floor[1]) return false;
            else if (ceiling != null && end > ceiling[0]) return false;

            _sortedSet.Add(new int[] { start, end });
            return true;
        }
        */

        /*
        public bool BookSegmentTree(int start, int end)
        {
            if (_tree.Query(start, end))
            {
                return _tree.Update(start, end, true);
            }
            
            return false;
        }
        */
    }
}
