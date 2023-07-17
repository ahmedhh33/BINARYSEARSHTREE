namespace BinarySearchTreeInOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(20);//here 20 is the root becuse it inderted first
            tree.Insert(25);
            tree.Insert(45);
            tree.Insert(15);
            tree.Insert(67);
            tree.Insert(43);
            tree.Insert(80);
            tree.Insert(33);
            tree.Insert(67);
            tree.Insert(99);
            tree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");//prent left then root then right
            tree.Inorder(tree.returnroot());
            Console.WriteLine(" ");
            Console.WriteLine("preorder Traversal : ");//prent root the left then right
            tree.Preorder(tree.returnroot());
            Console.WriteLine(" ");
            Console.WriteLine("postorder Traversal : ");//prent left then right then root
            tree.Postorder(tree.returnroot());
            Console.WriteLine(" ");



            Console.WriteLine("BinarysearshTree class");
            BinarySearshTree binarySearshTree = new BinarySearshTree();
            binarySearshTree.insert(56);//here 56 is the root becuse it inderted first
            binarySearshTree.insert(7);
            binarySearshTree.insert(543);
            binarySearshTree.insert(7);
            binarySearshTree.insert(76);
            binarySearshTree.insert(656);
            binarySearshTree.insert(80);
            binarySearshTree.insert(45);
            binarySearshTree.insert(655);
            binarySearshTree.insert(3);
            binarySearshTree.insert(54);
            Console.WriteLine();
            Console.WriteLine("Inorder Traversal FOR RECURSIVE EXAMBLE : ");
            binarySearshTree.inorder(binarySearshTree.returnroot());//prent left then root then right
            Console.WriteLine(" ");
            Console.WriteLine("preorder Traversal FOR RECURSIVE EXAMBLE : ");
            binarySearshTree.preorder(binarySearshTree.returnroot());//prent root the left then right
            Console.WriteLine(" ");
            Console.WriteLine("postorder Traversal FOR RECURSIVE EXAMBLE : ");
            binarySearshTree.postorder(binarySearshTree.returnroot());//prent the left then right then root
            Console.WriteLine(" ");



        }
    }
}