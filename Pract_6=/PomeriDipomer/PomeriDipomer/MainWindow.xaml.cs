using System;
using System.Windows;

// made in KaiAngel in 9mice - sponsor OGTimur

namespace LogicExpressionsSolver
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SolveTask1_Click(object sender, RoutedEventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = false;

            LogicExpressionsTask1 logicTask1 = new LogicExpressionsTask1(A, B, C);
            bool resultA = logicTask1.EvaluateExpressionA();
            bool resultB = logicTask1.EvaluateExpressionB();
            bool resultC = logicTask1.EvaluateExpressionC();

            ResultTextBox.Text = $"Задача 1:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
            ResultTextBox.Text += $"в) {resultC}\n";
        }

        private void SolveTask2_Click(object sender, RoutedEventArgs e)
        {
            bool X = false;
            bool Y = true;
            bool Z = false;

            LogicExpressionsTask2 logicTask2 = new LogicExpressionsTask2(X, Y, Z);
            bool result1 = logicTask2.EvaluateExpression1();
            bool result2 = logicTask2.EvaluateExpression2();
            bool result3 = logicTask2.EvaluateExpression3();

            ResultTextBox.Text = $"Задача 2:\n";
            ResultTextBox.Text += $"a) {result1}\n";
            ResultTextBox.Text += $"б) {result2}\n";
            ResultTextBox.Text += $"в) {result3}\n";
        }

        private void SolveTask3_Click(object sender, RoutedEventArgs e)
        {
            int x = 2;
            int y = 1;

            LogicExpressionsTask3 logicTask3 = new LogicExpressionsTask3(x, y);
            bool result1 = logicTask3.EvaluateExpression1();
            bool result2 = logicTask3.EvaluateExpression2();

            ResultTextBox.Text = $"Задача 3:\n";
            ResultTextBox.Text += $"a) {result1}\n";
            ResultTextBox.Text += $"б) {result2}\n";
        }

        private void SolveTask4_Click(object sender, RoutedEventArgs e)
        {
            int A = 6;

            LogicExpressionsTask4 logicTask4 = new LogicExpressionsTask4(A);
            bool result = logicTask4.EvaluateExpression();

            ResultTextBox.Text = $"Задача 4:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask5_Click(object sender, RoutedEventArgs e)
        {
            int A = 3;
            int B = 5;

            LogicExpressionsTask5 logicTask5 = new LogicExpressionsTask5(A, B);
            bool result = logicTask5.EvaluateExpression();

            ResultTextBox.Text = $"Задача 5:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask6_Click(object sender, RoutedEventArgs e)
        {
            bool X = false;
            bool Y = false;
            bool Z = true;

            LogicExpressionsTask6 logicTask6 = new LogicExpressionsTask6(X, Y, Z);
            bool result1 = logicTask6.EvaluateExpression1();
            bool result2 = logicTask6.EvaluateExpression2();
            bool result3 = logicTask6.EvaluateExpression3();

            ResultTextBox.Text = $"Задача 6:\n";
            ResultTextBox.Text += $"a) {result1}\n";
            ResultTextBox.Text += $"б) {result2}\n";
            ResultTextBox.Text += $"в) {result3}\n";
        }

        private void SolveTask7_Click(object sender, RoutedEventArgs e)
        {
            double x = 1.5;

            LogicExpressionsTask7 logicTask7 = new LogicExpressionsTask7(x);
            bool resultA = logicTask7.EvaluateExpressionA();
            bool resultB = logicTask7.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 7:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask8_Click(object sender, RoutedEventArgs e)
        {
            int x = 1;
            int y = 2;

            LogicExpressionsTask8 logicTask8 = new LogicExpressionsTask8(x, y);
            bool resultA = logicTask8.EvaluateExpressionA();
            bool resultB = logicTask8.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 8:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask9_Click(object sender, RoutedEventArgs e)
        {
            int x = 2;
            int y = 1;

            LogicExpressionsTask9 logicTask9 = new LogicExpressionsTask9(x, y);
            bool resultA = logicTask9.EvaluateExpressionA();
            bool resultB = logicTask9.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 9:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask10_Click(object sender, RoutedEventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = true;

            LogicExpressionsTask10 logicTask10 = new LogicExpressionsTask10(A, B, C);
            bool resultA = logicTask10.EvaluateExpressionA();
            bool resultB = logicTask10.EvaluateExpressionB();
            bool resultC = logicTask10.EvaluateExpressionC();

            ResultTextBox.Text = $"Задача 10:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
            ResultTextBox.Text += $"в) {resultC}\n";
        }

        private void SolveTask11_Click(object sender, RoutedEventArgs e)
        {
            int x = 1;
            int y = 2;

            LogicExpressionsTask11 logicTask11 = new LogicExpressionsTask11(x, y);
            bool resultA = logicTask11.EvaluateExpressionA();

            ResultTextBox.Text = $"Задача 11:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
        }

        private void SolveTask12_Click(object sender, RoutedEventArgs e)
        {
            double x = 6;
            double y = 4;

            LogicExpressionsTask12 logicTask12 = new LogicExpressionsTask12(x, y);
            bool resultA = logicTask12.EvaluateExpressionA();
            bool resultB = logicTask12.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 12:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask13_Click(object sender, RoutedEventArgs e)
        {
            int A = 5;

            LogicExpressionsTask13 logicTask13 = new LogicExpressionsTask13(A);
            bool result = logicTask13.EvaluateExpression();

            ResultTextBox.Text = $"Задача 13:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask14_Click(object sender, RoutedEventArgs e)
        {
            int A = 1234;

            LogicExpressionsTask14 logicTask14 = new LogicExpressionsTask14(A);
            bool result = logicTask14.EvaluateExpression();

            ResultTextBox.Text = $"Задача 14:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask15_Click(object sender, RoutedEventArgs e)
        {
            double A = 1;
            double B = 2;
            double C = 3;
            double D = 4;

            LogicExpressionsTask15 logicTask15 = new LogicExpressionsTask15(A, B, C, D);
            bool result = logicTask15.EvaluateExpression();

            ResultTextBox.Text = $"Задача 15:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask16_Click(object sender, RoutedEventArgs e)
        {
            double x = 3;
            double y = 4;

            LogicExpressionsTask16 logicTask16 = new LogicExpressionsTask16(x, y);
            bool resultA = logicTask16.EvaluateExpressionA();
            bool resultB = logicTask16.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 16:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask17_Click(object sender, RoutedEventArgs e)
        {
            double x = 4;

            LogicExpressionsTask17 logicTask17 = new LogicExpressionsTask17(x);
            bool resultA = logicTask17.EvaluateExpressionA();

            ResultTextBox.Text = $"Задача 17:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
        }

        private void SolveTask18_Click(object sender, RoutedEventArgs e)
        {
            int A = 40;
            int B = 50;
            int C = 60;

            LogicExpressionsTask18 logicTask18 = new LogicExpressionsTask18(A, B, C);
            bool result = logicTask18.EvaluateExpression();

            ResultTextBox.Text = $"Задача 18:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask19_Click(object sender, RoutedEventArgs e)
        {
            int A = 30;

            LogicExpressionsTask19 logicTask19 = new LogicExpressionsTask19(A);
            bool result = logicTask19.EvaluateExpression();

            ResultTextBox.Text = $"Задача 19:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask20_Click(object sender, RoutedEventArgs e)
        {
            int A = -100;

            LogicExpressionsTask20 logicTask20 = new LogicExpressionsTask20(A);
            bool result = logicTask20.EvaluateExpression();

            ResultTextBox.Text = $"Задача 20:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask21_Click(object sender, RoutedEventArgs e)
        {
            int X = 10;
            int Y = 15;
            int Z = 20;

            LogicExpressionsTask21 logicTask21 = new LogicExpressionsTask21(X, Y, Z);
            bool result = logicTask21.EvaluateExpression();

            ResultTextBox.Text = $"Задача 21:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask22_Click(object sender, RoutedEventArgs e)
        {
            int X = 85;
            int Y = 75;
            int Z = 90;

            LogicExpressionsTask22 logicTask22 = new LogicExpressionsTask22(X, Y, Z);
            bool result = logicTask22.EvaluateExpression();

            ResultTextBox.Text = $"Задача 22:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask23_Click(object sender, RoutedEventArgs e)
        {
            bool A = true;
            bool B = false;
            bool C = true;

            LogicExpressionsTask23 logicTask23 = new LogicExpressionsTask23(A, B, C);
            bool resultA = logicTask23.EvaluateExpressionA();
            bool resultB = logicTask23.EvaluateExpressionB();
            bool resultC = logicTask23.EvaluateExpressionC();

            ResultTextBox.Text = $"Задача 23:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
            ResultTextBox.Text += $"в) {resultC}\n";
        }

        private void SolveTask24_Click(object sender, RoutedEventArgs e)
        {
            bool A = false;
            bool B = true;
            bool C = false;

            LogicExpressionsTask24 logicTask24 = new LogicExpressionsTask24(A, B, C);
            bool resultA = logicTask24.EvaluateExpressionA();
            bool resultB = logicTask24.EvaluateExpressionB();
            bool resultC = logicTask24.EvaluateExpressionC();

            ResultTextBox.Text = $"Задача 24:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
            ResultTextBox.Text += $"в) {resultC}\n";
        }

        private void SolveTask25_Click(object sender, RoutedEventArgs e)
        {
            double x = 2;

            LogicExpressionsTask25 logicTask25 = new LogicExpressionsTask25(x);
            bool resultA = logicTask25.EvaluateExpressionA();
            bool resultB = logicTask25.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 25:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask26_Click(object sender, RoutedEventArgs e)
        {
            bool X = true;
            bool Y = false;
            bool Z = true;

            LogicExpressionsTask26 logicTask26 = new LogicExpressionsTask26(X, Y, Z);
            bool resultA = logicTask26.EvaluateExpressionA();
            bool resultB = logicTask26.EvaluateExpressionB();
            bool resultC = logicTask26.EvaluateExpressionC();

            ResultTextBox.Text = $"Задача 26:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
            ResultTextBox.Text += $"в) {resultC}\n";
        }

        private void SolveTask27_Click(object sender, RoutedEventArgs e)
        {
            double x = 3;
            double y = 5;

            LogicExpressionsTask27 logicTask27 = new LogicExpressionsTask27(x, y);
            bool resultA = logicTask27.EvaluateExpressionA();
            bool resultB = logicTask27.EvaluateExpressionB();

            ResultTextBox.Text = $"Задача 27:\n";
            ResultTextBox.Text += $"a) {resultA}\n";
            ResultTextBox.Text += $"б) {resultB}\n";
        }

        private void SolveTask28_Click(object sender, RoutedEventArgs e)
        {
            double x = 4;

            LogicExpressionsTask28 logicTask28 = new LogicExpressionsTask28(x);
            bool result = logicTask28.EvaluateExpression();

            ResultTextBox.Text = $"Задача 28:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask29_Click(object sender, RoutedEventArgs e)
        {
            double x = 1;

            LogicExpressionsTask29 logicTask29 = new LogicExpressionsTask29(x);
            bool result = logicTask29.EvaluateExpression();

            ResultTextBox.Text = $"Задача 29:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }

        private void SolveTask30_Click(object sender, RoutedEventArgs e)
        {
            double x = 2;

            LogicExpressionsTask30 logicTask30 = new LogicExpressionsTask30(x);
            bool result = logicTask30.EvaluateExpression();

            ResultTextBox.Text = $"Задача 30:\n";
            ResultTextBox.Text += $"Результат: {result}\n";
        }
    }
}