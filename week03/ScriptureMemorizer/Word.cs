using System;

namespace ScriptureMemorizer
{
    class Word
    {
        public string Text { get; set; }
        public bool isHidden { get; set; }
        public Word(string text)
        {
            Text = text;
            isHidden = false;
        }
        public void Hide()
        {
            isHidden = true;
        }
        public void Show()
        {
            isHidden = false;
        }
        public override string ToString()
        {
            if (isHidden)
            {
                return new String('_', Text.Length);
            }
            else
            {
                return Text;
            }
        }
    }
}