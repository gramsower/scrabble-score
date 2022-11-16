using System;
using System.Collections.Generic;
using LetterScore;

namespace LetterScore.Models
{
public class LetterValue
{
  public static int FindPoints(char character)
  {
    string userChar = character.ToString();
    if (LetterValue.letterPoints.ContainsKey(userChar))
    {
      int pointsForLetter = LetterValue.letterPoints[userChar];
      return pointsForLetter;
    }
    else 
    {
      return 0;
    }
  }

  private static Dictionary<string, int> letterPoints = new Dictionary<string, int>()
  { 
    {"A", 1},
    {"E", 1},
    {"I", 1},
    {"O", 1},
    {"U", 1},
    {"L", 1},
    {"N", 1},
    {"R", 1},
    {"S", 1},
    {"T", 1},
    {"D", 2},
    {"G", 2},
    {"B", 3},
    {"C", 3},
    {"M", 3},
    {"P", 3},
    {"F", 4},
    {"H", 4},
    {"V", 4},
    {"W", 4},
    {"Y", 4},
    {"K", 5},
    {"J", 8},
    {"X", 8},
    {"Q", 10},
    {"Z", 10}
  };
 } 
}