namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Значения переменных
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;
            
            //Решение по действиям            
            double action1 = Math.Pow(b + Math.Pow(a - 1, 1 / 3.0), 1 / 4.0);
            double action2 = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));
            double action3 = action1 / action2;
            
            //Вывод результата
            Console.WriteLine(action3);
        }
    }
}
