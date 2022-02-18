using System;
using System.Diagnostics;

namespace CasinoWoGUI
{
  internal class Program
  {
    static Random rnd = new Random();
    public static double balance;
    public static double wins = 0;
    public static double games = 0;
    public static void game(int games_list)
    {
      if (games_list == 1)
      {
        int bet;
        string accept = "Stay";
        
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Рулетка");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          
          balance -= bet;
          Console.Write("Введите число 0-36: ");
          int n = int.Parse(Console.ReadLine());
          
          if (Win(n))
          {
            balance += bet * 1.95;
            Console.WriteLine($"Ваш выигрыш составил: {bet * 1.95}");
            wins++;
          }
          else
          {
            Console.WriteLine($"Ваш проигрыш составил: {bet}");
            if (balance == 0)
            {
              Console.WriteLine("Вы все проиграли!");
            }
          }

          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
        }
      }
      
      else if (games_list == 2)
      {
        int bet;
        string accept = "Stay";
        
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Больше меньше");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          
          Console.Write("Введите количетсво чисел: ");
          int count = int.Parse(Console.ReadLine());
          Console.WriteLine($"Выберите число, которое будет больше случайного: {count}");
          int number = int.Parse(Console.ReadLine());
            
          while (number < 1 || number > count)
          {
            Console.WriteLine($"Выбранное число не попадает в заданный промежуток от 1 до {count}");
            Console.Write("Введите число заново: ");
            number = int.Parse(Console.ReadLine());
          }
            
          int num = rnd.Next(1, count);
          Console.ForegroundColor=ConsoleColor.Yellow;
          Console.WriteLine($"Выпало число {num}");
          Console.WriteLine($"{number} >= {num}?");
          Console.ForegroundColor = ConsoleColor.White;
            
          if (number >= num)
          {
            balance += ((count - number)/count - 0.05) * bet ;
            Console.WriteLine($"Ваш выигрыш составил: {((count - number)/count - 0.05) * bet}");
            wins++;
          }
          else
          {
            balance -= bet;
            Console.WriteLine($"Ваш проигрыш составил: {bet}");
            if (balance == 0)
            {
              Console.WriteLine("Вы все проиграли!");
            }
          }

          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
          
        }
      }
      
