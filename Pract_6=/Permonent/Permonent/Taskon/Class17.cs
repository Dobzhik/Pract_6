public class LogicExpressionsTask17
{
    public double X { get; set; }

    public LogicExpressionsTask17(double x)
    {
        X = x;
    }

    public bool EvaluateExpressionA()
    {
        return X > 3 || X < -1;
    }
}