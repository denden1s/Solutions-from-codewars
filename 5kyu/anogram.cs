using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
  /*Task:
  Нужно найти анаграммы слова
  */
  public static List<string> Anagrams(string word, List<string> words)
  {
    if(word.Length < 2)
      if(words.Where(i => i == word).Count() == 1)
        return new List<string>(){word};
      else
        return new List<string>();
    
    List<string> wordsWithSameLength = words.Where(i => i.Length == word.Length).ToList();
    List<string> anagrams = new List<string>();
    bool isAnagram = true;
    foreach(string maybeAnagram in wordsWithSameLength)
    {
      isAnagram = true;
      foreach(char symbol in maybeAnagram)
      {
        int countInWord = new Regex(Convert.ToString(symbol)).Matches(word).Count();
        int countInAnogram = new Regex(Convert.ToString(symbol)).Matches(maybeAnagram).Count();
        isAnagram = countInWord == countInAnogram;
        if(!isAnagram)
          break;
      }
      if(isAnagram)
        anagrams.Add(maybeAnagram);
    }
    return anagrams;
  }
}