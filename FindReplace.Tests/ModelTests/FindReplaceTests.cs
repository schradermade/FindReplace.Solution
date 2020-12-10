using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Words.Models;
using System;

namespace Words.Tests
{
  [TestClass]
  public class WordSwapTests : IDisposable
  {
    public void Dispose()
    {
      WordSwap.ClearAll();
    }

    [TestMethod]
    public void GetSomeUserText_ReturnsSomeUserText_String()
    {
      // Arrange
      string newWords = "All work and no play makes Jack a dull boy.";
      // Console.WriteLine("Here are newWords: " + newWords);

      // Act
      WordSwap newText = new WordSwap(newWords);
      // Console.WriteLine("Here are your newText: " + newText);
      string result = newText.NewWords;
      // Console.WriteLine("Here are your result: " + result);

      // Assert
      Assert.AreEqual(newWords, result);
    }
  }
}