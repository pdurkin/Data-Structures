using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class TreeNode<T> where T : IComparable<T>
    {
        TreeNode<T> leftChild;
        TreeNode<T> rightChild;
        T data;

        //base node with no children
        TreeNode(T input)
        {
            data = input;
            leftChild = null;
            rightChild = null;
        }
        
        //Constructor assuming we have children
        TreeNode(T input, TreeNode<T> lChild, TreeNode<T> rChild)
        {
            data = input;
            leftChild = lChild;
            rightChild = rChild;
        }
    }
}
