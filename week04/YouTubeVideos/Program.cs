using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        

        // Create a video
        Video video1 = new Video("My First Video", "John Doe", 120);
        Video video2 = new Video("My Second Video", "Jane Smith", 180);
        Video video3 = new Video("My Third Video", "Alice Johnson", 240);

        // Add comments to the video
        Comment comment1 = new Comment("Great video!", "Alice");
        Comment comment2 = new Comment("Thanks for sharing.", "Bob");
        Comment comment3 = new Comment("I learned a lot.", "Charlie");
        Comment comment4 = new Comment("Awesome content!", "David");
        Comment comment5 = new Comment("Keep up the good work.", "Eve");
        Comment comment6 = new Comment("This is very helpful.", "Frank");
        Comment comment7 = new Comment("I love this!", "Grace");
        Comment comment8 = new Comment("Can't wait for the next video.", "Hannah");
        Comment comment9 = new Comment("This is amazing!", "Ian");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // Display video information
        foreach (Video video in videos)
        { 
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            // Display comments 
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetText()} (by {comment.GetAuthor()})");
            }

            Console.WriteLine();
        } 

    }
}