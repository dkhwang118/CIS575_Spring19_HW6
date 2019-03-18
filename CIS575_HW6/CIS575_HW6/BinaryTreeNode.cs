using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS575_HW6
{
    class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode leftChild { get; set; }
        public BinaryTreeNode rightChild { get; set; }


        public BinaryTreeNode(int value)
        {
            Value = value;
        }


    }
}
