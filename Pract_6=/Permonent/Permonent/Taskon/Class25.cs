public class LogicExpressionsTask25
{
    public double X { get; set; }

    public LogicExpressionsTask25(double x)
    {
        X = x;
    }

    public bool EvaluateExpressionA()
    {
        return X != 0;
    }

    public bool EvaluateExpressionB()
    {
        return X != 3; 
    }
}