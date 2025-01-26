namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
             */

            //Шаг
            double h = 0.5;

            //Вывод таблицы
            Console.WriteLine(" X\t\tY = |x|");
            for (double x = -3.5; x < 4; x += h)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x}\t\t{y}");
            }
            
        }
    }
}
