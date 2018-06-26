using System;
using System.Linq;

public class Translator
{
  public string leetString;

  public void TranslateSentence(string userInput)
  {
    string[] wordArray = userInput.Split(' ');

    foreach(string words in wordArray)
    {
    for(int index = 0; index < words.Length; index++)
      {
        if((index != 0 && words[index] == 's') || (index != 0 && words.ElementAt(index) == 'S'))
        {
          leetString += 'z';
        }
        else if(words.ElementAt(index) == 'e' || words.ElementAt(index) == 'E')
        {
          leetString += '3';
        }
        else if(words.ElementAt(index) == 'o' || words.ElementAt(index) == 'O')
        {
          leetString += '0';
        }
        else if(words.ElementAt(index) == 't' || words.ElementAt(index) == 'T')
        {
          leetString += '7';
        }
        else if(words.ElementAt(index) == 'i')
        {
          leetString += '1';
        }
        else
        {
          leetString += words.ElementAt(index);
        }
      }
      leetString += ' ';
    }
    Console.WriteLine(leetString);
  }

}

class Program
{
  public static void Main()
  {
    Translator newTranslation = new Translator();
    Console.WriteLine("Enter a word or sentence to have it converted to 1337 speak");
    string stringInput = Console.ReadLine();
    newTranslation.TranslateSentence(stringInput);
  }
}
