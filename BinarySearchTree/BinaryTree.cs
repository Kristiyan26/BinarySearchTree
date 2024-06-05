using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }


        public int NumberOfLeaves(TreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            else if(node.Left==null && node.Right == null)
            {
                return 1;
            }

            return NumberOfLeaves(node.Left) + NumberOfLeaves(node.Right);  
        }
    }
}
