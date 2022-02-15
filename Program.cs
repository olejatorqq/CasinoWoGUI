using System;
namespace CasinoWoGUI
{
  internal class Program
  {
    public static void game(int games_list)
    {
      Console.WriteLine("Игра " + games_list);
    }
    public static void Main(string[] args)
    {
      Console.Write("Введите Ваше имя: ");
      string name = Console.ReadLine();
      Console.Write($"Здравствуйте, {name}, введите Ваш баланс: ");
      int money = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"\nИгрок: {name}\nБаланс: {money}");
      Console.WriteLine("\tМеню: ");
      Console.WriteLine("\t  1. Список игр");
      Console.WriteLine("\t  2. Процент выигрышей");
      Console.WriteLine("\t  3. Время в игре");
      Console.WriteLine("\t  4. Баланс");
      Console.Write("Выберите необходимый пункт: ");
      int menu = Convert.ToInt32(Console.ReadLine());
      if (menu < 0 || menu > 4)
      {
        do
        {
          Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 4");
          Console.Write("Введите число заново: ");
          menu = Convert.ToInt16(Console.ReadLine());
        } while (menu < 0 || menu > 4);

        if (menu == 1)
        {
          Console.WriteLine("\t  1. Рулетка");
          Console.WriteLine("\t  2. Больше Меньше");
          Console.WriteLine("\t  3. Угадай число");
          Console.Write("\t  Выберите необходимый пункт: ");
          int games_list = Convert.ToInt16(Console.ReadLine());
          if (games_list < 0 || games_list > 3)
          {
            do
            {
              Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 3");
              Console.Write("Введите число заново: ");
              games_list = Convert.ToInt16(Console.ReadLine());
            } while (games_list < 0 || games_list > 3);
          }
          game(games_list);
          
        }
      }
      
      /*do
      {
        Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 4");
        Console.WriteLine("Введите число заново: ");
        menu = Convert.ToInt16(Console.ReadLine());
      } while (menu < 0 || menu > 4);*/
    
      
    }
  } 
}