using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace WordRacer
{
    public partial class Game : Form
    {
        private readonly Dictionary m_dictionary = new Dictionary(10);
        private readonly string m_wavPath = @"..\..\Resources\Sounds\";
        private int m_points = 0;
        private readonly List<string> m_foundWords = new List<string>();
        private int m_remaining = 0;
        private readonly GameConfig m_config = new GameConfig();
        private readonly string m_validAlphaCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private int m_lastWordTimePos = 0;

        public Game()
        {
            InitializeComponent();

            foreach (Label lbl in Controls.OfType<Label>().Where(lbl => lbl.Name.StartsWith("label")))
                Program.AddFont("scramblefont", lbl);

            // init the timer
            timerCountdown.Enabled = false;
            timerCountdown.Interval = 1000;

            // disable the word control
            textboxWord.Enabled = false;

            //init our labels
            m_points = 0;
            textboxWord.Text = "";
            textboxScrambled.Text = "";
            lblWordsFound.Text = "0";
            lblPoints.Text = "0";
            lblPossibleWords.Text = "";

            //buttons
            buttonSubmit.Enabled = false;
            buttonSolve.Enabled = false;

            // init the progressbar
            progressBar.SetState(2); // make it red
            progressBar.Minimum = 0;
            progressBar.Enabled = false;
        }


        /// <summary>
        /// Fired when the user clicks the New Game button
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        /// <summary>
        /// Fired when the user hits return after typing in a word. The button 
        /// itself is on the form behind the list box so it's invisible to the 
        /// user, but still avaiable for use as the default button.
        /// </summary>
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            // get the typed word
            string thisWord = textboxWord.Text;
            string soundFile;
            // if it's empty insult the user and return
            if (thisWord == "")
            {
                soundFile = "null_word.wav";
            }
            else
            {
                // look for the word in the appropriate wordlist object
                int foundIndex = m_dictionary.FindWord(thisWord);
                // found it!
                if (foundIndex >= 0)
                {
                    soundFile = "valid_word.wav";
                    // if the user hasn't already submitted the current word
                    if (!m_dictionary.IsDuplicateWord(foundIndex))
                    {
                        // add the word to the list
                        listboxWords.Items.Add(thisWord);
                        // mark the word as used
                        m_dictionary.MarkWordAsUsed(foundIndex);

                        // calculate the points and add them to our total
                        m_points += m_dictionary.WordPoints(foundIndex);

                        // save the time at which the user submitted this word
                        m_lastWordTimePos = m_remaining;
                    }
                    else
                    {
                        // duplicate word - penalize the user
                        soundFile = "duplicate_word.wav";
                        m_points -= 2;
                    }
                }
                else
                {
                    // invalid word - penalize the user
                    soundFile = "invalid_word.wav";
                    m_points -= m_dictionary.WordPoints(thisWord);
                }
                // update our static labels
                lblPoints.Text = Convert.ToString(m_points);
                lblWordsFound.Text = Convert.ToString(listboxWords.Items.Count);
                textboxWord.Text = "";
                textboxWord.Focus();
            }
            PlayGameSound(soundFile);
        }


        /// <summary>
        /// Fired when the user types a letter
        /// </summary>
        private void TextboxWord_TextChanged(object sender, EventArgs e)
        {
            // only allow certain alphabetic characters.
            if (textboxWord.Text != "")
            {
                int charPos = textboxWord.Text.Length - 1;
                if (!m_validAlphaCharacters.Contains(textboxWord.Text.Substring(charPos, 1)))
                {
                    textboxWord.Text = textboxWord.Text.Remove(charPos, 1);
                    PlayGameSound("boop.wav");
                }
            }
        }

        /// <summary>
        /// Fired when the timer ticks
        /// </summary>
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            // calculate and display the time remaining
            TimeRemaining(false);
        }

        /// <summary>
        /// Displays the configuration dialog.
        /// </summary>
        private void ButtonConfigure_Click(object sender, EventArgs e)
        {
            Configure configForm = new Configure
            {
                Visible = false
            };
            if (configForm.ShowDialog() == DialogResult.OK)
            {
                // reload the configuration data
                m_config.Reload();
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        /// <summary>
        /// Change the color of the text based on when the list is being updated.
        /// </summary>
        private void listboxWords_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.  Create a new 
            // Brush and initialize to a Black colored brush by default.
            e.DrawBackground();
            Brush myBrush = Brushes.Red;
            string word;
            if (e.Index >= 0)
                word = ((ListBox)sender).Items[e.Index].ToString();
            else
                word = "";
            Font newFont = (Font)e.Font.Clone();

            if (m_remaining > 0)
            {
            }
            else
            {
                WordItem item = m_dictionary.GetPossibleWordItem(word);
                if (!item.Used)
                {
                    myBrush = Brushes.DarkGray;
                }
                else
                {
                    newFont = new Font(e.Font, FontStyle.Bold | FontStyle.Italic);
                }
            }
            if (word == m_dictionary.CurrentWord)
            {
                word += "**";
            }

            // Draw the current item text based on the current  Font and the custom brush settings.
            e.Graphics.DrawString(word, newFont, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle  around the selected item.
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Counts the number of words in the listbox that contain letterCount letters.
        /// </summary>
        /// <param name="letterCount">The number of letters that the word must contain in 
        /// order to be counted. This function should be called BEFORE posting the 
        /// remaining possible words to the listbox.</param>
        /// <returns>The number of words in the listbox that contain letterCount 
        /// letters.</returns>
        private int CountLetterWords(int letterCount)
        {
            int letterWords = 0;
            if (letterCount <= textboxScrambled.Text.Length)
            {
                for (int i = 0; i < listboxWords.Items.Count; i++)
                {
                    if (letterCount == listboxWords.Items[i].ToString().Length)
                    {
                        letterWords++;
                    }
                }
            }
            return letterWords;
        }

        /// <summary>
        /// Posts the remaining possible words to the listbox.
        /// </summary>
        private void PostRemainingWords()
        {
            WordGroup possibleWords = m_dictionary.GetWordGroup(0);
            for (int i = 0; i < possibleWords.Count; i++)
            {
                WordItem item = possibleWords.GetWord(i);
                if (item != null && item.Text != "")
                {
                    if (!listboxWords.Items.Contains(item.Text))
                    {
                        listboxWords.Items.Add(item.Text);
                    }
                }
            }
        }

        /// <summary>
        /// Plays the specified sound file. Sound files must be PCM for the 
        /// SoundPlayer to be able to play them.
        /// </summary>
        private void PlayGameSound(string filename)
        {
            // only play the sound file if the filename isn't blank and the 
            // configuration allows it
            if (m_config.PlaySounds && filename != "")
            {
                SoundPlayer sp = new SoundPlayer(m_wavPath + filename);
                try
                {
                    sp.Play();
                }
                catch { }
            }
        }

        /// <summary>
        /// Calculates remaining time, and updates the progressbar.
        /// </summary>
        private void TimeRemaining(bool beginning)
        {
            // if we're not just starting out with this word scramble, we need to 
            // decrement the timer and maybe taunt the user
            if (!beginning)
            {
                // decrement the timer
                m_remaining -= 1;
                // update the progressbar value
                progressBar.Value -= 1;
            }

            // if the game has expired, make an appropriate sound and update the game 
            // results panel.
            if (m_remaining == 0)
            {
                EndGame();
            }
        }

        /// <summary>
        /// Performs all end-of-game functionality, including calculating statistics, 
        /// stopping the timer, and posting unused words in the listbox.
        /// </summary>
        private void EndGame()
        {
            timerCountdown.Stop();
            m_remaining = 0;
            textboxWord.Text = "";
            textboxWord.Enabled = false;
            PlayGameSound("solve_word.wav");

            int wordsFound = listboxWords.Items.Count;
            int possible = Math.Max(1, m_dictionary.PossibleWordCount);
            double percentageFound = ((double)wordsFound / possible) * 100.0;
            double pointsPerWord = ((double)m_points / wordsFound);
            int[] letterWords = new int[m_dictionary.MaxGroups + 1];
            letterWords.Initialize();
            for (int i = 3; i < letterWords.Length; i++)
            {
                letterWords[i] = CountLetterWords(i);
            }
            PostRemainingWords();

            string gameStats = $"% words found: {percentageFound}\n" +
                               $"Points per word: {pointsPerWord}\n" +
                               $"\n3-letter words: {letterWords[3]}\n" +
                               $"4-letter words: {letterWords[4]}\n" +
                               $"5-letter words: {letterWords[5]}\n" +
                               $"6-letter words: {letterWords[6]}\n" +
                               $"7-letter words: {letterWords[7]}\n" +
                               $"8-letter words: {letterWords[8]}\n" +
                               $"9-letter words: {letterWords[9]}\n" +
                               $"10-letter words: {letterWords[10]}\n";

            labelGameStats.Text = gameStats;
            labelGameStats.Visible = true;
            groupboxStats.Visible = true;
            buttonSolve.Enabled = false;
            buttonSubmit.Enabled = false;
        }

        /// <summary>
        /// Starts a new game with a new word.
        /// </summary>
        private void StartNewGame()
        {
            PlayGameSound("newgame.wav");
            labelGameStats.Visible = false;
            groupboxStats.Visible = false;
            buttonSolve.Enabled = true;
            buttonSubmit.Enabled = true;
            labelGameStats.Text = "";

            // determine how many letters the scrambled word will have
            int letterCount = 0;
            switch (m_config.LetterPoolMode)
            {
                case 0: // random
                    Random random = new Random();
                    letterCount = random.Next(6, 10);
                    break;
                case 1: // static (user-specified value from 6 to 10)
                    letterCount = m_config.LetterCount;
                    break;
            }

            // get a word, and find all possible words that can be found in that word
            string scramble = m_dictionary.GetRandomWord(letterCount, true);
            m_dictionary.FindPossibleWords(scramble);

            // init our controls
            textboxScrambled.Text = scramble;
            textboxWord.MaxLength = scramble.Length;
            textboxWord.Focus();
            listboxWords.Items.Clear();
            lblWordsFound.Text = "0";

            // zero the points
            m_points = 0;
            lblPoints.Text = Convert.ToString(m_points);

            // count the possible words
            lblPossibleWords.Text = Convert.ToString(m_dictionary.PossibleWordCount);

            // clear out our found words
            m_foundWords.Clear();

            // set the time remaining
            switch (m_config.TimerMode)
            {
                case 0: // none
                    m_remaining = 0;
                    break;
                case 1: // static
                    m_remaining = m_config.StaticSeconds;
                    break;
                default:
                    m_remaining = 0;
                    break;
            }

            // initialize the taunt timeout
            m_lastWordTimePos = m_remaining;

            // if we have time remaining, update the time remaining controls, and start the timer
            if (m_remaining > 0)
            {
                TimeRemaining(true);
                timerCountdown.Enabled = true;
                progressBar.Maximum = m_remaining;
                progressBar.Value = m_remaining;
                progressBar.Visible = true;
                timerCountdown.Start();
            }
            else
            {
                // otherwise, disable the timer and hide the timer controls
                timerCountdown.Enabled = false;
                progressBar.Visible = false;
            }

            // allow the user to type in the "word" control
            textboxWord.Enabled = true;
            // set focus to it
            textboxWord.Focus();
        }
    }
}
