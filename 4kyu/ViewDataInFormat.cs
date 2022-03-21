using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class HumanTimeFormat{
    static string _seconds = "";
    static string minutes = "";
    static string hours = "";
    static string days = "";
    static string years = "";
  static string [] timeDesignation = {"now","second","minute", "hour", "day", "year"};
  public static string formatDuration(int seconds){
    _seconds = SetInterval(seconds % 60, 1);
    minutes = SetInterval((seconds / 60) %60,2);
    hours = SetInterval((seconds / 3600) %24, 3);
    days = SetInterval((seconds / 86400) %365, 4);
    years = SetInterval(seconds / 31536000, 5);
    List<string> info = new List<string>() {years,days, hours, minutes, _seconds};
    List<string> infoWithoutNull = info.Where(i => i != "").ToList();
    StringBuilder result = new StringBuilder();
    for(int i = 0; i < infoWithoutNull.Count; i++)
    {
      if(i < infoWithoutNull.Count - 2)
        result.Append(infoWithoutNull[i] + ", ");
      else if(i < infoWithoutNull.Count - 1)
        result.Append(infoWithoutNull[i] + " and ");
      else
         result.Append(infoWithoutNull[i]);
    }
    return Convert.ToString(result) == ""? "now" : Convert.ToString(result);
  }
  private static string  SetInterval(int _seconds, int indexOfPeriod)
  {
    if(_seconds > 0)
      return  _seconds > 1? $"{_seconds} {timeDesignation[indexOfPeriod]}s" : $"{_seconds} {timeDesignation[indexOfPeriod]}";
    return "";
  }
}