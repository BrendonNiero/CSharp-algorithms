public class Solution {
    public string AddBinary(string a, string b) {
        var firstValue = Convert.ToInt32(a, 2);
        var secondValue = Convert.ToInt32(b, 2);
        var result = firstValue + secondValue;
        var binaryResult = Convert.ToString(result, 2);
        return binaryResult;
    }
}