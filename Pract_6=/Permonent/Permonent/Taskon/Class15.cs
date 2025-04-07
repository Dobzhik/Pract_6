public class LogicExpressionsTask15
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get; set; }

    public LogicExpressionsTask15(double a, double b, double c, double d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }

    public bool EvaluateExpression()
    {
        return (A / B) > (C / D);
    }
}