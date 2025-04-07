public class LogicExpressionsTask5
{
    public int A { get; set; }
    public int B { get; set; }

    public LogicExpressionsTask5(int a, int b)
    {
        A = a;
        B = b;
    }

    public bool EvaluateExpression()
    {
        return A % 2 != 0 && B % 2 != 0;
    }
}