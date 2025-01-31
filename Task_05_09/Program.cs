namespace Task_05_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
             * (это матрица, где все недиагональные элементы меньше нуля)
             * Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
             * вывести сообщение что данная матрица не является Z-матрицей 
             */

            Console.WriteLine("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];      
            Random random = new Random();

            for (int i = 0; i < n; i++)     //Заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(-10, 11);
                }
            }

            bool isZMatrix = true;      //Проверка на Z-матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && matrix[i, j] >= 0)
                    {
                        isZMatrix = false;
                        break;
                    }
                }
                if (!isZMatrix)
                    break;
            }

            if (isZMatrix)      //Вывод Z-матрицы
            {
                Console.WriteLine("Матрица является Z-матрицей: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(matrix[i, j] + " ");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }       
            else                //Если не является Z-матрицей
            {
                Console.WriteLine("Матрица не является Z-матрицей.");
            }

        }
    }
}
