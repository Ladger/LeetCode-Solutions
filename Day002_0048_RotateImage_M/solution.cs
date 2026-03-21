public class Solution {
    public void Rotate(int[][] matrix) {
        Transpose(matrix);

        int rows = matrix.Length;
        for (int row = 0; row < rows; row++) {
            Array.Reverse(matrix[row]);
        }
    }

    private void Transpose(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                if (col > row) {
                    int temp = matrix[row][col];
                    matrix[row][col] = matrix[col][row];
                    matrix[col][row] = temp;
                }
            }
        }
    }
}