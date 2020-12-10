using System.Collections.Generic;
using System;

namespace Numbers.Models
{
  public class Prime
  {
    public int UserInput { get; set; }

    private static List<Prime> _instances = new List<Prime> {};

    public Prime(int userInput)
    {
      UserInput = userInput;
      _instances.Add(this);
    }

    public static List<Prime> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public List<int> CreateArray()
    {
      List<int> arrayNums = new List<int> { };
      for (int num = 2; num <= UserInput; num++)
      {
        arrayNums.Add(num);
      }

      return arrayNums;
    }

  }
}
