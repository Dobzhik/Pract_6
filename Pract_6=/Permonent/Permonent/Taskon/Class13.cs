public class LogicExpressionsTask13
{
    public int A { get; set; }

    public LogicExpressionsTask13(int a)
    {
        A = a;
    }

    public bool EvaluateExpression()
    {
        return (A < -10 || A > -1) && (A < 2 || A > 15);
    }
}