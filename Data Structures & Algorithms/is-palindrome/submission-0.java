class Solution {
    public boolean isPalindrome(String s) {
        String lower = s.toLowerCase().trim();

        int left = 0;
        int right = lower.length() - 1;

        while (left <= right) {

    
            while (left < right && !Character.isLetterOrDigit(lower.charAt(left))) {
                left++;
            }

                while (left < right && !Character.isLetterOrDigit(lower.charAt(right))) {
                right--;
            }

            if (lower.charAt(left) != lower.charAt(right)) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}