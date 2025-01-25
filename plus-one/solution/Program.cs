public class Solution {
    public int[] PlusOne(int[] digits) {
        int lastNumber = digits[digits.Length - 1];
        lastNumber += 1;
        int[] newArray = new int[digits.Length -1];
        Array.Copy(digits, newArray, digits.Length -1);
        int[] splitNumber = lastNumber.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        int[] updatedArray = newArray.Concat(splitNumber).ToArray();
        return updatedArray;
    }
}