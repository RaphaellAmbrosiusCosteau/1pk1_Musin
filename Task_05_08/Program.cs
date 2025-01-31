namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
             * произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
             * результирующий массив)
             * Вывести результирующий массив 
             */

            int[,] matrix1 = new int[10, 10];
            int[,] matrix2 = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)        //Заполнение массивов
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix1[i, j] = random.Next(1, 10);
                }
                for (int k = 0; k < 10; k++)
                {
                    matrix2[i, k] = random.Next(1, 10);
                }
            }

            Console.WriteLine("Первые две матрицы: ");
            Console.WriteLine();
            
            for (int i = 0;i < 10; i++)         //Вывод первых двух матриц
            {
                for (int j = 0;j < 10; j++)
                {
                    Console.Write(matrix1[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrix2[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Произведение матриц: ");
            Console.WriteLine();

            int[,] multipliedMatrix = new int[10, 10];
            
            for (int i = 0; i < 10; i++)            //Перемножение матриц
            {
                for (int j = 0; j < 10; j++)
                {
                    multipliedMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }

            for (int i = 0; i < 10; i++)            //Вывод умножения матриц
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(multipliedMatrix[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
