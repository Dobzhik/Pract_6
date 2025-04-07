public class LogicExpressionsTask9
{
    public int X { get; set; }
    public int Y { get; set; }

    public LogicExpressionsTask9(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpressionA()
    {
        return !(X * Y < 0) || (Y > X);
    }

    public bool EvaluateExpressionB()
    {
        return (X * Y != 0) && (Y < X);
    }
}