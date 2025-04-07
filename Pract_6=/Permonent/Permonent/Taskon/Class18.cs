public class LogicExpressionsTask18
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    public LogicExpressionsTask18(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool EvaluateExpression()
    {
        return (A < 45 && B >= 45 && C >= 45) ||
               (B < 45 && A >= 45 && C >= 45) ||
               (C < 45 && A >= 45 && B >= 45);
    }
}