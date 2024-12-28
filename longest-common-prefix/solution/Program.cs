public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string startsWith = $"{strs[0][0]}{strs[0][1]}";
        
        if(startsWith == $"{strs[1][0]}{strs[1][1]}" 
        && startsWith == $"{strs[2][0]}{strs[2][1]}"){
            return startsWith;
        } else {
            return "";
        }
    }
}