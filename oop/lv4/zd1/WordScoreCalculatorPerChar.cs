namespace oop.lv4.zd1;

public class WordScoreCalculatorPerChar : WordScoreCalculator
{
    private int scorePerVowel;
    private int scorePerConsonant;

    public WordScoreCalculatorPerChar(int scorePerSegment, int segmentLength, int scorePerVowel, int scorePerConsonant)
        : base(scorePerSegment, segmentLength)
    {
        this.scorePerVowel = scorePerVowel;
        this.scorePerConsonant = scorePerConsonant;
    }

    public override int CalculateScore(string word)
    {
        int score = base.CalculateScore(word);
        foreach (char letter in word.ToLower())
        {
            if ("aeiou".Contains(letter))
                score += scorePerVowel;
            else if (Char.IsLetter(letter))
                score += scorePerConsonant;
        }
        return score;
    }
}