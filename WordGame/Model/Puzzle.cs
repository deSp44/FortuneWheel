namespace FortuneWheel.Model
{
    //TODO : Add hiperlink in credits
    //TODO : Database with random selection of sentences

    public class Puzzle
    {
        public string Category { get; set; }
        public string Sentence { get; set; }
        public int? PossibleAttempts { get; set; }
        public int? TimeRemains  { get; set; }
    }
}