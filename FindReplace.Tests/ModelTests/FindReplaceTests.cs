using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Numbers.Models;
using System;

namespace Numbers.Tests
{
  [TestClass]
  public class PrimeTests : IDisposable
  {

    public void Dispose()
    {
      Prime.ClearAll();
    }

    [TestMethod]
    public void PrimeConstructor_ReturnsNumber_Integer()
    {
      // Arrange
      int userInput = 15;
      
      // Act
      Prime newPrime = new Prime(userInput);
      int result = newPrime.UserInput;

      // Assert
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }

    [TestMethod]
    public void CreateArray_ReturnsArray_Array()
    {
      // Arrange
      int userInput = 5;
      List<int> hardCodedResult = new List<int> {2,3, 4, 5};
      
      Console.WriteLine("This is hard code: ");
      foreach(int item in hardCodedResult)
      {
        Console.WriteLine(item);
      }

      
      Prime testPrime = new Prime(userInput);

      // Act
      List<int> result = testPrime.CreateArray();

      Console.WriteLine("This is result: ");
      foreach(int item in result)
      {
        Console.WriteLine(item);
      }

      // Assert
      CollectionAssert.AreEqual(hardCodedResult, result);
    }


  }
}