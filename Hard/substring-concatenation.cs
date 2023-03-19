public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        IList<int> result = new List<int>();
        if (string.IsNullOrEmpty(s) || words == null || words.Length == 0) {
            return result;
        }
        int wordLength = words[0].Length;
        int wordCount = words.Length;
        int totalLength = wordLength * wordCount;
        if (s.Length < totalLength) {
            return result;
        }
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (string word in words) {
            if (!wordCounts.ContainsKey(word)) {
                wordCounts[word] = 0;
            }
            wordCounts[word]++;
        }
        for (int i = 0; i <= s.Length - totalLength; i++) {
            string sub = s.Substring(i, totalLength);
            if (IsConcatenatedSubstring(sub, wordCounts, wordLength)) {
                result.Add(i);
            }
        }
        return result;
    }
    
    private bool IsConcatenatedSubstring(string sub, Dictionary<string, int> wordCounts, int wordLength) {
        Dictionary<string, int> subCounts = new Dictionary<string, int>();
        for (int i = 0; i < sub.Length; i += wordLength) {
            string word = sub.Substring(i, wordLength);
            if (!wordCounts.ContainsKey(word)) {
                return false;
            }
            if (!subCounts.ContainsKey(word)) {
                subCounts[word] = 0;
            }
            subCounts[word]++;
            if (subCounts[word] > wordCounts[word]) {
                return false;
            }
        }
        return true;
    }
}