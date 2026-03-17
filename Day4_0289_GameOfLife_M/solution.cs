public class Solution {

    int[,] directions = {
    {1,0}, {1,-1}, {0,-1}, {-1,-1},
    {-1,0}, {-1,1}, {0,1}, {1,1}
    };

    public void GameOfLife(int[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;
        int[][] nextState = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            nextState[row] = new int[cols];
            for (int col = 0; col < cols; col++) {
                nextState[row][col] = GetNextGenerationState(board, col, row);
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                board[row][col] = nextState[row][col];
            }
        }
    }

    public int GetNextGenerationState(int[][] board, int col, int row) {
        int rows = board.Length;
        int cols = board[0].Length;
        
        int nCount = 0;
        for (int i = 0; i < 8; i++) {
            int nX = col + directions[i,0];
            int nY = row + directions[i,1];

            if ((nX >= 0 && nX < cols) && nY >= 0 && nY < rows) {
                nCount += board[nY][nX];
            }
        }

        if (board[row][col] == 1 && nCount >= 2 && nCount <= 3) return 1;
        else if (board[row][col] == 0 && nCount == 3) return 1;

        return 0;
    }
}