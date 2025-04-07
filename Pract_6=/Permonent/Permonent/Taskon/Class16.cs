public class LogicExpressionsTask16
{
    public double X { get; set; }
    public double Y { get; set; }

    public LogicExpressionsTask16(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpressionA()
    {
        return !(X > 0 && X < 5);
    }

    public bool EvaluateExpressionB()
    {
        return (0 < Y && Y <= 6) && X < 7;
    }
}