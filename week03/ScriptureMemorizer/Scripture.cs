using System;

namespace ScriptureMemorizer
{
    class Scripture
    {
        public Reference Scriptures { get; set; }
        public List<Word> Words { get; set; }
        
        public Scripture(Reference scriptures)
        {
            Scriptures = scriptures;
            Words = new List<Word>();
            string[] words = Scriptures.Text.Split(' ');
            foreach (string word in words)
            {
                Words.Add(new Word(word));
            }
        }
        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();

            int hiddenCount = Words.Count(word => word.isHidden);
            int availableToHide = Words.Count - hiddenCount;
            numberToHide = Math.Min(numberToHide, availableToHide);

            while (numberToHide > 0)
            {
                int randomIndex = random.Next(0, Words.Count);
                
                if (!Words[randomIndex].isHidden)
                {
                    Words[randomIndex].Hide();
                    numberToHide--;
                }
            }
        }

        public void GetDisplayText()
        {
            Console.Write($"{Scriptures.Book} {Scriptures.Chapter}:{Scriptures.Verse}{(Scriptures.Range != null ? $"-{Scriptures.Range}" : "")} : ");   
            foreach (Word word in Words)
            {
                Console.Write(word.ToString() + " ");
            }
            Console.WriteLine();
        }
        public bool isCompletelyHidden() 
        {
            foreach (Word word in Words) {
                if (!word.isHidden) {
                    return false;
                }
            }
            return true;
        }
   }
}