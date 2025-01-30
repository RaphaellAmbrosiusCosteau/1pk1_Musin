namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Осуществить генерация двумерного [10*5] массива по следующему правилу:
             * 1 столбец содержит нули
             * 2 столбце содержит числа кратные 2
             * 3 столбец содержит числа кратные 3
             * 4 столбец содержит числа кратные 4
             * 5 столбец содержит числа кратные 5
             * Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив 
             */

            int[,] ints = new int[10, 5];
            Random random = new Random();

            for (int i = 0; i < ints.GetLength(0); i++)     //Заполнение матрицы
            {
                for (int j = 0; j < ints.GetLength(1); j++)     //1 столбец (нули)
                {
                    if (j == 0)
                    {
                        ints[i, j] = 0;
                    }
                    else if (j == 1)                            //2 столбец (кратные двум)
                    {
                        while (true)
                        {
                            ints[i, j] = random.Next(0, 100);
                            if (ints[i, j] % 2 == 0)
                                break;
                        }
                    }
                    else if (j == 2)                            //3 столбец (кратные трем)
                    {
                        while (true)
                        {
                            ints[i, j] = random.Next(0, 100);
                            if (ints[i, j] % 3 == 0)
                                break;
                        }
                    }
                    else if (j == 3)                            //4 столбец (кратные четырем)
                    {
                        while (true)
                        {
                            ints[i, j] = random.Next(0, 100);
                            if (ints[i, j] % 4 == 0)
                                break;
                        }
                    }
                    else if (j == 4)                            //5 столбец (кратные пяти)
                    {
                        while (true)
                        {
                            ints[i, j] = random.Next(0, 100);
                            if (ints[i, j] % 5 == 0)
                                break;
                        }
                    }
                }
            }
            
            for (int i = 0; i < ints.GetLength(0); i++)         //Вывод матрицы
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] reversedInts = new int[5, 10];

            for (int i = 0;i < reversedInts.GetLength(0); i++)  //Вывод перевернутой матрицы
            {
                for (int j = 0;j < reversedInts.GetLength(1); j++)
                {
                    reversedInts[i, j] = ints[j, i];
                    Console.Write(reversedInts[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
