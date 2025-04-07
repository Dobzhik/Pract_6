public class LogicExpressionsTask8
{
    public int X { get; set; }
    public int Y { get; set; }

    public LogicExpressionsTask8(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpressionA()
    {
        return (X >= 0) && (Y * Y != 4);
    }

    public bool EvaluateExpressionB()
    {
        return (X * Y != 0) || (Y > X);
    }
}