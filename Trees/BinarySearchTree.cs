using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BinarySearchTree<T> where T : IComparable<T>
    {

        #region BinaryNode
        class BinaryNode<T>
        {
            public T data;          //is there a better way to access this field besides making it public?
            BinaryNode<T> left;
            BinaryNode<T> right;

            //Constructor with subtrees passed in
            BinaryNode(T element, BinaryNode<T> leftTree, BinaryNode<T> rightTree)
            {
                data = element;
                left = leftTree;
                right = rightTree;
            }

            //Constructor assuming there are no children for this node (e.g. either a leaf or a new root)
            BinaryNode(T element)
            {
                data = element;
                left = null;
                right = null;
            }
        }
        #endregion

        private BinaryNode<T> root;
        
        //constructor for a new, empty Tree
        public BinarySearchTree()
        {
            root = null;
        }
        
        #region public methods
        public void makeEmpty()
        {
            root = null;
        }

        public bool isEmpty()
        {
            return root == null;
        }

        public bool contains(T element)
        {
            return contains(element, root);
        }   

        public T findMin()
        {
            //Implement underflow exception?
            if (isEmpty()) throw new Exception();
            return findMin(root).data;
        } 

        //public T findMax()
        
        public void insert(T element)
        {
            root = insert(element, root);
        }
        #endregion

        #region private methods
        private bool contains(T element, BinaryNode<T> tree)
        {
            //TODO: write out
            return true;
        }

        private BinaryNode<T> findMin(BinaryNode<T> tree)
        {
            //TODO: implement
            return null;
        }

        //private BinaryNode<T> findMax(BinaryNode<T>)

        private BinaryNode<T> insert(T element, BinaryNode<T> tree)
        {
            //TODO: implement
            return null;
        }
        #endregion
    }
}
