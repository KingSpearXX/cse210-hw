using System;

namespace ScriptureMemorizer
{
    class Reference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public int? Range { get; set; }
        public string Text { get; set; }

        public Reference(string book, int chapter, int verse, string text)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
            Text = text;
        }
        
        public Reference(string book, int chapter, int verse, int range, string text)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
            Range = range;
            Text = text;
        }
        public string GetDisplayText()
        {
            return Text;
        }
   }
}