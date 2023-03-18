public class BrowserHistory {

    private List<string> history;
    private int currentIndex;

    public BrowserHistory(string homepage) {
        history = new List<string>();
        history.Add(homepage);
        currentIndex = 0;
    }
    
    public void Visit(string url) {
        history.RemoveRange(currentIndex + 1, history.Count - currentIndex - 1);
        history.Add(url);
        currentIndex = history.Count - 1;
    }
    
    public string Back(int steps) {
        currentIndex = Math.Max(0, currentIndex - steps);
        return history[currentIndex];
    }
    
    public string Forward(int steps) {
         currentIndex = Math.Min(history.Count - 1, currentIndex + steps);
        return history[currentIndex];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */