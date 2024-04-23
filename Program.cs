public class Program
{
    public static void Main()
    {
        // Visual rep: https://i.imgur.com/RqsjwEX.png
        // tree nodes
        var root = new TreeNode<string>("Root");
        var child1 = new TreeNode<string>("Child1");
        var child2 = new TreeNode<string>("Child2");
        var child11 = new TreeNode<string>("Child1-1");
        var child12 = new TreeNode<string>("Child1-2");
        var child21 = new TreeNode<string>("Child2-1");
        var child22 = new TreeNode<string>("Child2-2");

        // the tree
        root.AddChild(child1);
        root.AddChild(child2);
        child1.AddChild(child11);
        child1.AddChild(child12);
        child2.AddChild(child21);
        child2.AddChild(child22);

        Console.WriteLine("Depth-First Traversal:");
        foreach (var value in root.DepthFirstTraversal())
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("\nBreadth-First Traversal:");
        foreach (var value in root.BreadthFirstTraversal())
        {
            Console.WriteLine(value);
        }
    }
}
