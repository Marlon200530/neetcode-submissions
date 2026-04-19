class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left <= right) {

            while (left < right && !IsAlphaNumeric(s[left])) {
                left++;
            }

            while (left < right && !IsAlphaNumeric(s[right])) {
                right--;
            }

            if (ToLower(s[left]) != ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    private bool IsAlphaNumeric(char c) {
        return (c >= 'a' && c <= 'z') ||
               (c >= 'A' && c <= 'Z') ||
               (c >= '0' && c <= '9');
    }

    private char ToLower(char c) {
        if (c >= 'A' && c <= 'Z') {
            return (char)(c + 32);
        }
        return c;
    }
}