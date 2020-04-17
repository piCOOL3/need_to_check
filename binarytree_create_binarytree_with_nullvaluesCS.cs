using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarytree_create_binarytree_with_nullvaluesCS
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int value ) { val = value; }
    }
    class Program
    {
        static TreeNode build_tree(char[] level_order_collection, int start_index, int end_index)
        {
            //  a tree is always built up in bottom-up structure 
            TreeNode root = null;
            // initial referance set to null 

            if (start_index <= end_index)
            {
                // node to be created has not over-shooted the available range 

                root = new TreeNode(level_order_collection[start_index]);

                root.left = build_tree(level_order_collection, (2 * start_index) + 1, end_index);
                root.right = build_tree(level_order_collection, (2 * start_index) + 2, end_index);
                // recursively call the same tree build function to create left sub-tree and right sub tree 

            }
            return root;
        }
        static void Main(string[] args)
        {
            Nullable<int> level_order = new Nullable<int> { 3, 9, 20, null, null, 15, 7 };
            //  level order traversal for the tree nodes provided 
        }
    }
}
