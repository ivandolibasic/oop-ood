namespace oop.pr;

public class YouTubeVideo
{
    private string author;
    private string title;
    private int duration;
    private int likes;
    private int dislikes;

    public YouTubeVideo(string author, string title, int duration)
    {
        this.author = author;
        this.title = title;
        this.duration = duration;
        likes = 0;
        dislikes = 0;
    }

    public void React(string react)
    {
        if (react == "like")
            likes++;
        else
            dislikes++;
    }

    public string TotalImpressions()
    {
        if (likes + dislikes == 0)
            return "Neutral";
        double ratio = (double)likes / (likes + dislikes);
        if (likes > dislikes && (likes - dislikes) >= 0.1 * (likes + dislikes))
            return "Positive";
        if (dislikes > likes && (dislikes - likes) >= 0.1 * (likes + dislikes))
            return "Negative";
        return "Neutral";
    }
}