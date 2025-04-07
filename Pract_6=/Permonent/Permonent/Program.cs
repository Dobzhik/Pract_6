using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите номер задания от 1 до 30:");
            Console.WriteLine("0. Выход");
            Console.Write("Введите номер задания: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    SolveTask1();
                    break;
                case "2":
                    SolveTask2();
                    break;
                case "3":
                    SolveTask3();
                    break;
                case "4":
                    SolveTask4();
                    break;
                case "5":
                    SolveTask5();
                    break;
                case "6":
                    SolveTask6();
                    break;
                case "7":
                    SolveTask7();
                    break;
                case "8":
                    SolveTask8();
                    break;
                case "9":
                    SolveTask9();
                    break;
                case "10":
                    SolveTask10();
                    break;
                case "11":
                    SolveTask11();
                    break;
                case "12":
                    SolveTask12();
                    break;
                case "13":
                    SolveTask13();
                    break;
                case "14":
                    SolveTask14();
                    break;
                case "15":
                    SolveTask15();
                    break;
                case "16":
                    SolveTask16();
                    break;
                case "17":
                    SolveTask17();
                    break;
                case "18":
                    SolveTask18();
                    break;
                case "19":
                    SolveTask19();
                    break;
                case "20":
                    SolveTask20();
                    break;
                case "21":
                    SolveTask21();
                    break;
                case "22":
                    SolveTask22();
                    break;
                case "23":
                    SolveTask23();
                    break;
                case "24":
                    SolveTask24();
                    break;
                case "25":
                    SolveTask25();
                    break;
                case "26":
                    SolveTask26();
                    break;
                case "27":
                    SolveTask27();
                    break;
                case "28":
                    SolveTask28();
                    break;
                case "29":
                    SolveTask29();
                    break;
                case "30":
                    SolveTask30();
                    break;
                case "0":
                    Console.WriteLine("Выход...");
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void SolveTask1()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        LogicExpressionsTask1 logicTask1 = new LogicExpressionsTask1(A, B, C);
        bool resultA = logicTask1.EvaluateExpressionA();
        bool resultB = logicTask1.EvaluateExpressionB();
        bool resultC = logicTask1.EvaluateExpressionC();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask2()
    {
        bool X = false;
        bool Y = true;
        bool Z = false;

        LogicExpressionsTask2 logicTask2 = new LogicExpressionsTask2(X, Y, Z);
        bool result1 = logicTask2.EvaluateExpression1();
        bool result2 = logicTask2.EvaluateExpression2();
        bool result3 = logicTask2.EvaluateExpression3();

        Console.Clear();
        Console.WriteLine($"a) {result1}");
        Console.WriteLine($"б) {result2}");
        Console.WriteLine($"в) {result3}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask3()
    {
        int x = 2;
        int y = 1;

        LogicExpressionsTask3 logicTask3 = new LogicExpressionsTask3(x, y);
        bool result1 = logicTask3.EvaluateExpression1();
        bool result2 = logicTask3.EvaluateExpression2();

        Console.Clear();
        Console.WriteLine($"a) {result1}");
        Console.WriteLine($"б) {result2}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask4()
    {
        int A = 6;

        LogicExpressionsTask4 logicTask4 = new LogicExpressionsTask4(A);
        bool result = logicTask4.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask5()
    {
        int A = 3;
        int B = 5;

        LogicExpressionsTask5 logicTask5 = new LogicExpressionsTask5(A, B);
        bool result = logicTask5.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask6()
    {
        bool X = false;
        bool Y = false;
        bool Z = true;

        LogicExpressionsTask6 logicTask6 = new LogicExpressionsTask6(X, Y, Z);
        bool result1 = logicTask6.EvaluateExpression1();
        bool result2 = logicTask6.EvaluateExpression2();
        bool result3 = logicTask6.EvaluateExpression3();

        Console.Clear();
        Console.WriteLine($"a) {result1}");
        Console.WriteLine($"б) {result2}");
        Console.WriteLine($"в) {result3}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask7()
    {
        double x = 1.5;

        LogicExpressionsTask7 logicTask7 = new LogicExpressionsTask7(x);
        bool resultA = logicTask7.EvaluateExpressionA();
        bool resultB = logicTask7.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask8()
    {
        int x = 1;
        int y = 2;

        LogicExpressionsTask8 logicTask8 = new LogicExpressionsTask8(x, y);
        bool resultA = logicTask8.EvaluateExpressionA();
        bool resultB = logicTask8.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask9()
    {
        int x = 2;
        int y = 1;

        LogicExpressionsTask9 logicTask9 = new LogicExpressionsTask9(x, y);
        bool resultA = logicTask9.EvaluateExpressionA();
        bool resultB = logicTask9.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask10()
    {
        bool A = true;
        bool B = false;
        bool C = true;

        LogicExpressionsTask10 logicTask10 = new LogicExpressionsTask10(A, B, C);
        bool resultA = logicTask10.EvaluateExpressionA();
        bool resultB = logicTask10.EvaluateExpressionB();
        bool resultC = logicTask10.EvaluateExpressionC();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask11()
    {
        int x = 1;
        int y = 2;

        LogicExpressionsTask11 logicTask11 = new LogicExpressionsTask11(x, y);
        bool resultA = logicTask11.EvaluateExpressionA();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask12()
    {
        double x = 6;
        double y = 4;

        LogicExpressionsTask12 logicTask12 = new LogicExpressionsTask12(x, y);
        bool resultA = logicTask12.EvaluateExpressionA();
        bool resultB = logicTask12.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask13()
    {
        int A = 5;

        LogicExpressionsTask13 logicTask13 = new LogicExpressionsTask13(A);
        bool result = logicTask13.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask14()
    {
        int A = 1234;

        LogicExpressionsTask14 logicTask14 = new LogicExpressionsTask14(A);
        bool result = logicTask14.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask15()
    {
        double A = 1;
        double B = 2;
        double C = 3;
        double D = 4;

        LogicExpressionsTask15 logicTask15 = new LogicExpressionsTask15(A, B, C, D);
        bool result = logicTask15.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask16()
    {
        double x = 3;
        double y = 4;

        LogicExpressionsTask16 logicTask16 = new LogicExpressionsTask16(x, y);
        bool resultA = logicTask16.EvaluateExpressionA();
        bool resultB = logicTask16.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask17()
    {
        double x = 4;

        LogicExpressionsTask17 logicTask17 = new LogicExpressionsTask17(x);
        bool resultA = logicTask17.EvaluateExpressionA();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask18()
    {
        int A = 40;
        int B = 50;
        int C = 60;

        LogicExpressionsTask18 logicTask18 = new LogicExpressionsTask18(A, B, C);
        bool result = logicTask18.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask19()
    {
        int A = 30;

        LogicExpressionsTask19 logicTask19 = new LogicExpressionsTask19(A);
        bool result = logicTask19.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask20()
    {
        int A = -100;

        LogicExpressionsTask20 logicTask20 = new LogicExpressionsTask20(A);
        bool result = logicTask20.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask21()
    {
        int X = 10;
        int Y = 15;
        int Z = 20;

        LogicExpressionsTask21 logicTask21 = new LogicExpressionsTask21(X, Y, Z);
        bool result = logicTask21.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask22()
    {
        int X = 85;
        int Y = 75;
        int Z = 90;

        LogicExpressionsTask22 logicTask22 = new LogicExpressionsTask22(X, Y, Z);
        bool result = logicTask22.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask23()
    {
        bool A = true;
        bool B = false;
        bool C = true;

        LogicExpressionsTask23 logicTask23 = new LogicExpressionsTask23(A, B, C);
        bool resultA = logicTask23.EvaluateExpressionA();
        bool resultB = logicTask23.EvaluateExpressionB();
        bool resultC = logicTask23.EvaluateExpressionC();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask24()
    {
        bool A = false;
        bool B = true;
        bool C = false;

        LogicExpressionsTask24 logicTask24 = new LogicExpressionsTask24(A, B, C);
        bool resultA = logicTask24.EvaluateExpressionA();
        bool resultB = logicTask24.EvaluateExpressionB();
        bool resultC = logicTask24.EvaluateExpressionC();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask25()
    {
        double x = 2;

        LogicExpressionsTask25 logicTask25 = new LogicExpressionsTask25(x);
        bool resultA = logicTask25.EvaluateExpressionA();
        bool resultB = logicTask25.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask26()
    {
        bool X = true;
        bool Y = false;
        bool Z = true;

        LogicExpressionsTask26 logicTask26 = new LogicExpressionsTask26(X, Y, Z);
        bool resultA = logicTask26.EvaluateExpressionA();
        bool resultB = logicTask26.EvaluateExpressionB();
        bool resultC = logicTask26.EvaluateExpressionC();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask27()
    {
        double x = 3;
        double y = 5;

        LogicExpressionsTask27 logicTask27 = new LogicExpressionsTask27(x, y);
        bool resultA = logicTask27.EvaluateExpressionA();
        bool resultB = logicTask27.EvaluateExpressionB();

        Console.Clear();
        Console.WriteLine($"a) {resultA}");
        Console.WriteLine($"б) {resultB}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask28()
    {
        double x = 4;

        LogicExpressionsTask28 logicTask28 = new LogicExpressionsTask28(x);
        bool result = logicTask28.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask29()
    {
        double x = 1;

        LogicExpressionsTask29 logicTask29 = new LogicExpressionsTask29(x);
        bool result = logicTask29.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }

    static void SolveTask30()
    {
        double x = 2;

        LogicExpressionsTask30 logicTask30 = new LogicExpressionsTask30(x);
        bool result = logicTask30.EvaluateExpression();

        Console.Clear();
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
        Console.ReadKey();
    }
}