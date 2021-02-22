using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordRacer
{
    public partial class GameStart : Form
    {
        private readonly Dictionary m_dictionary = new Dictionary(10);
        public GameStart()
        {
            InitializeComponent();

            Start();
        }

        public void Start()
        {
            Program.AddFont("PixelEmulatorfont", credits, instructions, buttonStart, buttonQuit);
            credits.Text = "This game has been made by David && Ilay";
            instructions.Text = $"The game is basically a scrabble\n" +
                "You have a set of letters and the game is to make valid english 3-10 letters words\n" +
                $"{m_dictionary.WordCount} words were found. Prepare yourself";
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hide();
            new Game().Show();
        }
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
