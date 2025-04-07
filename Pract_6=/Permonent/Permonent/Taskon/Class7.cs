public class LogicExpressionsTask7
{
    public double X { get; set; }

    public LogicExpressionsTask7(double x)
    {
        X = x;
    }

    public bool EvaluateExpressionA()
    {
        return X != Math.PI / 2 + Math.PI * 1; 
    }

    public bool EvaluateExpressionB()
    {
        return X != 1; 
    }
}