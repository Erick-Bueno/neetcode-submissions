public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        var duplicates = new Dictionary<char, int>();
        foreach(var character in s){
            if(duplicates.ContainsKey(character)){
                duplicates[character] += 1;
            }
            else{
                duplicates[character] = 1;
            }
        }

        foreach(var character in t){
            if(duplicates.ContainsKey(character)){
                duplicates[character] -= 1;
            }
        }

        foreach (var duplicate in duplicates.Values){
            if(duplicate != 0){
                return false;
            }
        }
        return true;
    }
}
