using System;

//Homework 1
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name;
            string second_name;
            int age;
            Console.WriteLine("Введите Ваше имя");
            first_name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию");
            second_name = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 100)
            {
                Console.WriteLine($"{first_name} {second_name}, до 100 вам осталось {100 - age} лет");
            }
            else if (age == 100)
            {
                Console.WriteLine($"{first_name} {second_name}, в данный момент вам 100 лет");
            }
            else
            {
                Console.WriteLine($"{first_name} {second_name}, вам исполнилось 100 лет, {age-100} лет назад");
            }
        }
    }
}
