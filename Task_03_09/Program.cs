namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов, после чего дробная часть копеек
            отбрасывается. Каждый год сумма вклада становится больше. Определите, через сколько лет вклад составит не
            менее y рублей.
            */

            //Ввод данных
            Console.WriteLine("Введите начальную сумму вклада:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку:");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целевую сумму вклада:");
            int y = Convert.ToInt32(Console.ReadLine());

            int years = 0;
            int currentAmount = x;

            //Расчет количества лет
            while (currentAmount < y)
            {
                currentAmount += (currentAmount * p) / 100;
                years++;
            }

            //Вывод результата
            Console.WriteLine($"Через {years} лет вклад составит не менее {y} рублей.");

        }
    }
}
