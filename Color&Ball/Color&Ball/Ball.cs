class Ball
{
    private int Size;
    private Color BallColor;
    private int ThrowCount;

    public Ball(int size, Color color)
    {
        Size = size;
        BallColor = color;
        ThrowCount = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public void Throw()
    {
        if (Size > 0)
            ThrowCount++;
    }

    public int GetThrowCount()
    {
        return ThrowCount;
    }
}
