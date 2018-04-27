using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe_4
{
        
    class Program
    {
        static void Main(string[] args)
        {
             var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child1");
            root.Append_Child(child1);
            root.Append_Child(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.Append_Child(grand11);
            child1.Append_Child(grand12);
            child1.Append_Child(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.Append_Child(grand21);
            // child1.RemoveChild(grand12);

            //root.PrintTree(); 
        }
        
        public class TreeNode<T>{
            private T _item;
            private TreeNode<T> _parentNode;
            private TreeNode<T>[] _children;
            private int _n = 0;
            
            public TreeNode()
            {
            }
            public TreeNode(T item)
            {
                _item= item;
            }
            public TreeNode(T item, TreeNode<T> _parentNode)
            {
                _item = item;
                _parentNode.Append_Child(this);
            }
             public TreeNode<T> CreateNode(T item)
                {
                    TreeNode<T> node = new TreeNode<T>(item);
                    return node;
                }
            public class Tree <G>
            {
               
            }
             

            public void Append_Child(TreeNode<T> child)
            {   
                // If necessary, grow the array
                if (_n == _children.Length)
                {
                    TreeNode<T>[] oldArray = _children;
                    _children = new TreeNode<T>[oldArray.Length+1];
                    Array.Copy(oldArray, _children, _n);
                    
                }
                _children[_n] = child;
                child._parentNode = this;
                _n++;



                
            }

            

            public void Remove_Child(TreeNode<T> child, TreeNode<T> parentNode){
                    
            }
        }   

    
    }
}
