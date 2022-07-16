namespace advanced_algorithms.Trees
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Head { get; set; }

        public void SimpleInsertNode(T value)
        {
            if (Head == null)
            {
                Head = new BinaryTreeNode<T> { Value = value };
            }
            else
            {
                SimpleInsertNode(value, Head);
            }
        }

        public void SimpleInsertNode(T value, BinaryTreeNode<T> targetNode)
        {
            var current = new Queue<BinaryTreeNode<T>>();
            var next = new Queue<BinaryTreeNode<T>>();

            current.Enqueue(targetNode);

            while (current.Count > 0)
            {
                var item = current.Dequeue();
                if(item.Left == null)
                {
                    item.Left = new BinaryTreeNode<T> { Value = value };
                    return;
                }else if(item.Right == null)
                {
                    item.Right = new BinaryTreeNode<T> { Value = value };
                    return;
                }
                else
                {
                    next.Enqueue(item.Left);
                    next.Enqueue(item.Right);

                    if(current.Count == 0)
                    {
                        current = next;
                    }
                }
            }

        } 

        public void InOrderTraversal() {
            InOrderTraversalHelper(Head);
        }

        public void InOrderTraversalHelper(BinaryTreeNode<T> currentNode)
        {
            if(currentNode != null)
            {
                InOrderTraversalHelper(currentNode.Left);
                Console.WriteLine(currentNode.Value);
                InOrderTraversalHelper(currentNode.Right);
            }
        }

        public void PreOrderTraversal() {
            PreOrderTraversalHelper(Head);
        }

        public void PreOrderTraversalHelper(BinaryTreeNode<T> currentNode) {
            if (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                PreOrderTraversalHelper(currentNode.Left);
                PreOrderTraversalHelper(currentNode.Right);
            }
        }

        public void PostOrderTraveral() {
            PostOrderTraversalHelper(Head);
        }

        public void PostOrderTraversalHelper(BinaryTreeNode<T> currentNode)
        {
            if (currentNode != null)
            {
                PostOrderTraversalHelper(currentNode.Left);
                PostOrderTraversalHelper(currentNode.Right);
                Console.WriteLine(currentNode.Value);
            }
        }


        public bool IsCompleteBinaryTreeHelper(BinaryTreeNode<T> currentNode)
        {
            if(currentNode == null)  return true;

            if (currentNode.Left == null && currentNode.Right != null) return false;

            if (currentNode.Left != null && currentNode.Right == null)
            {
                if (currentNode.Left.Left != null || currentNode.Left.Right != null)
                    return false;
            }

            return IsCompleteBinaryTreeHelper(currentNode.Left) && IsCompleteBinaryTreeHelper(currentNode.Right);
        }

        public bool IsCompleteBinaryTree() {

            return IsCompleteBinaryTreeHelper(Head);
        }

        public bool IsFullBinaryTree() { return false; }

        public bool IsPerfectBinaryTree() { return false; }
    }
}
