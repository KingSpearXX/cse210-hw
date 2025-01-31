using System;
using System.Collections.Generic;

namespace YouTubeVideos {
    class Videos
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string[] Tags { get; set; }
        public int Duration { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public List<Comments> Comments { get; set; }

        public Videos(string title, string author, string description, string url, string[] tags, int views, int likes, int dislikes)
        {
            Title = title;
            Author = author;
            Description = description;
            URL = url;
            Tags = tags;
            Views = views;
            Likes = likes;
            Dislikes = dislikes;
            Comments = new List<Comments>();
        }
        public void AddComment(Comments comment)
        {
            Comments.Add(comment);
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
            Console.WriteLine($"Title: {Title} URL: {URL}\n");
            Console.WriteLine($"Author: {Author} Description: {Description}");
            Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
            Console.WriteLine($"Duration: {Duration} seconds Views: {Views} Likes: {Likes} Dislikes: {Dislikes}");
            Console.WriteLine($"Comments: {Comments.Count}");
            foreach (Comments comment in Comments)
            {
                comment.GetDisplayText();
            }
        }
    }
}
