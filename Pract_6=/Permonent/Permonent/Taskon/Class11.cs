public class LogicExpressionsTask11
{
    public int X { get; set; }
    public int Y { get; set; }

    public LogicExpressionsTask11(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpressionA()
    {
        return !(X * Y < 1) && (Y > X);
    }
}