public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        } else if (value == Data) {
            return;
        } else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data) {
            return true;
        } else if (value < Data) {
            if (Left is null) {
                return false;
            } else {
                return Left.Contains(value);
            }
        } else if (value > Data) {
            if (Right is null) {
                return false;
            } else {
                return Right.Contains(value);
            }
                
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (this.Right == null && this.Left == null){
            return 1;
        }
        int leftHeight = 0;
        int rightHeight = 0;

        if (this.Left != null) {
            leftHeight = this.Left.GetHeight();
        } else {
            leftHeight = 0;
        }

        if (this.Right != null) {
            rightHeight = this.Right.GetHeight();
        } else {
            rightHeight = 0;
        }

        if (leftHeight < rightHeight) {
            return rightHeight + 1;
        } else {
            return leftHeight + 1;
        }
    }
}