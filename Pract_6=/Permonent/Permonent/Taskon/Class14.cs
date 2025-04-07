public class LogicExpressionsTask14
{
    public int A { get; set; }

    public LogicExpressionsTask14(int a)
    {
        A = a;
    }

    public bool EvaluateExpression()
    {
        return A >= 1000 && A <= 9999 && A != 4999;
    }
}