namespace LogicExpressionsSolver
{
    public class LogicExpressionsTask1
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }

        public LogicExpressionsTask1(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool EvaluateExpressionA()
        {
            return (A || (!A && B)) || C;
        }

        public bool EvaluateExpressionB()
        {
            return !A || (A && (B || C));
        }

        public bool EvaluateExpressionC()
        {
            return ((A || B) && !C) && A;
        }
    }

    public class LogicExpressionsTask2
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public LogicExpressionsTask2(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool EvaluateExpression1()
        {
            return X && !(Z || Y) || !Z;
        }

        public bool EvaluateExpression2()
        {
            return !X || X && (Y || Z);
        }

        public bool EvaluateExpression3()
        {
            return (X || Y && !Z) && Z;
        }
    }

    public class LogicExpressionsTask3
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LogicExpressionsTask3(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpression1()
        {
            return !(X * Y < 0) && (Y > X);
        }

        public bool EvaluateExpression2()
        {
            return (X >= 2) || (Y * Y != 5);
        }
    }

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

    public class LogicExpressionsTask6
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public LogicExpressionsTask6(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool EvaluateExpression1()
        {
            return X || Y && !Z;
        }

        public bool EvaluateExpression2()
        {
            return !X && !Y;
        }

        public bool EvaluateExpression3()
        {
            return !(X && Z) || Y;
        }
    }

    public class LogicExpressionsTask7
    {
        public double X { get; set; }

        public LogicExpressionsTask7(double x)
        {
            X = x;
        }

        public bool EvaluateExpressionA()
        {
            return X != Math.PI / 2 + Math.PI * 1; 
        }

        public bool EvaluateExpressionB()
        {
            return X != 1; 
        }
    }

    public class LogicExpressionsTask8
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LogicExpressionsTask8(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return (X >= 0) && (Y * Y != 4);
        }

        public bool EvaluateExpressionB()
        {
            return (X * Y != 0) || (Y > X);
        }
    }

    public class LogicExpressionsTask9
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LogicExpressionsTask9(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return !(X * Y < 0) || (Y > X);
        }

        public bool EvaluateExpressionB()
        {
            return (X * Y != 0) && (Y < X);
        }
    }

    public class LogicExpressionsTask10
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

    public class LogicExpressionsTask11
    {
        public int X { get; set; }
        public int Y { get; set; }

        public LogicExpressionsTask11(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return !(X * Y < 1) && (Y > X);
        }
    }

    public class LogicExpressionsTask12
    {
        public double X { get; set; }
        public double Y { get; set; }

        public LogicExpressionsTask12(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return !(X <= -5 && X > 5);
        }

        public bool EvaluateExpressionB()
        {
            return (-3.5 < Y && Y <= 8.1) && X != 0;
        }
    }

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

    public class LogicExpressionsTask14
    {
        public int A { get; set; }

        public LogicExpressionsTask14(int a)
        {
            A = a;
        }

        public bool EvaluateExpression()
        {
            return A >= 1000 && A <= 9999 && A != 4999;
        }
    }

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

    public class LogicExpressionsTask16
    {
        public double X { get; set; }
        public double Y { get; set; }

        public LogicExpressionsTask16(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return !(X > 0 && X < 5);
        }

        public bool EvaluateExpressionB()
        {
            return (0 < Y && Y <= 6) && X < 7;
        }
    }

    public class LogicExpressionsTask17
    {
        public double X { get; set; }

        public LogicExpressionsTask17(double x)
        {
            X = x;
        }

        public bool EvaluateExpressionA()
        {
            return X > 3 || X < -1;
        }
    }

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

    public class LogicExpressionsTask19
    {
        public int A { get; set; }

        public LogicExpressionsTask19(int a)
        {
            A = a;
        }

        public bool EvaluateExpression()
        {
            return A % 3 != 0 && A % 10 == 0;
        }
    }

    public class LogicExpressionsTask20
    {
        public int A { get; set; }

        public LogicExpressionsTask20(int a)
        {
            A = a;
        }

        public bool EvaluateExpression()
        {
            return (A >= -137 && A <= -51) || (A >= 55 && A <= 123);
        }
    }

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

    public class LogicExpressionsTask23
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }

        public LogicExpressionsTask23(bool a, bool b, bool c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool EvaluateExpressionA()
        {
            return A && !B || C;
        }

        public bool EvaluateExpressionB()
        {
            return A && (!B || C);
        }

        public bool EvaluateExpressionC()
        {
            return A || (!(B && C));
        }
    }

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

    public class LogicExpressionsTask25
    {
        public double X { get; set; }

        public LogicExpressionsTask25(double x)
        {
            X = x;
        }

        public bool EvaluateExpressionA()
        {
            return X != 0; 
        }

        public bool EvaluateExpressionB()
        {
            return X != 3; 
        }
    }

    public class LogicExpressionsTask26
    {
        public bool X { get; set; }
        public bool Y { get; set; }
        public bool Z { get; set; }

        public LogicExpressionsTask26(bool x, bool y, bool z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool EvaluateExpressionA()
        {
            return (X && !Y) || Z;
        }

        public bool EvaluateExpressionB()
        {
            return X && (!Y || Z);
        }

        public bool EvaluateExpressionC()
        {
            return X || (!(Y || Z));
        }
    }

    public class LogicExpressionsTask27
    {
        public double X { get; set; }
        public double Y { get; set; }

        public LogicExpressionsTask27(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool EvaluateExpressionA()
        {
            return !(X > 0 && X < 5);
        }

        public bool EvaluateExpressionB()
        {
            return (0 < Y && Y <= 6) && X < 7;
        }
    }

    public class LogicExpressionsTask28
    {
        public double X { get; set; }

        public LogicExpressionsTask28(double x)
        {
            X = x;
        }

        public bool EvaluateExpression()
        {
            return X != 3; 
        }
    }

    public class LogicExpressionsTask29
    {
        public double X { get; set; }

        public LogicExpressionsTask29(double x)
        {
            X = x;
        }

        public bool EvaluateExpression()
        {
            return X != Math.PI / 2 * 1; 
        }
    }

    public class LogicExpressionsTask30
    {
        public double X { get; set; }

        public LogicExpressionsTask30(double x)
        {
            X = x;
        }

        public bool EvaluateExpression()
        {
            return X != 0; 
        }
    }
}