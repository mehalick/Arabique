using System;

namespace Arabique.Api
{
    public class PhraseTest
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public PhraseTest(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public static PhraseTest Create(Phrase phrase)
        {
            return new Random().Next(0, 2) == 0
                ? new PhraseTest(phrase.English, phrase.Arabic)
                : new PhraseTest(phrase.Arabic, phrase.English);
        }
    }
}
