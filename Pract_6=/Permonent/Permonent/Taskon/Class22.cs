public class LogicExpressionsTask22
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public LogicExpressionsTask22(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool EvaluateExpression()
    {
        return X > 80 || Y > 80 || Z > 80;
    }
}