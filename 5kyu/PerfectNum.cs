using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
      if(n < 4) return null;
      for(int i = 2; i < Math.Sqrt(n)+1; i++)
      {
        int a = Convert.ToInt32(Math.Log(n,i));
        if(Math.Pow(i, a) == n)
          return(i,a);
      }
        return null;
    }
}