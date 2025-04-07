public class LogicExpressionsTask2
{
    public bool X { get; set; }
    public bool Y { get; set; }
    public bool Z { get; set; }

    public LogicExpressionsTask2(bool x, bool y, bool z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpression1()
    {
        return X || (Z || Y);
    }

    public bool EvaluateExpression2()
    {
        return !X && X || Y || Z;
    }

    public bool EvaluateExpression3()
    {
        return (X || Y) && Z;
    }
}
