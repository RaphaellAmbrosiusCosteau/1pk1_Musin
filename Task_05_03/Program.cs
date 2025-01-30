namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
            * да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
            * элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны.  
            */

            char[,] firstMatrix = new char[3, 3];
            char[,] secondMatrix = new char[3, 3];
            Random random = new Random();

            for (int i  = 0; i < 3; i++)        //Заполнение массивов
            {
                for (int j = 0; j < 3; j++)
                {
                    firstMatrix[i, j] = (char)random.Next('A', 'Z' + 1);
                    secondMatrix[i, j] = (char)random.Next('A', 'Z' + 1);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)         //Вывод первой матрицы
                {
                    Console.Write($"{firstMatrix[i, j]} ");
                }
                Console.Write("   ");


                for (int j = 0; j < 3; j++)         //Вывод второй матрицы
                {
                    Console.Write($"{secondMatrix[i, j]} ");    
                }
                Console.Write("   ");

                Console.WriteLine();
            }
            Console.WriteLine("=>");

            int matrixEquality = 0;
            for (int i =0; i < 3; i++)          //Проверка равенства массивов
            {
                for (int j = 0; j < 3; j++)
                {
                    if (firstMatrix[i, j].Equals(secondMatrix[i, j]))
                    {
                        matrixEquality++;
                    }
                    
                }
            }

            if (matrixEquality == 9)
                Console.WriteLine("Матрицы равны!");


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)         //Вывод первой матрицы, окраска совпадающих символов
                {
                    if (firstMatrix[i, j].Equals(secondMatrix[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{firstMatrix[i, j]} ");
                    Console.ResetColor();
                }
                Console.Write("   ");


                for (int j = 0; j < 3; j++)         //Вывод второй матрицы, окраска символов
                {
                    if (firstMatrix[i, j].Equals(secondMatrix[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write($"{secondMatrix[i, j]} ");
                    Console.ResetColor();
                }
                Console.Write("   ");

                Console.WriteLine();
            }
        }
    }
}
