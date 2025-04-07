﻿public class LogicExpressionsTask10
{
    public bool A { get; set; }
    public bool B { get; set; }
    public bool C { get; set; }

    public LogicExpressionsTask10(bool a, bool b, bool c)
    {
        A = a;
        B = b;
        C = c;
    }

    public bool EvaluateExpressionA()
    {
        return A || !(A && B) || C;
    }

    public bool EvaluateExpressionB()
    {
        return !A || C && !(B || C);
    }

    public bool EvaluateExpressionC()
    {
        return (A || B && !C) || A;
    }
}