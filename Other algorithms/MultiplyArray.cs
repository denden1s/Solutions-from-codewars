using System;
namespace Prog
{
  class Program
  {
    //method with for
    static int[] Calculate(int[] arr)
    {
      int [] result = new int[arr.Length];
      for(int i = 0; i < arr.Length; i++)
      {
        result[i] = 1;
        for(int j = 0; j < arr.Length; j++)
        {
          if(i != j)
            result[i]*= arr[j]; 
        }
      }
      return result;
    }
    //method with while - faster than for
    static int[] Calc(int[] arr)
    {
      int [] result = new int[arr.Length];
      int currentIndex = 0;
      for(int q = 0; q < arr.Length; q++)
        result[q] = 1;
		  int i = 0;
      do
      {
        if(i == arr.Length)
        {
          i = 0;
          currentIndex++;
        }
        if(i != currentIndex)
          result[currentIndex] *= arr[i];
        i++;
      }while(result.Length - 1 != currentIndex);
		return result;
    }
  }
}