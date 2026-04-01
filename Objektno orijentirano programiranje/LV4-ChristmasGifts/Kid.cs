public class Kid
{
    public int siblingsFightCounter { get; set; }
    public int goodDeedsCounter { get; set; }
    public bool brushingTeethRegularly { get; set; }

    public Kid(int siblingsFightCounter, int goodDeedsCounter, bool brushingTeethRegularly)
    {
        this.siblingsFightCounter = siblingsFightCounter;
        this.goodDeedsCounter = goodDeedsCounter;
        this.brushingTeethRegularly = brushingTeethRegularly;
    }
    public override string ToString()
    {
        return $"fight counter: {siblingsFightCounter}, good deeds counter: {goodDeedsCounter}, brushing teeth regularly: {brushingTeethRegularly}";
    }
}
