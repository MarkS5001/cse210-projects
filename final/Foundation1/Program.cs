class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Bill Jumps!", "Bill", 3);
        video1.AddComment("Bob", "Now I know how to jump!");
        video1.AddComment("Joel", "Did we really need a video for this?");
        video1.AddComment("Gertrude", "I love seeing my grandson jump!");
        videos.Add(video1);

        Video video2 = new Video("Bob Fishes", "Bob", 60);
        video2.AddComment("Bill", "Wow! He jumped really high after catching that fish!");
        video2.AddComment("Joel", "Did it really need to be this long?");
        video2.AddComment("Gertrude", "I love seeing my daughter's son catch big fish!");
        videos.Add(video2);

        Video video3 = new Video("Joel Reads a Book", "Joel", 7);
        video3.AddComment("Bob", "I love listening to books as I fish!");
        video3.AddComment("Bill", "That was a good book, makes me want to jump!");
        video3.AddComment("Gertrude", "I love seeing my only son read the children books he writes!");
        videos.Add(video3);

        foreach(Video currentVideo in videos)
        {
            currentVideo.Display();
        }
    }
}