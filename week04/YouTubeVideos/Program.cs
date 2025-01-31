using System;

namespace YouTubeVideos
{  
    class Program
    {
        public List<Videos> _videos = new List<Videos>();
        
        public static void Main()
        {
            Program program = new Program();
            program.CreateVideos();
            foreach (Videos video in program._videos)
            {
                Console.WriteLine("--------------------");
                video.GetDisplayText();
            }
        }
        public void CreateVideos()
        {
            Videos video1 = new Videos("C# Tutorial", "Bob", "Learn C# in 30 minutes", "https://www.youtube.com/watch?v=0pZV8dJ7qHc", new string[] { "C#", "Programming", "Tutorial" }, 1000, 10, 1);
            Comments comment1 = new Comments("Alice", "Great video!");
            Replies reply1 = new Replies("Bob", "Thanks!");
            comment1.AddReply(reply1);
            video1.AddComment(comment1);
            _videos.Add(video1);
            
            Videos video2 = new Videos("Python Tutorial", "Alice", "Learn Python in 30 minutes", "https://www.youtube.com/watch?v=0pasdasqHc", new string[] { "Python", "Programming", "Tutorial" }, 2000, 20, 2);
            Comments comment2 = new Comments("Bob", "Great video!");
            Replies reply2 = new Replies("Alice", "Thanks!");
            Replies reply3 = new Replies("Bob", "You're welcome!");
            comment2.AddReply(reply2);
            comment2.AddReply(reply3);
            video2.AddComment(comment2);
            _videos.Add(video2);
        }
    }
}