public class LogicExpressionsTask26
{
    public bool X { get; set; }
    public bool Y { get; set; }
    public bool Z { get; set; }

    public LogicExpressionsTask26(bool x, bool y, bool z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpressionA()
    {
        return (X && !Y) || Z;
    }

    public bool EvaluateExpressionB()
    {
        return X && (!Y || Z);
    }

    public bool EvaluateExpressionC()
    {
        return X || (!(Y || Z));
    }
}