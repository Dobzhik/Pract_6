public class LogicExpressionsTask24
{
    public bool A { get; set; }
    public bool B { get; set; }
    public bool C { get; set; }

    public LogicExpressionsTask24(bool a, bool b, bool c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool EvaluateExpressionA()
    {
        return (!A || !B) && !C;
    }

    public bool EvaluateExpressionB()
    {
        return (!A || !B) && (A || B);
    }

    public bool EvaluateExpressionC()
    {
        return A && B || A && C || !C;
    }
}