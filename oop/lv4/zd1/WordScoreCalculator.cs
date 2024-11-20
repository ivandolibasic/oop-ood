namespace oop.lv4.zd1;

public class WordScoreCalculator
{
    private int scorePerSegment;
    private int segmentLength;

    public WordScoreCalculator(int scorePerSegment, int segmentLength)
    {
        this.scorePerSegment = scorePerSegment;
        this.segmentLength = segmentLength;
    }

    public virtual int CalculateScore(string word)
    {
        int numberOfSegments = word.Length / segmentLength;
        if (word.Length % segmentLength != 0)
            numberOfSegments++;
        return numberOfSegments * scorePerSegment;
    }
}