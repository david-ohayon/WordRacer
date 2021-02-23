using WordRacer.Properties;

namespace WordRacer
{
    public class GameConfig
    {
        public int LetterPoolMode { get; set; } // 0 = random (default), 1 = static
        public int LetterCount { get; set; }  // if moe is static, value can be 6-10.
        public int TimerMode { get; set; } // 0 = none, 1=static seconds, 2 = seconds per letter, 3 = both
        public int StaticSeconds { get; set; }
        public bool PlaySounds { get; set; }
        public bool AllowRepeatedWords { get; set; }

        public GameConfig()
        {
            Reload();
        }

        public void Reload()
        {
            Settings.Default.Reload();
            LetterPoolMode = Settings.Default.LetterPoolMode;
            LetterCount = Settings.Default.LetterPoolCount;
            TimerMode = Settings.Default.TimerMode;
            StaticSeconds = Settings.Default.StaticSeconds;
            PlaySounds = Settings.Default.PlaySounds;
            AllowRepeatedWords = Settings.Default.AllowRepeatedWords;
        }

        public void Write()
        {
            Settings.Default.LetterPoolMode = LetterPoolMode;
            Settings.Default.LetterPoolCount = LetterCount;
            Settings.Default.TimerMode = TimerMode;
            Settings.Default.StaticSeconds = StaticSeconds;
            Settings.Default.PlaySounds = PlaySounds;
            Settings.Default.AllowRepeatedWords = AllowRepeatedWords;
            Settings.Default.Save();
        }

        public void SetToDefault()
        {
            Settings.Default.Reset();
            Settings.Default.Reload();
        }
    }
}
