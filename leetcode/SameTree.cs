
public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
     }
 }

public partial class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<(TreeNode,TreeNode)> queue = new();
        queue.Enqueue((p, q));
        while (queue.Count > 0)
        {
            (p, q) = queue.Dequeue();
            if (p == null && q == null)
                continue;
            if (p == null || q == null)
                return false;
            if(p.val!=q.val) return false;
            queue.Enqueue((p.left, q.left));
            queue.Enqueue((p.right, q.right));


        }
        return true;

    }
}