public class Solution {
    private int heapSize;

    public int FindKthLargest(int[] nums, int k) {
        heapSize = nums.Length;

        BuildMaxHeap(nums);

        for (int i = 1; i < k; i++) {
            ExtractMax(nums);
        }

        return ExtractMax(nums);
    }

    private void MaxHeapify(int[] nums, int index) {
        int largest = index;

        int l = 2 * index + 1;
        int r = 2 * index + 2;

        if (l < heapSize && nums[l] > nums[largest]) {
            largest = l;
        }

        if (r < heapSize && nums[r] > nums[largest]) {
            largest = r;
        }

        if (largest != index) {
            Swap(nums, index, largest);
            MaxHeapify(nums, largest);
        }
    }

    private void BuildMaxHeap(int[] nums) {
        for (int i = heapSize / 2 - 1; i >= 0; i--) {
            MaxHeapify(nums, i);
        }
    }

    private int ExtractMax(int[] nums) {
        if (heapSize < 1) return -1;

        int max = nums[0];

        nums[0] = nums[heapSize - 1];

        heapSize--;

        MaxHeapify(nums, 0);

        return max;
    }

    private void Swap(int[] nums, int a, int b) {
        int temp = nums[a];
        nums[a] = nums[b];
        nums[b] = temp;
    }
}