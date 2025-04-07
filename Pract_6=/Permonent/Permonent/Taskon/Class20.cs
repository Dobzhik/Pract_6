public class LogicExpressionsTask20
{
    public int A { get; set; }

    public LogicExpressionsTask20(int a)
    {
        A = a;
    }

    public bool EvaluateExpression()
    {
        return (A >= -137 && A <= -51) || (A >= 55 && A <= 123);
    }
}