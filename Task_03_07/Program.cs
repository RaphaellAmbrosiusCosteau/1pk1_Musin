namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая выводит таблицу скорости(через каждые 0, 5с) свободно падающего тела v = g t ,
            где g = 9,8 м / с – ускорение свободного падения.
            */

            //Ускорение свободного падения
            double g = 9.8;
            //Шаг времени
            double t = 0.5;
            //Скорость
            double v = 0;

            //Вывод таблицы
            Console.WriteLine("Скорость\t\tВремя");
            
            for (double time = 0; time <= 10; time += t)
            {
                v = g * time;
                Console.WriteLine($"{Math.Round(v , 1)}\t\t\t{time}");
            }



        }
    }
}
