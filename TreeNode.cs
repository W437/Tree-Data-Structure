public class TreeNode<T>
{
    public T Value { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(T value)
    {
        Value = value;
        Children = new List<TreeNode<T>>();
    }

    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }

    public IEnumerable<T> DepthFirstTraversal()
    {
        Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
        stack.Push(this); // r00t

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            yield return current.Value;
            for (int i = current.Children.Count - 1; i >= 0; i--) // push in reverse order
            {
                stack.Push(current.Children[i]);
            }
        }
    }

    public IEnumerable<T> BreadthFirstTraversal()
    {
        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(this);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            yield return current.Value;
            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }
    }

}
