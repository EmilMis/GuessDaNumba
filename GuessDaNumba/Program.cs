using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Threading;

namespace GuessDaNumba
{
  internal class Program
  {
    public static void scrollText(String textToScrol, int timeForEachLetter)
    {
      for (int i = 0; i < textToScrol.Length; i++)
      {
        Console.Write(textToScrol[i]);
        Thread.Sleep(timeForEachLetter);
      }
      
    }

    public static void Game(int triesRemaining, int targetNumber)
    {
      int triesRem = triesRemaining;
      while (true)
      {
        if (triesRem == 0)
        {
          scrollText("you lost!!\nHahah!\nYour soul is now mine", 50);
          break;
        }
        int UsersNumber;
        scrollText("Number of Tries: " + Convert.ToString(triesRem), 50);
        while (true)
        {
          scrollText("\nEnter your Number: ", 50);
          String InputNumber = Console.ReadLine();
          UsersNumber = Int32.Parse(InputNumber);
          scrollText("\nIs your Number " + InputNumber + "? (yes/no): ", 50);
          String response = Console.ReadLine();
          if (response == "yes")
          {
            break;
          }
          else if (response == "no")
          {
            continue;

          }
        }
        Console.WriteLine("\n");
        Console.WriteLine("\n");

        if (UsersNumber == targetNumber)
        {
          scrollText("Congratulations!!\nYou did it!!\nBut it's not over yet...\n", 50);
          break;
        }
        else if (UsersNumber < targetNumber)
        {
          scrollText("Yo man\nYo Numba To smoll\n", 50);
          triesRem--;
          continue;
          
        }
        else if (UsersNumber > targetNumber)
        {
          scrollText("Yo man,\nYo Numba to Big\n", 50);
          triesRem--;
          continue;
        }
        Console.WriteLine("\n");
      }
      
    }
    
    public static void Main(string[] args)
    {
      Random rand = new Random();
      scrollText("Heya,\nI have a number and you gotta guess it,\nSounds Fair? Because it is not\nGood luck\n\nP.S.\nYou have limited amount of tries", 50);
      Console.WriteLine();
      Game(7, rand.Next(21));
    }
  }
}