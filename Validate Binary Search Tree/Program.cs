using System;
using System.Collections.Generic;

namespace Validate_Binary_Search_Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(5);
      root.left = new TreeNode(1);
      root.right = new TreeNode(7);
      root.right.left = new TreeNode(6);
      root.right.right = new TreeNode(8);
      Program p = new Program();
      var result = p.isValidBinarySearchTree(root);
      Console.WriteLine(result);
    }

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

    public bool isValidBinarySearchTree(TreeNode root)
    {
      if (root == null) return true;
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      while (q.Count > 0)
      {
        int size = q.Count;
        while (size-- > 0)
        {
          var node = q.Dequeue();
          if (node.left != null && node.left.val >= node.val ||
            node.right != null && node.right.val <= node.val) return false;
          if (node.left != null) q.Enqueue(node.left);
          if (node.right != null) q.Enqueue(node.right);
        }
      }
      return true;
    }
  }
}
