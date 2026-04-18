class Solution {
    public int maxArea(int[] heights) {
        int left = 0;
        int right = heights.length - 1;

        int maxWater = 0;
        int area;
        int minHeight;

        while (left < right) {
            minHeight = Math.min(heights[left], heights[right]);
            area = minHeight * (right - left);

            if (area > maxWater) {
                maxWater = area;
            }

            if (heights[left] < heights[right]) {
                left++;
            } else {
                right--;
            }
        }

        return maxWater;
    }
}