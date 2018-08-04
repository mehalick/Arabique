namespace Arabique.Api
{
    public class Phrase
    {
        public string English { get; set; }
        public string Arabic { get; set; }

        public Phrase(string english, string arabic)
        {
            English = english;
            Arabic = arabic;
        }
    }
}
