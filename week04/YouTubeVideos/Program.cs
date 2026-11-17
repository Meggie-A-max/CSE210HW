using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Smith", 600);
        video1.AddComment(new Comment("Mary", "Very helpful video!"));
        video1.AddComment(new Comment("David", "I learned something new."));
        video1.AddComment(new Comment("Grace", "Thank you for explaining."));
        videos.Add(video1);

        Video video2 = new Video("Learning Python", "Sarah James", 900);
        video2.AddComment(new Comment("Peter", "Great explanation."));
        video2.AddComment(new Comment("Jane", "This was easy to follow."));
        video2.AddComment(new Comment("Paul", "I enjoyed this lesson."));
        videos.Add(video2);

        Video video3 = new Video("Web Development Basics", "Michael Brown", 1200);
        video3.AddComment(new Comment("Anne", "Excellent tutorial."));
        video3.AddComment(new Comment("James", "Please make more videos."));
        video3.AddComment(new Comment("Faith", "Very informative."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}