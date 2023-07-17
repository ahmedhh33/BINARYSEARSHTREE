using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInOrder
{
    internal class BinarySearshTree
    {
        Nodes root;
        public BinarySearshTree() 
        {
            root = null;
        }
        public Nodes returnroot()
        { return root; }
        public void insert(int item)
        {
            root = insert(root, item);
        }

        public Nodes insert(Nodes currentNode,int item)
        {
            if (currentNode == null)
            {
                currentNode = new Nodes(item);
            }

            else if (item<currentNode.item)
            {
                currentNode.Left = insert(currentNode.Left, item);
            }
            else if (item > currentNode.item)
            {
                currentNode.Right = insert(currentNode.Right, item);
            }
            return currentNode;
        }
        public void inorder(Nodes currentNode)
        {
            if (currentNode != null)
            {
                inorder(currentNode.Left);
                Console.Write(currentNode.item+" ");
                inorder(currentNode.Right);
            }
        }
        public void preorder(Nodes currentNode)
        {
            if (currentNode != null)
            {
                Console.Write(currentNode.item + " ");
                preorder(currentNode.Left);
                preorder(currentNode.Right);
            }
        }
        public void postorder(Nodes currentNode)
        {
            if(currentNode != null)
            {
                preorder(currentNode.Left);
                postorder(currentNode.Right);
                Console.Write(currentNode.item+" ");
            }
        }

    }
}
