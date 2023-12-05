using System;

class Program
{
static void Main()
    {

        var videos = new List<Video>
        {
            new Video
            {
                Title = "Introduction to Programming",
                Author = "John Doe",
                LengthInSeconds = 300,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "Alice", CommentText = "Great video!" },
                    new Comment { CommenterName = "Bob", CommentText = "I learned a lot." },
                    new Comment { CommenterName = "Charlie", CommentText = "Could be more detailed." }
                }
            },
            new Video
            {
                Title = "Data Structures Explained",
                Author = "Jane Smith",
                LengthInSeconds = 450,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "David", CommentText = "Awesome explanation!" },
                    new Comment { CommenterName = "Eva", CommentText = "Confusing at times." }
                }
            },

        };


        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}