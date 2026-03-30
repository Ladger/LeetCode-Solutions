public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> rows = new();
        HashSet<int> cols = new();

        for (int row = 0; row < matrix.Length; row++) {
            for (int col = 0; col < matrix[0].Length; col++) {
                if (matrix[row][col] == 0) {
                    rows.Add(row);
                    cols.Add(col);
                }
            }
        }

        for (int row = 0; row < matrix.Length; row++) {
            for (int col = 0; col < matrix[0].Length; col++) {
                if (rows.Contains(row) || cols.Contains(col)) {
                    matrix[row][col] = 0;
                }
            }
        }
    }
}