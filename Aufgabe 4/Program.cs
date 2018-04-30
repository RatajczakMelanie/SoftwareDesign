using System;
using System.Collections.Generic;

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
             child1.Remove_Child(grand12);
            root.PrintTree(""); 
        }
        
        public class TreeNode<T>{
            private T _item;
            private TreeNode<T> _parentNode;
            private List <TreeNode<T>> _children;
            
            public TreeNode()
            {
            }
            public TreeNode<T> CreateNode(T item)
            {
                TreeNode<T> node = new TreeNode<T>();
                node._item = item;
                
                return node;
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
              
           
             

            public void Append_Child(TreeNode<T> child)
            {   
                if (_children == null)
                _children = new List<TreeNode<T>>{child};
                else
                 _children.Add(child);
                
                
                child._parentNode = this;
                 
            }

            public void Remove_Child(TreeNode<T> child){
                    _children.Remove(child);
            }

            public void PrintTree(String Sternchen){
                Console.WriteLine(Sternchen + _item.ToString());
                if(_children != null){
                    foreach(var child in _children){
                        child.PrintTree(Sternchen + "*");
                    }
                }
            }
        }   

    
    }
}
