public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int start = 0, end = 0;
        HashSet<char> uniqueChars = new HashSet<char>();

        while (end < s.Length) {
            if (!uniqueChars.Contains(s[end])) {
                uniqueChars.Add(s[end++]);
                maxLength = Math.Max(maxLength, end - start);
            } else {
                uniqueChars.Remove(s[start++]);
            }
        }

        return maxLength;
    }
}