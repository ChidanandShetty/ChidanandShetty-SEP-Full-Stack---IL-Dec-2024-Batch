class Program
{
    static void Main()
    {
        Color redColor = new Color(255, 0, 0);
        Ball redBall = new Ball(5, redColor);

        redBall.Throw();
        redBall.Throw();
        redBall.Pop();
        redBall.Throw(); // Should not count as it's popped

        Console.WriteLine("Red Ball Throw Count: " + redBall.GetThrowCount());
    }
}
