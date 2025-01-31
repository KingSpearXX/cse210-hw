using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Comments
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public List<Replies> _Replies { get; set; }

        public Comments(string author, string text)
        {
            Author = author;
            Text = text;
            Likes = 0;
            Dislikes = 0;
            _Replies = new List<Replies>();
        }
        public void AddReply(Replies reply)
        {
            _Replies.Add(reply);
        }
        public void Like()
        {
            Likes++;
        }
        public void Dislike()
        {
            Dislikes++;
        }
        public void GetDisplayText()
        {
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine($"Likes: {Likes}");
            Console.WriteLine($"Dislikes: {Dislikes}");
            Console.WriteLine("Replies:");
            foreach (Replies reply in _Replies)
            {
                Console.WriteLine($"\tAuthor: {reply.Author}");
                Console.WriteLine($"\tText: {reply.Text}");
                Console.WriteLine($"\tLikes: {reply.Likes}");
                Console.WriteLine($"\tDislikes: {reply.Dislikes} \n");
            }
        }
    }
}