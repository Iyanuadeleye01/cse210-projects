using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Learn C# basic";
        video1._author = "Codewithiyanu";
        video1._LengthInSeconds = 500;

        //Add comments for video1
        video1._comments.Add(new Comment("Iyanu", "Nice video"));
        video1._comments.Add(new Comment("Alice", "Good"));
        video1._comments.Add(new Comment("Iyami", "Thanks for sharing"));


        Video video2 = new Video();
        video2._title = "Game Tutorial";
        video2._author = "Adeleye";
        video2._LengthInSeconds = 600;

        //Add comment for the video2
        video2._comments.Add(new Comment("Toyin", "I want to learn more"));
        video2._comments.Add(new Comment("Martins", "Learning is fun"));
        video2._comments.Add(new Comment("Toyin", "I like your lecture"));

        Video video3 = new Video();
        video3._title = "AI in 5 Minutes";
        video3._author = "Emmanuel";
        video3._LengthInSeconds = 900;

        //Add comment for the video3
        video3._comments.Add(new Comment("Dejo", "Thanks for this piece"));
        video3._comments.Add(new Comment("Ayo", "I will subscribe to this now"));
        video3._comments.Add(new Comment("Dejo", "best video"));

        //Create video list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        //Loop through the video list
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }

    }
}