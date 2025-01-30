namespace Task_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
             * числами в диапазоне от 10 до 99 включительно.
             * Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
             * минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве
             */

            Console.WriteLine("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int [n, n];    
            Random random = new Random();

            for (int i = 0; i < n; i++)     //Заполнение массива
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }

            for (int i = 0; i < n; i++)     //Вывод изначальной матрицы
            {
                for (int j = 0;j < n; j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.WriteLine();
            }

            int minValue = matrix[0, 0];        //Нахождение минимального элемента
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minValue)
                        minValue = matrix[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент: {minValue}");
            Console.WriteLine();

            for (int i = 0; i < n; i++)         //Умножение на минимальный элемент
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] *= minValue;
                }
            }

            int[] maxValues = new int[5];       //Нахождение пяти максимальных значений
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int value = matrix[i, j];
                    for (int k = 0; k < 5; k++)
                    {
                        if (value > maxValues[k])
                        {
                            for (int l = 4; l > k; l--)
                            {
                                maxValues[l] = maxValues[l - 1];
                            }
                            maxValues[k] = value;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Матрица после умножения:");      //Вывод матрицы после умножения на минимальный элемент
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool isHighlighted = false;
                    for (int k = 0; k < 5; k++)
                    {
                        if (matrix[i, j] == maxValues[k])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            isHighlighted = true;
                            break;
                        }
                    }
                    Console.Write(matrix[i, j] + " ");
                    if (isHighlighted)
                        Console.ResetColor();
                }
                Console.WriteLine();
            }


        }
    }
}
