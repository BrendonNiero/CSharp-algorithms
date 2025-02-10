public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        var stack = new List();
        var cur = root;

        while(cur.Count() > 0 || stack.Count() > 0){
            while(cur != null){
                stack.Add(cur.Next());
            }
        }
    }
}