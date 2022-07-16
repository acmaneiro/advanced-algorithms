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
            if (targetNode.Left == null)
            {
                targetNode.Left = new BinaryTreeNode<T> { Value = value };
            }
            else
            {
                if (targetNode.Right == null)
                {
                    targetNode.Right = new BinaryTreeNode<T> { Value = value };
                }
                else
                {
                    if (targetNode.Left.Left == null || targetNode.Left.Right == null)
                    {
                        SimpleInsertNode(value, targetNode.Left);
                    }
                    else
                    {
                        if (targetNode.Right.Left == null || targetNode.Right.Right == null)
                        {
                            SimpleInsertNode(value, targetNode.Right);
                        }
                        else
                        {
                            SimpleInsertNode(value, targetNode.Left.Left);
                        }
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

        public void PreOrderTraversal() { }

        public void PostOrderTraveral() { }

        public bool IsCompleteBinaryTree() { return false; }

        public bool IsFullBinaryTree() { return false; }

        public bool IsPerfectBinaryTree() { return false; }
    }
}
