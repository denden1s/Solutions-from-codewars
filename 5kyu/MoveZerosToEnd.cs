using System;
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    //View(arr);
    int zeroCounts = (from a in arr
                     where a == 0
                     select a).Count();
    int index = Array.IndexOf(arr,0);
    int size = arr.Length - 1;
    if(zeroCounts != 0)
    {
      while(size - zeroCounts >= index)
      {
        for(int i = index; i < size; i++)
          arr[i] = arr[i+1];
        arr[size] = 0;
        index = Array.IndexOf(arr,0); 
      }
    }
    return arr;
  }
}