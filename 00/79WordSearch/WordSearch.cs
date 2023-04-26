namespace LeetCodeTasks._79WordSearch
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            var verified = new bool[board.Length, board[0].Length];
            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != word[0]) continue;

                    if (Dfs(board, verified, word, 0, i, j)) return true;
                }
            }

            return false;
        }

        private bool Dfs(char[][] board, bool[,] verified, string word, int i, int r, int c)
        {
            if (i == word.Length) return true;
            if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length) return false;
            if (board[r][c] != word[i] || verified[r, c]) return false;

            verified[r, c] = true;
            var result = Dfs(board, verified, word, i + 1, r + 1, c)
                || Dfs(board, verified, word, i + 1, r - 1, c)
                || Dfs(board, verified, word, i + 1, r, c + 1)
                || Dfs(board, verified, word, i + 1, r, c - 1);
            verified[r, c] = false;

            return result;
        }
    }
}
