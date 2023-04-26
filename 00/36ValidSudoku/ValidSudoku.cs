namespace LeetCodeTasks._36ValidSudoku
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var squares = new Dictionary<(int x, int y), HashSet<char>>();
            var rows = new Dictionary<int, HashSet<char>>();
            var columns = new Dictionary<int, HashSet<char>>();

            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.') continue;

                    var key = (i / 3, j / 3);
                    squares[key] = squares.GetValueOrDefault(key, new HashSet<char>());
                    rows[i] = rows.GetValueOrDefault(i, new HashSet<char>());
                    columns[j] = columns.GetValueOrDefault(j, new HashSet<char>());

                    if (squares[key].Contains(board[i][j])
                        || rows[i].Contains(board[i][j])
                        || columns[j].Contains(board[i][j])) return false;

                    squares[key].Add(board[i][j]);
                    rows[i].Add(board[i][j]);
                    columns[j].Add(board[i][j]);
                }
            }

            return true;
        }
    }
}
