public class LogicExpressionsTask4
{
    public int A { get; set; }

    public LogicExpressionsTask4(int a)
    {
        A = a;
    }

    public bool EvaluateExpression()
    {
        return A % 2 == 0 || A % 3 == 0;
    }
}