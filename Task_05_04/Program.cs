namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
             * диагональной (все элементы вне главной диагонали равны нулю)
             * Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
             * сообщение что матрица не является диагональной. 
             */

            Console.WriteLine("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            Random random = new Random();

            for (int i  = 0; i < n; i++)        //Заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
            
            for (int i = 0; i < n; i++)         //Вывод матрицы
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool diagonal = true;
            for (int i = 0; i < n; i++)         //Проверка на диагональность
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] != 0)
                    {
                        diagonal = false;
                    }
                }
            }

            if (diagonal)
            {
                Console.WriteLine("Матрица является диагональной:");    //Результат анализа
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            else
                Console.WriteLine("Матрица не является диагональной");
        }
    }
}
