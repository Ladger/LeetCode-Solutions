public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] indegrees = new int[numCourses];
        List<List<int>> adj = new();
        
        for (int i = 0; i < numCourses; i++) {
            adj.Add(new List<int>());
        }

        foreach (var i in prerequisites) {            
            adj[i[1]].Add(i[0]);
            indegrees[i[0]]++;
        }

        int counter = 0;
        Queue<int> q = new();

        for (int i = 0; i < indegrees.Length; i++) {
            if (indegrees[i] == 0) q.Enqueue(i);
        }

        while (q.Count > 0) {
            int top = q.Dequeue();
            counter++;
            foreach (var i in adj[top]) {
                indegrees[i]--;
                if (indegrees[i] == 0) q.Enqueue(i);
            }
        }

        return counter == numCourses;
    }
}