using System.ComponentModel.Design;

namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается. Когда
            пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            введенных пользователем
            */

            //Количество строк
            int lines = 0;

            while (true)
            {
                //Ввод текста
                Console.WriteLine("Введите текст:");
                string text = Console.ReadLine();

                lines++;
                
                //В случае ввода пустой строки или exit
                if (string.IsNullOrEmpty(text) || text.Equals("exit"))
                {
                    Console.Clear();
                    Console.WriteLine($"Кол-во введенных строк: " + lines);
                    break;
                }
                   
          
                    
            }
        }
    }
}
