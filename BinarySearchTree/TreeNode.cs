using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class TreeNode
    {
        private TreeNode left;
        private TreeNode right;

        public int Data { get; set; }
        public TreeNode Left {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }
        public TreeNode Right
        {
            get
            {
                return this.right;
            }
            set
            { 
                this.right = value;
            }
        }
        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
