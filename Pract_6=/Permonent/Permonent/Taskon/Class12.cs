public class LogicExpressionsTask12
{
    public double X { get; set; }
    public double Y { get; set; }

    public LogicExpressionsTask12(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool EvaluateExpressionA()
    {
        return !(X <= -5 && X > 5);
    }

    public bool EvaluateExpressionB()
    {
        return (-3.5 < Y && Y <= 8.1) && X != 0;
    }
}