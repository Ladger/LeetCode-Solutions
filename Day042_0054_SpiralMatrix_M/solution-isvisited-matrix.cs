public class Solution {
    static List<(int, int)> directions = new List<(int,int)> {(1,0), (0,-1), (-1,0), (0,1)};

    public IList<int> SpiralOrder(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        bool[,] isVisited = new bool[m,n];
        int direction = 0;
        int x = 0;
        int y = 0;
        int counter = 0;

        List<int> result = new();
        while (counter < m * n) {
            result.Add(matrix[y][x]);
            isVisited[y, x] = true;

            while (counter != m * n -1 && ShouldChangeDirection(isVisited, x, y, direction)) {
                direction = (direction + 1) % 4;
            }

            x += directions[direction].Item1;
            y += directions[direction].Item2;
            counter++;
        }

        return result;
    }

    private bool ShouldChangeDirection(bool[,] isVisited, int x, int y, int dir) {
        int nextX = x + directions[dir].Item1;
        int nextY = y + directions[dir].Item2;

        if (nextY < 0 || nextY >= isVisited.GetLength(0) ||
            nextX < 0 || nextX >= isVisited.GetLength(1)) return true;
        
        if (isVisited[nextY, nextX]) return true;

        return false;
    }
}