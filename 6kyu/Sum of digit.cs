using System;
public class Number
{
  public int DigitalRoot(long n)
  {
    string nums = Convert.ToString(n);
    int res = 0;
    for(int i = 0; i < nums.Length; i++)
      res += int.Parse(nums[i].ToString());

    if(res > 9)
      return DigitalRoot(res);

    return res;
  }
}