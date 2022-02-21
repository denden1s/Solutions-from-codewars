using System.Text;
using System;

public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
    int[] nums = {r, g, b};
    string result = "";
    for(int i = 0; i < nums.Length; i++)
    {
      string temp = "";
      nums[i] = nums[i] > 255 ? 255 : nums[i];
      nums[i] = nums[i] < 0 ? 0 : nums[i];
      temp = nums[i] == 0 ? Convert.ToString(nums[i], 16) + "0" : Convert.ToString(nums[i], 16) ;
      if(temp.Length == 1)
        temp = "0"+temp;
      result += temp;
      
    }
    foreach(var i in nums)
      Console.Write(i+" ");
    Console.WriteLine();
    
    //result = 

    return result.ToUpper();
  }
}