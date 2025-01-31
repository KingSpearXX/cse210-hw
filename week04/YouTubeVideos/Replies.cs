using System;

namespace YouTubeVideos
{
    class Replies
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public Replies(string author, string text)
        {
            Author = author;
            Text = text;
            Likes = 0;
            Dislikes = 0;
        }
        public void Like()
        {
            Likes++;
        }
        public void Dislike()
        {
            Dislikes++;
        }
    }
}