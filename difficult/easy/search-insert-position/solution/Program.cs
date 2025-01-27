public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var index = Array.IndexOf(nums, target);
        if(index >= 0)
        {
            return index;
        }
        else
        {
            int[] newNums = new int[nums.Length + 1];
            Array.Copy(nums, newNums, nums.Length);
            newNums[newNums.Length - 1] = target;
            Array.Sort(newNums);

            return Array.IndexOf(newNums, target);
        }
    }
}