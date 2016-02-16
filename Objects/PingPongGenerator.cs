using System.Collections.Generic;

namespace LeetSpeakGen
{

  public class LeetSpeak
  {
    private string _string;
    private int _id;
    private static List<string> _instances = new List<string> {};

  public LeetSpeak(string userInput)

  {
    _string = userInput;
    char[] array = userInput.ToCharArray();
    for (int i =0; i < array.Length; i++)
    {
      if (array[i] == 'e') {
      userInput = userInput.Replace('e', '3');
      _instances.Add (userInput);
      // userInput = string.Join("", array);
      }
      // else
      // {
      //   return _string;
      // }
    }
  }

  // public string LeetSpeakConverter(string input)
  // {
  //
  // }

    public List<string> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
