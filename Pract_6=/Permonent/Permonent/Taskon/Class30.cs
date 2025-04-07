public class LogicExpressionsTask30
{
    public double X { get; set; }

    public LogicExpressionsTask30(double x)
    {
        X = x;
    }

    public bool EvaluateExpression()
    {
        return X != 0; 
    }
}