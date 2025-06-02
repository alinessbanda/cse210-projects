using System;
using System.Collections.Generic;
using System.Text;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _commentList;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _commentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDisplayString()
    {
        StringBuilder display = new StringBuilder();
        display.AppendLine($"Title: {_title}");
        display.AppendLine($"Author: {_author}");
        display.AppendLine($"Length: {_videoLength} seconds");
        display.AppendLine("Comments:");

        foreach (var comment in _commentList)
        {
            display.AppendLine($" - {comment.GetDisplayString()}");
        }

        return display.ToString();
    }
}
