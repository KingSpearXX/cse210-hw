using System;

namespace App.Journal {
    public class PromptGenerator {
        public List<string> prompts = new List<string>();
        public PromptGenerator() {
            prompts.Add("What did you do today?");
            prompts.Add("What are you grateful for?");
            prompts.Add("What are you looking forward to?");
            prompts.Add("What are you feeling right now?");
            prompts.Add("What are you thinking about?");
        }
        public string GetRandomPrompt() {
            Random rand = new Random();
            int index = rand.Next(prompts.Count);
            return prompts[index];
        }
    }
}