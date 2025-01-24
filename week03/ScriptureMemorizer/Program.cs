using System;
using Microsoft.VisualBasic;

namespace ScriptureMemorizer {
    class Program
    {
        public static List<Reference> scripturesVerses = new List<Reference>();
        static void Main(string[] args)
        {
            initializeScriptures();
            Random random = new Random();
            int randomIndex = random.Next(0, scripturesVerses.Count);
            Reference randomScripture = scripturesVerses[randomIndex];
            Scripture scripture = new Scripture(randomScripture);
            Console.WriteLine("Memorize the following scripture:");
            do
            {
                Console.Clear();
                scripture.GetDisplayText();
                Console.Write("\nPress enter to Hide a word or type \"quit\" to exit: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords(random.Next(1, 4));
                }
            } while (!scripture.isCompletelyHidden());
            Console.Clear();
            scripture.GetDisplayText();
            Console.Write("\nPress enter to to exit: ");
        }
        private static void initializeScriptures()
        {
            scripturesVerses.Add(new Reference("John", 3, 16, 17, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."));
            scripturesVerses.Add(new Reference("Romans", 3, 23, "For all have sinned and fall short of the glory of God."));
            scripturesVerses.Add(new Reference("Moroni", 10, 4, 5, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."));
            scripturesVerses.Add(new Reference("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.")); 
            scripturesVerses.Add(new Reference("Doctrine and Covenants", 88, 118, "And as all have not faith, seek ye diligently and teach one another words of wisdom; yea, seek ye out of the best books words of wisdom; seek learning, even by study and also by faith."));
            scripturesVerses.Add(new Reference("Doctrine and Covenants", 130, 21, 22, "And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated. The Father has a body of flesh and bones as tangible as man’s; the Son also; but the Holy Ghost has not a body of flesh and bones, but is a personage of Spirit. Were it not so, the Holy Ghost could not dwell in us."));
        }

    }
}