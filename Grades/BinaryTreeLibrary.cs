using System;

namespace Grades
{
    class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int nodeData)
        {
            Data = nodeData;
            LeftNode = RightNode = null;
        }

        public void Insert(int insertValue)
        {

        }
    }
}
