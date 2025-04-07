public class LogicExpressionsTask6
{
    public bool A { get; set; }
    public bool B { get; set; }
    public bool C { get; set; }

    public LogicExpressionsTask6(bool a, bool b, bool c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool EvaluateExpression1()
    {
        return (A || B) && C;
    }

    public bool EvaluateExpression2()
    {
        return !(A && B) || C;
    }

    public bool EvaluateExpression3()
    {
        return (A || C) && !(B || C);
    }
}
