using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  /*Task:
  Нужно найти элемент массива, который отличается от всех остальных
  по критерию четности/нечетности
  */
  public static int Find(int[] integers)
  {
    bool type = ((Math.Abs(integers[0] - integers[1]) % 2 == 0) &&
      (Math.Abs(integers[0] - integers[2]) % 2 == 0))? true : false;
    return FindNum(integers, type);
  }
  private static int FindNum(int[] nums, bool type)
  {
    int res = -1;
    foreach(int i in nums)
      if(Convert.ToInt32(type) + Convert.ToInt32(i % 2 == 0) == 1 )
        res = i;
    return res;
  }
}
