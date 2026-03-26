public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        
        int cycleLen = 2 * numRows - 2;
        int cycleCount = (s.Length + cycleLen - 1) / cycleLen;
        int cols = cycleCount * (numRows - 1); 

        char[,] grid = new char[numRows, cols];

        int row = -1;
        int col = 0;
        for (int i = 0; i < s.Length; i++) {
            int cycleIndex = i % cycleLen;
            
            if (cycleIndex == 0) {
                row = -1;
                if (i > 0) {
                    col++; 
                }
            }

            if (cycleIndex < numRows) row++;
            else {
                row--;
                col++;
            }

            grid[row, col] = s[i];
        }

        var result = new StringBuilder();
        for (int r = 0; r < grid.GetLength(0); r++) {
            for (int c = 0; c < grid.GetLength(1); c++) {
                if (grid[r,c] != '\0') result.Append(grid[r, c]);
            }
        }

        return result.ToString();
    }
}