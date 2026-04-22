public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 1;
            } else {
                map[num]++;
            }
        }

        int[] result = new int[k];
        int currIndex = 0;

        foreach (var item in map.OrderByDescending(x => x.Value)) {
            if (currIndex == k) {
                break;
            }

            result[currIndex] = item.Key;
            currIndex++;
        }

        return result;
    }
}