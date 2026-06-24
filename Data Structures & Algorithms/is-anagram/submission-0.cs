public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var counter = new Dictionary<char, int>();

        foreach(var letter in s){
            if(counter.ContainsKey(letter)){
                counter[letter]++;
            }
            else{
                counter[letter] = 1;
            }
        }

        foreach(var letter in t){
            if(!counter.ContainsKey(letter) || counter[letter] == 0){
                return false;
            }
            
            counter[letter]--;
        }

        return true;
    }
}
