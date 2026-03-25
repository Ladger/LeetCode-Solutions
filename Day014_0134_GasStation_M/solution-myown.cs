public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int i = 0;

        while (i < gas.Length) {
            int failIndex = TryCompleteCircuitByStartPoint(gas, cost, i);

            if (failIndex == -1) return i;
            if (failIndex < i) return -1;

            i = failIndex + 1;
        }

        return -1;
    }

    public int TryCompleteCircuitByStartPoint(int[] gas, int[] cost, int start) {
        int current = start;
        int g = 0;

        do {
            g += gas[current] - cost[current];
            if (g < 0) return current;

            current = (current + 1) % gas.Length;
        } while (current != start);

        return -1;
    }
}