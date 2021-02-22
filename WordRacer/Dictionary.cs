using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WordRacer
{

    /// <summary>
    /// This class represents a word in a word group
    /// </summary>
    public class WordItem
    {
        public string Text { get; } = "";
        public bool Used { get; set; } = false;

        public WordItem(string text)
        {
            Text = text;
            Used = false;
        }

    }

    /// <summary>
    /// This class holds a group of words. 
    /// </summary>
    public class WordGroup
    {
        private readonly int[] m_wordPoints = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
        private readonly int[] m_1stLetter = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private readonly List<WordItem> m_wordList = new List<WordItem>();
        private readonly int m_highEnd = -1;

        public bool TrackRepeats { get; set; } = true;
        public string CurrentWord { get; set; } = "";
        public int LetterCount { get; set; } = 0;
        public int Count { get => m_wordList.Count; }
        public int CountUsed { get { return CountUsedWords(); } }


        public WordGroup(int letterCount)
        {
            m_wordList.Clear();
            LetterCount = letterCount;
            // we only need to load a file if the number of letters is 3 or more
            if (letterCount >= 3)
            {
                LoadFile($@"..\..\Resources\Words\{letterCount}.txt");
            }
            m_highEnd = Count;
        }

        /// <summary>
        /// Loads the file that contains a list of words. Each list of words is 
        /// constrained by the number of letters in the words.
        /// </summary>
        protected bool LoadFile(string fileName)
        {
            bool success = false;
            try
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader reader = new StreamReader(stream);
                string words;
                while (!reader.EndOfStream)
                {
                    words = reader.ReadLine();
                    if (words.Length > 0)
                    {
                        string[] wordsplit = words.Split(' ');
                        for (int i = 0; i < wordsplit.Length; i++)
                        {
                            WordItem item = new WordItem(wordsplit[i].ToLower());
                            m_wordList.Add(item);
                        }
                    }
                }
                success = true;
            }
            catch (Exception e)
            {
                if (e != null) { }
            }
            if (success)
            {
                FindLetterIndexes();
            }
            return success;
        }

        /// <summary>
        /// Finds the starting position for each word by the first letter in 
        /// that word, and stores the results in a list.  This helps limit 
        /// the search for a correct word by allowing us to search a very 
        /// small subset of each letter-count group.  Some word groups 
        /// contain tens of thousands of words.
        /// </summary>
        protected void FindLetterIndexes()
        {
            int start = 0;
            for (int i = 0; i < 26; i++)
            {
                int intValue = 97 + i;
                string charValue = Convert.ToChar(intValue).ToString();
                if (m_wordList[start].Text.StartsWith(charValue))
                {
                    m_1stLetter[i] = start;
                    for (int j = start; j < Count; j++)
                    {
                        if (!m_wordList[j].Text.StartsWith(charValue))
                        {
                            start = j;
                            break;
                        }
                    }
                }
            }
        }

        public string GetRandomWord(bool scrambled)
        {
            if (m_wordList.Count == 0)
            {
                return "";
            }

            Random random = new Random();

            // get the word we think we want to use
            string randomWord = "";
            while (randomWord == "")
            {
                int index = random.Next(0, m_wordList.Count);
                if (!m_wordList[index].Used)
                {
                    randomWord = m_wordList[index].Text;
                    if (TrackRepeats)
                    {
                        m_wordList[index].Used = true;
                    }
                }
            }

            if (scrambled)
            {
                randomWord = Scramble(randomWord);
            }
            return randomWord;
        }

        /// <summary>
        /// Counts the number of words that have been used
        /// </summary>
        private int CountUsedWords()
        {
            int used = 0;
            if (TrackRepeats)
            {
                for (int i = 0; i < m_wordList.Count; i++)
                {
                    if (m_wordList[i].Used)
                    {
                        used++;
                    }
                }
            }
            return used;
        }


        /// <summary>
        /// Scrambles the specified word by selectig a random letter from the 
        /// original word, and building a new "word" from those characters.
        /// </summary>
        public string Scramble(string oldWord)
        {
            CurrentWord = oldWord;
            Random random = new Random();
            string originalWord = oldWord;
            string newWord;
            do
            {
                newWord = "";
                while (originalWord.Length > 0)
                {
                    int index = random.Next(0, originalWord.Length);
                    newWord += originalWord[index];
                    originalWord = originalWord.Remove(index, 1);
                }
            } while (newWord == oldWord);
            return newWord;
        }

        /// <summary>
        /// Calculates the number of points that a word scores according to Scrabble 
        /// letter values.
        /// </summary>
        public int CalculateWordPoints(string scoreWord)
        {
            int points = 0;
            int count = scoreWord.Length;
            for (int i = 0; i < count; i++)
            {
                points += m_wordPoints[Convert.ToInt16(scoreWord[0]) - 97];
            }
            return points;
        }
        public int CalculateWordPoints(int index) => CalculateWordPoints(m_wordList[index].Text);

        public void ClearPossibleWords() => m_wordList.Clear();

        public void AddPossibleWord(string word) => m_wordList.Add(new WordItem(word));

        /// <summary>
        /// Finds the word that the user typed.
        /// </summary>
        public int FindWord(string wordToFind)
        {
            int index = -1;
            for (int i = 0; i < m_wordList.Count; i++)
            {
                if (m_wordList[i].Text == wordToFind.ToLower())
                {
                    if (!m_wordList[i].Used)
                    {
                        index = i;
                    }
                }
            }
            return index;

        }

        /// <summary>
        /// Determines if the word has already been used
        /// </summary>
        /// <returns>The index of the word, or -1 if it hasn't been used</returns>
        public bool IsUsed(int index) => m_wordList[index].Used;

        public bool IsUsed(string word)
        {
            int index = FindWord(word);
            if (index >= 0)
            {
                return IsUsed(index);
            }
            // if we couldn't find the word, we assume it's used
            return true;
        }

        public void MarkWordAsUsed(int index) => m_wordList[index].Used = true;

        public void MarkWordAsUsed(string word)
        {
            int index = FindWord(word);
            if (index >= 0)
            {
                MarkWordAsUsed(index);
            }
        }

        public bool IsPossibleWord(string baseWord, string compareWord)
        {
            bool found = true;
            while (found && compareWord.Length > 0)
            {
                char currChar = compareWord[0];
                compareWord = compareWord.Remove(0, 1);
                int index = baseWord.IndexOf(currChar);
                if (index >= 0)
                {
                    baseWord = baseWord.Remove(index, 1);
                }
                else
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        public List<WordItem> FindPossibleWords(string thisWord)
        {
            List<WordItem> foundList = new List<WordItem>();
            for (int i = 0; i < m_wordList.Count; i++)
            {
                WordItem item = m_wordList[i];
                string compareWord = item.Text;
                if (IsPossibleWord(thisWord, compareWord))
                {
                    foundList.Add(new WordItem(compareWord));
                }
            }
            return foundList;
        }

        public void AddPossibleWords(List<WordItem> foundList) => m_wordList.AddRange(foundList);

        public WordItem GetWord(int index)
        {
            WordItem item = null;
            if (index >= 0 && index < m_wordList.Count)
            {
                item = m_wordList[index];
            }
            return item;
        }
        public WordItem GetWord(string word)
        {
            WordItem item = null;
            for (int i = 0; i < m_wordList.Count; i++)
            {
                item = m_wordList[i];
                if (item.Text == word)
                {
                    break;
                }
                else
                {
                    item = null;
                }
            }
            return item;
        }

        public void Clear() => m_wordList.Clear();
    }

    public class Dictionary
    {
        private readonly List<WordGroup> m_wordGroups = new List<WordGroup>();
        /// <summary>
        /// Gets the maximum number of word groups (based on letter count)
        /// </summary>
        public int MaxGroups { get; set; } = 0;
        private string m_currentWord = "";

        /// <summary>
        /// Gets the word count for the entire dictionary.
        /// </summary>
        public int WordCount
        {
            get
            {
                int count = 0;
                for (int i = 3; i <= MaxGroups; i++)
                {
                    count += m_wordGroups[i].Count;
                }
                return count;
            }
        }
        public int PossibleWordCount { get => m_wordGroups[0].Count; }

        public string CurrentWord { get => m_currentWord; }

        public Dictionary(int maxGroups)
        {
            MaxGroups = maxGroups;
            for (int i = 0; i <= maxGroups; i++)
            {
                m_wordGroups.Add(new WordGroup(i));
            }
        }

        /// <summary>
        /// Gets the word group object that contains words that are "letterCount" letters 
        /// long
        /// </summary>
        public WordGroup GetWordGroup(int letterCount)
        {
            WordGroup group = null;
            if (letterCount >= 0 && letterCount <= MaxGroups)
            {
                group = m_wordGroups[letterCount];
            }
            return group;
        }

        /// <summary>
        /// Finds all possible words for the specified base word.
        /// </summary>
        public int FindPossibleWords(string baseWord)
        {
            m_wordGroups[0].Clear();
            for (int i = 3; i <= baseWord.Length; i++)
            {
                List<WordItem> wordList = m_wordGroups[i].FindPossibleWords(baseWord);
                m_wordGroups[0].AddPossibleWords(wordList);
            }
            return m_wordGroups[0].Count;
        }

        /// <summary>
        /// Gets a randomly selected word from the specified word group.
        /// </summary>
        public string GetRandomWord(int letterCount, bool scramble)
        {
            string scrambledWord = m_wordGroups[letterCount].GetRandomWord(scramble);
            m_currentWord = m_wordGroups[letterCount].CurrentWord;
            return scrambledWord;
        }

        public int FindWord(string word) => m_wordGroups[0].FindWord(word);

        public bool IsDuplicateWord(string word) => m_wordGroups[0].IsUsed(word);

        public bool IsDuplicateWord(int index) => m_wordGroups[0].IsUsed(index);

        public void MarkWordAsUsed(int index) => m_wordGroups[0].MarkWordAsUsed(index);

        public void MarkWordAsUsed(string word) => m_wordGroups[0].MarkWordAsUsed(word);

        public int WordPoints(int index) => m_wordGroups[0].CalculateWordPoints(index);

        public int WordPoints(string word) => m_wordGroups[0].CalculateWordPoints(word);

        public WordItem GetPossibleWordItem(string word) => m_wordGroups[0].GetWord(word);
    }
}
