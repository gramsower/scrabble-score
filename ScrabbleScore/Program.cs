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
      char[] letterList = userWord.ToCharArray();
      LetterValue scoreDictionary = new LetterValue(); 
      int score = 0;
      int letterPoints = 0;
      for (int i=0; i<userWord.Length; i++)
      {
        letterPoints = scoreDictionary.FindPoints(letterList[i]);
        score += letterPoints;
        Console.WriteLine($"The letter {letterList[i]} is {letterPoints}pts");
      }
    }
  }
}