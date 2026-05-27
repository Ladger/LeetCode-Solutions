public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var result = new List<IList<int>>();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0)
            return result;

        var pq = new PriorityQueue<(int i, int j), int>();
        var visited = new HashSet<(int, int)>();

        pq.Enqueue((0, 0), nums1[0] + nums2[0]);
        visited.Add((0, 0));

        while (k-- > 0 && pq.Count > 0) {
            var (i, j) = pq.Dequeue();

            result.Add(new List<int> { nums1[i], nums2[j] });

            if (i + 1 < nums1.Length && !visited.Contains((i + 1, j))) {
                pq.Enqueue((i + 1, j), nums1[i + 1] + nums2[j]);
                visited.Add((i + 1, j));
            }

            if (j + 1 < nums2.Length && !visited.Contains((i, j + 1))) {
                pq.Enqueue((i, j + 1), nums1[i] + nums2[j + 1]);
                visited.Add((i, j + 1));
            }
        }

        return result;
    }
}