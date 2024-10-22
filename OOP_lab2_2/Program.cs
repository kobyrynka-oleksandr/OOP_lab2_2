using System.Text;

namespace OOP_lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Введiть чисельник та знаменник першого дробу:");
            Console.Write("Чисельник: ");
            long numerator1 = long.Parse(Console.ReadLine());
            Console.Write("Знаменник: ");
            long denominator1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Введiть чисельник та знаменник другого дробу:");
            Console.Write("Чисельник: ");
            long numerator2 = long.Parse(Console.ReadLine());
            Console.Write("Знаменник: ");
            long denominator2 = long.Parse(Console.ReadLine());

            Console.WriteLine("\nСкорочені дроби:");
            MyFrac res1 = new MyFrac(numerator1, denominator1);
            MyFrac res2 = new MyFrac(numerator2, denominator2);
            Console.WriteLine($"{res1} {res2}");

            Console.WriteLine("\nРядкове подання дробів з виділеною цілою частиною:");
            Console.WriteLine($"{res1.ToStringWithIntPart()} {res2.ToStringWithIntPart()}");

            Console.WriteLine("\nДійсне значення дробів:");
            Console.WriteLine($"{res1.DoubleValue()}   {res2.DoubleValue()}");

            Console.WriteLine("\nРезультат додавання:");
            MyFrac plus = res1 + res2;
            Console.WriteLine(plus);
            Console.WriteLine(plus.ToStringWithIntPart());

            Console.WriteLine("\nРезультат віднімання:");
            MyFrac minus = res1 - res2;
            Console.WriteLine(minus);

            Console.WriteLine("\nРезультат множення:");
            MyFrac multiply = res1 * res2;
            Console.WriteLine(multiply);

            Console.WriteLine("\nРезультат ділення:");
            MyFrac divide = res1 / res2;
            Console.WriteLine(divide);

            Console.Write("\nВведеня значення n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nРезультат методу CalcExpr1:");
            Console.WriteLine(res1.CalcExpr1(n));

            Console.WriteLine("\nРезультат методу CalcExpr2:");
            Console.WriteLine(res1.CalcExpr2(n));

            Console.ReadKey();
        }
    }
}
