using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInOrder
{
    internal class Tree
    {
        public Node root;
        public Tree() 
        {
            this.root = null;
        }
        public Node returnroot() 
        { return root; }

        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                Node parent;

                while(true)
                {
                    parent = currentNode;
                    if (id < currentNode.item)
                    {
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void Inorder(Node root)
        {
            if(root != null)
            {
                Inorder(root.Left);
                Console.Write($"{root.item} ");
                Inorder(root.Right);
                
            }
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.Left);
                Preorder(Root.Right);
            }
        }
        public void Postorder(Node Root)
        {
            if(Root != null)
            {
                Postorder(Root.Left);
                Postorder(Root.Right);
                Console.Write(Root.item + " ");
            }
        }
    }
}
