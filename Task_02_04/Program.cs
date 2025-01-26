using System.ComponentModel.Design;

namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
            расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            этом 
            */

            //Ввод даты рождения
            Console.WriteLine("Введите год рождения:");
            int year = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите месяц рождения:");
            int month = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите день рождения:");
            int day = Convert.ToInt32(Console.ReadLine());

            //Объявляем дату рождения
            DateTime birthday = new DateTime(year, month, day);
            //Определяем сегодняшнюю дату
            DateTime thisday = DateTime.Now;

            //Вычисляем примерное кол-во лет
            int age = thisday.Year - birthday.Year;

            //Вычисляем точное совершеннолетие по месяцам
            if (birthday.Month < thisday.Month)
                age--;
            else if (birthday.Month == thisday.Month)
                //Вычисляем точное совершеннолетие по дням
                if (birthday.Day > thisday.Day)
                    age--;
            //Вывод результата
            if (age >= 18)
                Console.WriteLine("Пользователь совершеннолетний");
            else
                Console.WriteLine("Пользователь несовершеннолетний");





        }
    }
}
