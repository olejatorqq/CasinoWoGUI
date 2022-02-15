using System;
namespace CasinoWoGUI
{
  internal class Program
  {
    static Random rnd = new Random();
    public static int balance;
    public static void game(int games_list)
    {
      if (games_list == 1)
      {
        int bet;
        Console.WriteLine("\t  1. Ставка на число");
        Console.WriteLine("\t  2. Ставка на Красное/Черное");
        Console.Write("Выберите необходимый пункт: ");
        int roulette_menu = int.Parse(Console.ReadLine());
        while (roulette_menu < 0 || roulette_menu > 2)
        {
          Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 2");
          Console.Write("Введите число заново: ");
          roulette_menu = int.Parse(Console.ReadLine());
        }
        if (roulette_menu == 1)
        {
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите число заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          if (balance <= 0d)
          {
            Console.WriteLine("Вы все проиграли");
          }
          else
          {
            Console.WriteLine("Введите число 0-36");
            int n = int.Parse(Console.ReadLine());
            if (Win(n))
            {
              balance += bet * 4;
              Console.WriteLine($"Ваш выигрыш составил: {bet * 4}");
            }
            else
            {
              balance -= bet;
              Console.WriteLine($"Ваш проигрыш составил: {bet}");
            }
          }
        }
      }
    }
    
    static bool Win(int number)
    {
      Console.ForegroundColor=ConsoleColor.Yellow;
      int bet = rnd.Next(0, 37);
      if (number == 0 && bet == 0)
      {
        Console.WriteLine("\tВыпал Zero");
        return true;
      }
      if(bet%2==0)
        Console.WriteLine($"\tВыпали красные! ({bet})");
      else
      {
        Console.WriteLine($"\tВыпали черные! ({bet})");
      }
 
      Console.ResetColor();
      if (number%2 == 0 && bet%2 == 0)
        return true;
 
      if (number % 2 == 1 && bet % 2 == 1)
        return true;
      return false;
 
    }
    
    public static void Main(string[] args)
    {
      Console.Write("Введите Ваше имя: ");
      string name = Console.ReadLine();
      Console.Write($"Здравствуйте, {name}, введите Ваш баланс: ");
      balance = int.Parse(Console.ReadLine());
      Console.WriteLine($"\nИгрок: {name}\nБаланс: {balance}");
      Console.WriteLine("\tМеню: ");
      Console.WriteLine("\t  1. Список игр");
      Console.WriteLine("\t  2. Процент выигрышей");
      Console.WriteLine("\t  3. Время в игре");
      Console.WriteLine("\t  4. Баланс");
      Console.Write("Выберите необходимый пункт: ");
      int menu = int.Parse(Console.ReadLine());
      while (menu < 0 || menu > 4)
      {
        Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 4");
        Console.Write("Введите число заново: ");
        menu = int.Parse(Console.ReadLine());
      }
      if (menu == 1)
      {
        Console.WriteLine("\t  1. Рулетка");
        Console.WriteLine("\t  2. Больше Меньше");
        Console.WriteLine("\t  3. Угадай число");
        Console.Write("Выберите необходимый пункт: ");
        int games_list = int.Parse(Console.ReadLine());
        if (games_list < 0 || games_list > 3)
        {
          do
          {
            Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 3");
            Console.Write("Введите число заново: ");
            games_list = int.Parse(Console.ReadLine());
          } while (games_list < 0 || games_list > 3);
        }
        game(games_list);
      }
    }
  } 
}