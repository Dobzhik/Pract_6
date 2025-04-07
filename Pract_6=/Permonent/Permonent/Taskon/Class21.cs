public class LogicExpressionsTask21
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public LogicExpressionsTask21(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpression()
    {
        return (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) ||
               (Y % 5 == 0 && X % 5 != 0 && Z % 5 != 0) ||
               (Z % 5 == 0 && X % 5 != 0 && Y % 5 != 0);
    }
}