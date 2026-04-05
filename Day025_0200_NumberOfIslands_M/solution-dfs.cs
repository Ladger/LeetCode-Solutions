public class Solution {
    int[][] directions = [
        new int[] {1, 0}, new int[] {0, 1}, new int[] {-1, 0}, new int[] {0, -1}
    ];

    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;

        int rowCount = grid.Length;
        int colCount = grid[0].Length;
        int islandCount = 0;

        for (int r = 0; r < rowCount; r++) {
            for (int c = 0; c < colCount; c++) {
                if (grid[r][c] == '1') {
                    ExecuteDFS(grid, r, c);
                    islandCount++;
                }
            }
        }
        return islandCount;
    }

    public void ExecuteDFS(char[][] grid, int r, int c) {
        int rowCount = grid.Length;
        int colCount = grid[0].Length;

        if (r < 0 || r >= rowCount || c < 0 || c >= colCount || grid[r][c] == '0') {
            return;
        }

        grid[r][c] = '0';

        foreach (var d in directions) {
            ExecuteDFS(grid, r + d[0], c + d[1]);
        }
    }
}