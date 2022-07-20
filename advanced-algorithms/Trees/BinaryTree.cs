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

        public List<T> InOrderTraversal() {
            List<T> Result = new List<T>();
            InOrderTraversalHelper(Head, Result);
            return Result;
        }

        public void InOrderTraversalHelper(BinaryTreeNode<T> currentNode, List<T> result)
        {
            if(currentNode != null)
            {
                InOrderTraversalHelper(currentNode.Left, result);
                Console.WriteLine(currentNode.Value);
                result.Add(currentNode.Value);
                InOrderTraversalHelper(currentNode.Right, result);
            }
        }

        public List<T> PreOrderTraversal() {
            List<T> Result = new List<T>();
            PreOrderTraversalHelper(Head, Result);
            return Result;
        }

        public void PreOrderTraversalHelper(BinaryTreeNode<T> currentNode, List<T> result) {
            if (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                result.Add(currentNode.Value);
                PreOrderTraversalHelper(currentNode.Left, result);
                PreOrderTraversalHelper(currentNode.Right, result);
            }
        }

        public List<T> PostOrderTraveral() {
            List<T> Result = new List<T>();
            PostOrderTraversalHelper(Head, Result);
            return Result;
        }

        public void PostOrderTraversalHelper(BinaryTreeNode<T> currentNode, List<T> result)
        {
            if (currentNode != null)
            {
                PostOrderTraversalHelper(currentNode.Left, result);
                PostOrderTraversalHelper(currentNode.Right, result);
                Console.WriteLine(currentNode.Value);
                result.Add(currentNode.Value);
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

        public bool IsFullBinaryTree() {
            return IsFullBinaryTreeHelper(Head);
        }

        public bool IsFullBinaryTreeHelper(BinaryTreeNode<T> currentNode) {
            if (currentNode == null) return true;

            if (currentNode.Left == null && currentNode.Right != null) return false;

            if (currentNode.Left != null && currentNode.Right == null) return false;

            return IsFullBinaryTreeHelper(currentNode.Left) && IsFullBinaryTreeHelper(currentNode.Right);
        }


        public bool IsPerfectNode(BinaryTreeNode<T> targetNode)
        {
            if(targetNode == null) return true;
            return false;

         }
        public bool IsPerfectBinaryTree(BinaryTreeNode<T> targetNode) {

            return false;
        }
    }
}
