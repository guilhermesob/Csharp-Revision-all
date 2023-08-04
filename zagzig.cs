
// C# program to print level order traversal
// in spiral form using a single dequeue
using System;
class GFG
{  
public class Node
{
    public int data;
    public Node left, right;
};
 
// A utility function to create a new node
static Node newNode(int data)
{
    Node node = new Node();
    node.data = data;
    node.left = node.right = null;
    return (node);
}
 
// function to print the level order traversal
static void levelOrder( Node root, int n)
{
    // We can just take the size as H+N which
    // implies the height of the tree with the
    // size of the tree
    Node []queue = new Node[2 * n];
     
    for(int i = 0; i < 2 * n; i++)
        queue[i] = new Node();
     
    int top = -1;
    int front = 1;
    queue[++top] = null;
    queue[++top] = root;
    queue[++top] = null;
 
    // Node t=root;
    int prevFront = 0, count = 1;
    while (true)
    {
 
        Node curr = queue[front];
 
        // A level separator found
        if (curr == null)
        {
 
            // If this is the only item in dequeue
            if (front == top)
                break;
 
            // Else print contents of previous level
            // according to count
            else
            {
                if (count % 2 == 0)
                {
                    for (int i = prevFront + 1;
                             i < front; i++)
                        Console.Write(" " + queue[i].data);
                }
                else
                {
                    for (int i = front - 1;
                             i > prevFront; i--)
                        Console.Write(" " + queue[i].data);
                }
 
                prevFront = front;
                count++;
                front++;
 
                // Insert a new level separator
                queue[++top] = null;
 
                continue;
            }
        }
 
        if (curr.left != null)
            queue[++top] = curr.left;
        if (curr.right != null)
            queue[++top] = curr.right;
        front++;
    }
 
    if (count % 2 == 0)
    {
        for (int i = prevFront + 1; i < top; i++)
            Console.Write(" " + queue[i].data);
    }
    else
    {
        for (int i = top - 1; i > prevFront; i--)
            Console.Write(" " + queue[i].data);
    }
}
 
// Driver code
public static void Main(String []args)
{
    Node root = newNode(1);
    root.left = newNode(2);
    root.right = newNode(3);
    root.left.left = newNode(7);
    root.left.right = newNode(6);
    root.right.left = newNode(5);
    root.right.right = newNode(4);
    levelOrder(root, 7);
}
}
