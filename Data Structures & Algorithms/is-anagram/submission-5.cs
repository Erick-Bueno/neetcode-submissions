public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        var duplicates = new Dictionary<char, int>();
        foreach (var character in s) {
            if (duplicates.ContainsKey(character)) {
                duplicates[character] += 1;
            } else {
                duplicates[character] = 1;
            }
        }

        foreach (var character in t) {
            if (!duplicates.ContainsKey(character)) {
                return false;
            }
            duplicates[character] -= 1;
            if(duplicates[character] == 0){
                duplicates.Remove(character);
            }
        }
        return duplicates.Count == 0;
    }
}
