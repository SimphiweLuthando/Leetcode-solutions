using System.Collections.Generic;

public class WordDictionary {
    private TrieNode root;
    
    private class TrieNode {
        public bool isWord;
        public Dictionary<char, TrieNode> children;
        public TrieNode() {
            isWord = false;
            children = new Dictionary<char, TrieNode>();
        }
    }
    
    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
        TrieNode node = root;
        foreach (char c in word) {
            if (!node.children.ContainsKey(c)) {
                node.children.Add(c, new TrieNode());
            }
            node = node.children[c];
        }
        node.isWord = true;
    }
    
    public bool Search(string word) {
        return SearchHelper(word, 0, root);
    }
    
    private bool SearchHelper(string word, int index, TrieNode node) {
        if (index == word.Length) {
            return node.isWord;
        }
        char c = word[index];
        if (c == '.') {
            foreach (TrieNode child in node.children.Values) {
                if (SearchHelper(word, index + 1, child)) {
                    return true;
                }
            }
        } else {
            if (node.children.ContainsKey(c)) {
                return SearchHelper(word, index + 1, node.children[c]);
            }
        }
        return false;
    }
}


/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */