namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
            Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
            время работы программы
            */

            //Ввод данных
            Console.WriteLine("Введите начальную температуру в градусах Цельсия:");
            double initialTemperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечную температуру:");
            double finalTemperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг температуры");
            double temperatureStep = Convert.ToDouble(Console.ReadLine());

            //Вывод таблицы
            Console.WriteLine("По Цельсию\tПо Фаренгейту");

            double farenheit = 0;
            
            while (initialTemperature <= finalTemperature)
            {
                farenheit = initialTemperature * 1.8 + 32;
                Console.WriteLine($"{initialTemperature}\t\t\t{farenheit}");
                initialTemperature += temperatureStep;
            }


        }
    }
}