      else if (games_list == 3)
      {
        int bet;
        string accept = "Stay";
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Угадай число");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          
          Console.Write("Введите количетсво чисел: ");
          int count = int.Parse(Console.ReadLine());
          Console.WriteLine($"Выберите число от 1 до {count}");
          int number = int.Parse(Console.ReadLine());
          
          while (number < 1 || number > count)
          {
            Console.WriteLine($"Выбранное число не попадает в заданный промежуток от 1 до {count}");
            Console.Write("Введите число заново: ");
            number = int.Parse(Console.ReadLine());
          }
          
          int num = rnd.Next(1, count);
          Console.ForegroundColor=ConsoleColor.Yellow;
          Console.WriteLine($"Выпало число {num}");
          Console.ForegroundColor = ConsoleColor.White;
          
          if (number == num)
          {
            balance += bet * (count - 0.05) ;
            Console.WriteLine($"Ваш выигрыш составил: {bet * (count - 0.05)}");
            wins++;
          }
          else
          {
            balance -= bet;
            Console.WriteLine($"Ваш проигрыш составил: {bet}");
            if (balance == 0)
            {
              Console.WriteLine("Вы все проиграли!");
            }
          }
          
          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
        }
      }
      
      else if (games_list == 4)
      {
        int bet;
        string accept = "Stay";
        
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Множитель");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }

          Console.WriteLine("Игра началась");
          double num = rnd.Next(1, 50) / 10;
          Console.Write("Введите предельный множитель: ");
          double power = Convert.ToDouble(Console.ReadLine());
          Console.ForegroundColor=ConsoleColor.Yellow;
          Console.WriteLine($"Выпавший множитель: {num}");
          Console.ForegroundColor=ConsoleColor.White;
          
          if (power < num)
          {
            Console.WriteLine($"Ваш выигрыш составил: {bet * power}");
            wins++;
          }
          else
          {
            Console.WriteLine($"Ваш проигрыш составил: {bet}");
            balance -= bet;
          }
          
          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
        }
      }
      
      else if (games_list == 5)
      {
        int bet;
        string accept = "Stay";
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Множитель");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());
          
          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          
          Console.Write("Введите Орел или Решка: ");
          string Eagle = Console.ReadLine();
          int num = rnd.Next(1, 2);
          Console.ForegroundColor=ConsoleColor.Yellow;
          if (num == 1)
          {
            Console.WriteLine("Выпал: Орел");
          }
          else
          {
            Console.WriteLine("Выпала: Решка");
          }

          balance -= bet;
          Console.ForegroundColor=ConsoleColor.White;
          
          if (Eagle == "Орел" && num == 1)
          {
            Console.WriteLine($"Вы выиграли: {bet * 1.95}");
            wins++;
            balance += bet * 1.95;
          }else if (Eagle == "Решка" && num == 2)
          {
            Console.WriteLine($"Вы выиграли: {bet * 1.95}");
            wins++;
          }
          else
          {
            Console.WriteLine($"Вы проиграли: {bet}");
          }
          
          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
        }
      }
      
      else if (games_list == 6)
      {
        int bet;
        string accept = "Stay";
        int first_num = rnd.Next(0, 3);
        int second_num = rnd.Next(0, 3);
        int third_num = rnd.Next(0, 3);
        
        while (accept == "Stay")
        {
          Console.Clear();
          Console.WriteLine("\t  Слот-Машина");
          Console.Write("Ставка: ");
          bet = int.Parse(Console.ReadLine());

          while (bet > balance)
          {
            Console.WriteLine("Ставка не может превышать баланс и быть меньше нуля!");
            Console.Write("Введите ставку заново: ");
            bet = int.Parse(Console.ReadLine());
          }
          
          Console.WriteLine("Игра началась!");

          if (first_num == second_num && first_num == third_num)
          {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Выпало число: " + first_num + "" + second_num + "" + third_num);
            Console.WriteLine("Джекпот!");
            Console.WriteLine("Вы выиграли: " + bet * 50);
            wins ++;
            balance += bet * 50;
            Console.ForegroundColor=ConsoleColor.White;
          }
          else if ((first_num == second_num && first_num != third_num) || 
                   (first_num == third_num && first_num != second_num) || 
                   (second_num == third_num && second_num != first_num))
          {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Выпало число: " + first_num + "" + second_num + "" + third_num);
            Console.WriteLine("Вы выиграли: " + bet * 7);
            wins ++;
            balance += bet * 7;
            Console.ForegroundColor=ConsoleColor.White;
          }
          else
          {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Выпало число: " + first_num + "" + second_num + "" + third_num);
            Console.WriteLine("Вы проиграли: " + bet);
            Console.ForegroundColor = ConsoleColor.White;
          }
          
          games++;
          Console.WriteLine("\n________________________________");
          Console.WriteLine("\nЕсли хотите выйти, введите: Exit");
          Console.WriteLine("Если хотите остаться, введите: Stay");
          accept = Console.ReadLine();
          
        }
      }
    }
    
    static bool Win(int number)
    {
      Console.ForegroundColor=ConsoleColor.Yellow;
      int num = rnd.Next(0, 37);
      
      if (number == 0 && num == 0)
      {
        Console.WriteLine("\tВыпал Zero");
        return true;
      }
      
      if (num % 2 == 0)
        Console.WriteLine($"\tВыпали красные! ({num})");
      else
      {
        Console.WriteLine($"\tВыпали черные! ({num})");
      }
 
      Console.ResetColor();
      
      if (number % 2 == 0 && num % 2 == 0)
        return true;
 
      if (number % 2 == 1 && num % 2 == 1)
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
      double change_balance = balance;
      Stopwatch stopWatch = new Stopwatch();
      stopWatch.Start();
      
      while (true)
      {
        Console.WriteLine("\n\tМеню: ");
        Console.WriteLine("\t  1. Список игр");
        Console.WriteLine("\t  2. Процент выигрышей");
        Console.WriteLine("\t  3. Время в игре");
        Console.WriteLine("\t  4. Баланс");
        Console.WriteLine("\t  5. Изменение баланса");
        Console.Write("Выберите необходимый пункт: ");
        int menu = int.Parse(Console.ReadLine());
        
        while (menu < 0 || menu > 5)
        {
          Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 5");
          Console.Write("Введите число заново: ");
          menu = int.Parse(Console.ReadLine());
        }
        
        if (menu == 1)
        {
          Console.WriteLine("\t  1. Рулетка");
          Console.WriteLine("\t  2. Больше Меньше");
          Console.WriteLine("\t  3. Угадай число");
          Console.WriteLine("\t  4. Множитель");
          Console.WriteLine("\t  5. Монетка");
          Console.WriteLine("\t  6. Слот-машина");
          Console.Write("Выберите необходимый пункт: ");
          int games_list = int.Parse(Console.ReadLine());
          
          if (games_list < 0 || games_list > 5)
          {
            do
            {
              Console.WriteLine("Введенное число должно лежать в промежутке от 1 до 5");
              Console.Write("Введите число заново: ");
              games_list = int.Parse(Console.ReadLine());
            } while (games_list < 0 || games_list > 5);
          }
          game(games_list);
          Console.Clear();
        }

        if (menu == 2)
        {
          if (games == 0)
          {
            Console.WriteLine("Сначала сыграйте игру");
          }
          else
          {
            double wirate = Math.Round((wins/games)*100, 2);
            Console.WriteLine($"Процент выигрышей: {wirate}%");
          }
        }
        
        if (menu == 3)
        {
          stopWatch.Stop();
          TimeSpan ts = stopWatch.Elapsed;
          string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
          Console.WriteLine("Время в игре: " + elapsedTime);
        } 
        
        if (menu == 4)
        {
          Console.WriteLine($"Ваш баланс: {balance}");
        }

        if (menu == 5)
        {
          if (change_balance > balance)
          {
            Console.WriteLine($"Ваш проигрыш за все время составил: {balance - change_balance}");
          }
          else if (change_balance < balance)
          {
            Console.WriteLine($"Ваш выигрыш за все время игры составил: {balance - change_balance}");
          }
          else
          {
            Console.WriteLine("Ваш баланс не изменился");
          }
        }
      }
    }
  } 
}