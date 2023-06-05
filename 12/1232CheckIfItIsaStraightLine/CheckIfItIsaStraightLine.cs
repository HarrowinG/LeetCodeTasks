namespace LeetCodeTasks._1232CheckIfItIsaStraightLine
{
    public class CheckIfItIsaStraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            int x0 = coordinates[0][0], y0 = coordinates[0][1],
            x1 = coordinates[1][0], y1 = coordinates[1][1];
            int dx = x1 - x0, dy = y1 - y0;
            foreach (var co in coordinates)
            {
                int x = co[0], y = co[1];
                if (dx * (y - y1) != dy * (x - x1))
                    return false;
            }

            return true;
        }
    }
}
