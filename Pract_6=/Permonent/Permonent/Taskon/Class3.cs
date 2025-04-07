public class LogicExpressionsTask3
{
    public int X { get; set; }
    public int Y { get; set; }

    public LogicExpressionsTask3(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpression1()
    {
        return !(X * Y < 0) && (Y > X);
    }

    public bool EvaluateExpression2()
    {
        return (X >= 2) || (Y * Y != 5);
    }
}

