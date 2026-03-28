using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            BuildVideo(
                "Starlight Serenade | Official Trailer",
                "HeartLine Studios",
                600,
                new List<Comment>
                {
                    new Comment("Adaeze", "That rooftop scene already has me crying."),
                    new Comment("Chinedu", "The chemistry is unreal."),
                    new Comment("Ifunanya", "The score gives me goosebumps."),
                }
            ),
            BuildVideo(
                "Sunset Letters | Official Trailer",
                "LunaLight Pictures",
                1425,
                new List<Comment>
                {
                    new Comment("Kelechi", "The meet-cute on the train is adorable."),
                    new Comment("Amara", "Already shipping them after 30 seconds."),
                    new Comment("Tunde", "Those letters feel so heartfelt."),
                    new Comment("Zainab", "Please tell me this has a happy ending."),
                }
            ),
            BuildVideo(
                "Always, June | Teaser",
                "NorthPier Films",
                930,
                new List<Comment>
                {
                    new Comment("Ifeanyi", "This looks like a love story done right."),
                    new Comment("Nneka", "That final glance in the teaser!"),
                    new Comment("Bola", "I need the full movie now."),
                }
            ),
            BuildVideo(
                "Two Tickets to Paris | Trailer",
                "GoldenArc Cinema",
                3600,
                new List<Comment>
                {
                    new Comment("Chiamaka", "The Paris montage is pure romance."),
                    new Comment("Femi", "I already love their slow-burn vibe."),
                    new Comment("Sade", "Can we get a release date soon?"),
                }
            )
        };

        foreach (Video video in videos)
        {
            DisplayVideo(video);
            Console.WriteLine();
        }
    }

    private static Video BuildVideo(string title, string author, int lengthSeconds, List<Comment> comments)
    {
        Video video = new Video(title, author, lengthSeconds);

        foreach (Comment comment in comments)
        {
            video.AddComment(comment);
        }

        return video;
    }

    private static void DisplayVideo(Video video)
    {
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length (seconds): {video.LengthSeconds}");
        Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in video.GetComments())
        {
            Console.WriteLine($"- {comment.AuthorName}: {comment.Text}");
        }
    }
}
