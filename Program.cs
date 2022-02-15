using System;

namespace CasinoWoGUI
{
  internal class Program
  {
    public static void Main(string[] args)
    {
    Console.Write("Введите Ваше имя: ");
    string name = Console.ReadLine();
    Console.WriteLine($"Здравствуйте, {name}, введите Ваш баланс: ");
    string money = Console.ReadLine();
    Console.WriteLine($"Игрок: {name} Баланс: {money}");
    }
  }
}