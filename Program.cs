using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hisoblash dasturiga hush kelibsiz");
        Console.WriteLine("===================================");
        Console.WriteLine("1 -> Aylana yuzini hisoblash");
        Console.WriteLine("2 -> Slindir hajmini hisoblash");
        Console.WriteLine("3 -> Sodda kalkulyator dasturi");
        Console.WriteLine("===================================");
        Console.Write("Amallardan birini tanlang: ");
        int select = Convert.ToInt16(Console.ReadLine());

        while (select == 1 || select == 2 || select == 3)
        {
            if (select == 1)
            {
                Console.Write("Aylana radiusini kiriting: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                const double PI = 3.14;

                Console.WriteLine($"Aylana yuzasi: {PI * Math.Pow(radius, 2)}");
            }
            else if (select == 2)
            {
                Console.Write("Slindr radiusini kiriting: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                Console.Write("Slindr balandligini kiriting: ");
                int height = Convert.ToInt32(Console.ReadLine());
                const double PI = 3.14;

                Console.WriteLine($"Slindr hajmi: {PI * Math.Pow(radius, 2) * height}");
            }
            else if (select == 3)
            {
                Console.WriteLine("oddiy kalkulyator loyihasiga hush kelibsiz");
                Console.WriteLine("\"2 + 2\" shu ko'rinishda son va amalni kiriting");
                string text = Console.ReadLine();
                var inputs = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int firstNumber = Convert.ToInt32(inputs[0]);
                char operation = Convert.ToChar(inputs[1]);
                int secondNumber = Convert.ToInt32(inputs[2]);

                try
                {
                    var result = operation switch
                    {
                        '+' => firstNumber + secondNumber, 
                        '-' => firstNumber - secondNumber, 
                        '*' => firstNumber * secondNumber, 
                        '/' => firstNumber / secondNumber, 
                        '%' => firstNumber + secondNumber,
                        _ => throw new ArgumentException("Xato ishora kiritilgan! ")
                    };
                    Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
                }
                catch (Exception)
                {
                    throw new("faqat son va ishora kiritilsin");
                }
            }

            Console.WriteLine("===================================");
            Console.WriteLine("1 -> Aylana yuzini hisoblash");
            Console.WriteLine("2 -> Slindir hajmini hisoblash");
            Console.WriteLine("3 -> Sodda kalkulyator dasturi");
            Console.WriteLine("===================================");
            Console.WriteLine("Qayta foydalanish uchun yuqoridagilardan birini tanlang\ndasturdan chiqish uchun ihtiyoriy tugmachani bosing.");
            select = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Dasturdan foydalanganingiz uchun rahmat");
    }
}