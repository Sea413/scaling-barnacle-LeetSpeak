using System.Collections.Generic;

namespace LeetSpeakGen
{

  public class LeetSpeak
  {
    private string _string;
    private int _id;
    private static List<string> _instances = new List<string> {};

  public LeetSpeak(string userinput)

  {
    _string = userinput;
    char[] array = userinput.ToCharArray();
    for (int i =1; i <= array.Length; i++)
    {
      if (array[i] == 'e') {
      userinput = userinput.Replace('e', '3');

      }
    }
  }

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
