using System;
using System.Collections.Generic;
using System.Text;

public class Viewer
{
    private string _viewerName;
    private List<Video> _watchedVideos;

    public Viewer(string viewerName)
    {
        _viewerName = viewerName;
        _watchedVideos = new List<Video>();
    }

    public void WatchVideo(Video video)
    {
        _watchedVideos.Add(video);
    }

    public void LeaveComment(Video video, string commentText)
    {
        Comment comment = new Comment(_viewerName, commentText);
        video.AddComment(comment);
    }

    public string GetDisplayString()
    {
        StringBuilder display = new StringBuilder();
        display.AppendLine($"Viewer: {_viewerName}");
        display.AppendLine("Watched Videos:");
        foreach (var video in _watchedVideos)
        {
            display.AppendLine($" - {video.GetTitle()}");
        }
        return display.ToString();
    }
}
