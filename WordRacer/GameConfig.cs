using WordRacer.Properties;

namespace WordRacer
{
    public class GameConfig
    {
        public int LetterPoolMode { get; set; } // 0 = random (default), 1 = static
        public int LetterCount { get; set; }  // if moe is static, value can be 6-10.
        public int MinimumLettersPerWord { get; set; }
        public int TimerMode { get; set; } // 0 = none, 1=static seconds, 2 = seconds per letter, 3 = both
        public int SecondsPerLetter { get; set; }
        public int StaticSeconds { get; set; }
        public bool PlaySounds { get; set; }
        public bool AllowRepeatedWords { get; set; }
        public bool ShowInstructions { get; set; }

        public GameConfig()
        {
            Reload();
        }

        public void Reload()
        {
            Settings.Default.Reload();
            LetterPoolMode = Settings.Default.LetterPoolMode;
            LetterCount = Settings.Default.LetterPoolCount;
            MinimumLettersPerWord = Settings.Default.MinimumLettersPerWord;
            TimerMode = Settings.Default.TimerMode;
            SecondsPerLetter = Settings.Default.SecondsPerLetter;
            StaticSeconds = Settings.Default.StaticSeconds;
            PlaySounds = Settings.Default.PlaySounds;
            AllowRepeatedWords = Settings.Default.AllowRepeatedWords;
            ShowInstructions = Settings.Default.ShowInstructions;
        }

        public void Write()
        {
            Settings.Default.LetterPoolMode = LetterPoolMode;
            Settings.Default.LetterPoolCount = LetterCount;
            Settings.Default.MinimumLettersPerWord = MinimumLettersPerWord;
            Settings.Default.TimerMode = TimerMode;
            Settings.Default.SecondsPerLetter = SecondsPerLetter;
            Settings.Default.StaticSeconds = StaticSeconds;
            Settings.Default.PlaySounds = PlaySounds;
            Settings.Default.AllowRepeatedWords = AllowRepeatedWords;
            Settings.Default.ShowInstructions = ShowInstructions;
            Settings.Default.Save();
        }

        public void SetToDefault()
        {
            Settings.Default.Reset();
            Settings.Default.Reload();
        }
    }
}
