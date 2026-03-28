using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int LengthSeconds { get; }

    private readonly List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }
}
