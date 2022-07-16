namespace advanced_algorithms.Trees
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T>? Left { get; set; }

        public BinaryTreeNode<T>? Right { get; set; }        
    }    
}
