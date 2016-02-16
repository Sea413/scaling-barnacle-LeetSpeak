using Xunit;
using System;
using System.Collections.Generic;
namespace LeetSpeakGen

{
  public class LeetSpeakTest
  {
    public class LSTest : IDisposable
    {
      [Fact]
      public void LS_SupaTest_attempt1()
      {
        //Arrange
        string userinput = "hello";
        LeetSpeak supastring = new LeetSpeak(userinput);
        List<string> test1 = supastring.GetAll();

        //Act
        List<string> testList = new List<string>{"h3llo"};

        //Assert
        Assert.Equal(testList, test1);
      }
      [Fact]
      public void LS_SupaTest_attempt2()
      {
        //Arrange
        string userinput = "hello";
        LeetSpeak supastring = new LeetSpeak(userinput);
        List<string> test1 = supastring.GetAll();

        //Act
        List<string> testList = new List<string>{"h3ll0"};

        //Assert
        Assert.Equal(testList, test1);
      }
      public void Dispose()
      {
        LeetSpeak.ClearAll();
      }
    }
  }
}
