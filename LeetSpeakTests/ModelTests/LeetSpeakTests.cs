using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class TranslatorTest
    {
      public void Translator_IsAn_s_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("as"));
      }
      [TestMethod]
      public void Translator_IsAn_S_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("aS"));
      }
      [TestMethod]
      public void Translator_IsAne_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("e"));
      }
      [TestMethod]
      public void Translator_IsAnE_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("E"));
      }
      [TestMethod]
      public void Translator_IsAno_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("o"));
      }
      [TestMethod]
      public void Translator_IsAnO_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("O"));
      }
      public void Translator_IsA_t_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("t"));
      }
      [TestMethod]
      public void Translator_IsA_T_True()
      {
        Translator newTranslation = new Translator();
        Assert.AreEqual(true, newTranslation.TranslateSentence("T"));
      }

    }
}
