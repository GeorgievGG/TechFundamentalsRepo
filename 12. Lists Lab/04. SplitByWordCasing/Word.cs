namespace _04.SplitByWordCasing
{
    public class Word
    {
        public Word(string content)
        {
            this.Content = content;
            this.HasLower = false;
            this.HasUpper = false;
            this.HasSymbol = false;
        }

        public string Content { get; set; }

        public bool HasLower { get; set; }

        public bool HasUpper { get; set; }

        public bool HasSymbol { get; set; }
    }
}
