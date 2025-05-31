using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Random rand = new Random();

            int hp = 3;
            int answer;
            int number = rand.Next(1, 11);
            while (hp > 0)
            {
                Console.WriteLine($"УГАДАЙ МОЁ ЧИСЛО ОТ 1 ДО 10! (осталось {hp} попытки): ");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer != number)
                {
                    Console.WriteLine("НЕУГАДАЛ!!");
                    --hp;
                }
                else
                {
                    Console.WriteLine($"МОЛОДЕЦ! ТЫ УГАДАЛ! (загаданное число: {number}");
                    break;
                }
                if (hp == 0)
                {
                    Console.WriteLine($"ТЫ ПРОИГРАЛ! БЫЛО ЗАГАДАННО ЧИСЛО: {number}!");
                }

            }
            Console.WriteLine("Программа завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey(); // Ждёт нажатия любой клавиши

        }
    }
}
