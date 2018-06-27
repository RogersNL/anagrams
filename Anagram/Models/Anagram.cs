using System;
using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    private string _compareWord;
    private static List<Anagram> _instances = new List<Anagram> {};
    public Anagram (string compareWord)
    {
      _compareWord = compareWord;
    }
    public static List<Anagram> GetList()
    {
      return _instances;
    }
    public string GetCompareWord()
    {
      return _compareWord;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public string anagramWordSort(string word)
    {
      char[] wordToArray = word.ToCharArray();
      Array.Sort(wordToArray);
      string newWord = string.Join("", wordToArray);
      return newWord;
    }
    public bool CompareTwoWords(string x, string y)
    {
      return x==y;
    }
  }
  public class program
  {
    public static void Main()
    {
      bool isDone=true;
      Console.WriteLine("Please enter your Word to check for anagram");
      string firstWord= Console.ReadLine();
      while(isDone==true)
      {
        Console.WriteLine("Would you like to add a new word or compare to anagram word? (add/compare)");
        string userInput= Console.ReadLine();
        if (userInput=="add")
        {
          Console.WriteLine("Please enter your item ");
          string newWord1= Console.ReadLine();
          Anagram newAnagram = new Anagram (newWord1);
          newAnagram.Save();
        }
        else if(userInput=="compare")
        {
          isDone=false;
        }
      }
      List<Anagram> instances = Anagram.GetList();
      Console.WriteLine("These words are anagrams");
      foreach(Anagram word in instances)
      {
        // Anagram newAnagram1 = new Anagram ("something");
        string wordX = word.anagramWordSort(firstWord);
        string wordY = word.anagramWordSort(word.GetCompareWord());
        if(word.CompareTwoWords(wordX, wordY))
        {
          Console.WriteLine(word.GetCompareWord());
        }
      }
    }
  }
}
//
//   {
//     return _instances;
//     //
//     // string answer =
//   }
// }
