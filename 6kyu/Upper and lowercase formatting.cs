using System.Text;
using System;
public class Kata
{
  /*Task:
  Нужно для входной строки применить форматирование, таким образом,
  чтобы слова имели 1 заглавную букву (первую), кроме слов из определенного
  набора, эти слова оставить как есть (только если это не первое слово в строке)
  */
  public static string TitleCase(string title, string minorWords="")
  {
    if(title.Length == 0)
      return "";
    title = title.ToLower();
    string[] minors = new string[0];
    if(minorWords!= null)
    {
      minorWords = minorWords.ToLower();
      minors = minorWords.Split(new char[] { ' ' });
    }
    string[] words = title.Split(new char[] { ' ' });
    StringBuilder strBuilder = new StringBuilder(words[0]);
    strBuilder[0] = Char.ToUpper(strBuilder[0]);
    words[0] = strBuilder.ToString();
    bool containInMinor = false;
    for(int i = 1; i < words.Length; i++)
    {
      containInMinor = false;
      if(minorWords != null)
      {
        for(int q = 0; q < minors.Length; q++)
        {
        if(words[i] == minors[q])
          containInMinor = true;
        }
      }
      if(!containInMinor)
      {
        strBuilder.Remove(0, strBuilder.Length);
        strBuilder.Append(words[i]);
        strBuilder[0] = Char.ToUpper(strBuilder[0]);
        words[i] = strBuilder.ToString();
      }
    }
    return String.Join(' ', words);
  }
}
