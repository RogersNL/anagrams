using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;
using System;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void anagramWordSort_True()
    {
      //Arrange
      string testWord = "bread";
      Anagram newAnagram = new Anagram ("testWord");
      newAnagram.Save();
      //Act
      string result = newAnagram.anagramWordSort(testWord);

      //Assert
      Assert.AreEqual("abder", result);

    }
    [TestMethod]
    public void GetCompareWord_True()
    {
      //Arrange
      string testWord = "bread";
      Anagram newAnagram = new Anagram (testWord);
      newAnagram.Save();

      //Act
      List<Anagram> instances = newAnagram.GetList();
      Anagram savedItem = instances[0];
      string results = instances[0].GetCompareWord();

      //Assert
      Assert.AreEqual(testWord, results);
    }
  }
}
