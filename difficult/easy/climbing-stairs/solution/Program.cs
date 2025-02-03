public class Solution {
    public int ClimbStairs(int n) {
        var one = 1;
        var two = 1;
        for( var i = 0; i < n; i++){
            var temp = one;
            one = one + two;
            two = temp;
        }
        return two;
    }
}