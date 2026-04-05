public class Solution {
    int[][] directions = [
        new int[] {1, 0}, new int[] {0, 1}, new int[] {-1, 0}, new int[] {0, -1}
    ];

    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;

        int rowCount = grid.Length;
        int colCount = grid[0].Length;
        bool[,] visited = new bool[rowCount, colCount];
        int islandCount = 0;

        for (int r = 0; r < rowCount; r++) {
            for (int c = 0; c < colCount; c++) {
                if (grid[r][c] == '1' && !visited[r, c]) {
                    ExecuteBFS(grid, visited, r, c);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }

    public void ExecuteBFS(char[][] grid, bool[,] visited, int startR, int startC) {
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        Queue<(int, int)> queue = new Queue<(int, int)>();
        queue.Enqueue((startR, startC));
        visited[startR, startC] = true;

        while (queue.Count > 0) {
            var (currR, currC) = queue.Dequeue();

            foreach (var dir in directions) {
                int nr = currR + dir[0];
                int nc = currC + dir[1];

                if (nr >= 0 && nr < rowCount && nc >= 0 && nc < colCount && 
                    grid[nr][nc] == '1' && !visited[nr, nc]) {
                    
                    visited[nr, nc] = true;
                    queue.Enqueue((nr, nc));
                }
            }
        }
    }
}