using System;
using System.Collections.Generic;
using LetterScore.Models;

namespace LetterScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word.");
      string userWord = Console.ReadLine();
      string uppercaseWord = userWord.ToUpper();
      char[] letterList = uppercaseWord.ToCharArray();
      LetterValue scoreDictionary = new LetterValue(); 
      int score = 0;
      // int letterPoints = 0;
      for (int i=0; i<userWord.Length; i++)
      {
        
        int letterPoints = LetterValue.FindPoints(letterList[i]);
        if (letterPoints == 0)
        {
          Console.WriteLine($"Error, you have entered an invalid character: '{letterList[i]}'. Would you like to try again? (Y/N)");
          string userRetryChoice = Console.ReadLine();
          if (userRetryChoice.ToLower() == "y" )
          {
            userWord = "";
            Program.Main();
          }
          else
          {
            Console.WriteLine("Goodbye.");
            Environment.Exit(0);
          }
        }
        else
        {
          score += letterPoints;
          Console.WriteLine($"The letter {letterList[i]} is {letterPoints}pts");  
        }
        
        // Console.WriteLine($"Your word is {userWord} it is worth {score}pts");
      }
      if (userWord.Length > 0)
      {
        Console.WriteLine($"Your word is {userWord}; it is worth {score}pts");
      }
      Console.WriteLine("Would you like to score another word? (Y/N)");
      string userRerun = Console.ReadLine();
      if (userRerun.ToLower() == "y")
      {
        Main();
      }
      Console.WriteLine("Goodbye.");
      Environment.Exit(0);
    }
  }
}