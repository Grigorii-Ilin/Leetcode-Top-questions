using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Leetcode {
    //https://leetcode.com/problems/maximum-depth-of-binary-tree/

    
    //Definition for a binary tree node.
     public class TreeNode {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
              this.val = val;
              this.left = left;
              this.right = right;
         }
     }



    class MaximumDepthofBinaryTree104 {
        public int MaxDepth(TreeNode root) {

            if (root==null) {
                return 0;
            }

            return GetMaxDepthRecur(null, root, 0);
        }

        private int GetMaxDepthRecur(TreeNode parent, TreeNode current, int prevDepth) {
            int curDepth = prevDepth + 1;
            int leftDepth= curDepth, rightDepth= curDepth;

            if (current.left!=null) {
                leftDepth=GetMaxDepthRecur(current, current.left, curDepth);
            }

            if (current.right != null) {
                rightDepth = GetMaxDepthRecur(current, current.right, curDepth);
            }

            return leftDepth > rightDepth ? leftDepth : rightDepth;

        }
    }
}
