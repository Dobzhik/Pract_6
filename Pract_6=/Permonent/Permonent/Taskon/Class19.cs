public class LogicExpressionsTask19
{
    public int A { get; set; }

    public LogicExpressionsTask19(int a)
    {
        A = a;
    }

    public bool EvaluateExpression()
    {
        return A % 3 != 0 && A % 10 == 0;
    }
}