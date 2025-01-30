namespace Task_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
             * случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
             * по следующему правилу:
             * Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
             * Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
             */

            Console.WriteLine("Введите кол-во строк: ");    //Ввод данных
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)         //Заполнение массива
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-99, 100);
                }
            }

            for (int i = 0;i < n; i++)      //Вывод матрицы
            {
                for (int j = 0;j < m; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = Math.Abs(matrix[i, j]);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = random.Next(-99, 0);
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(matrix[i, j] + "   ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
