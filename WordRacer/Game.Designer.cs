namespace WordRacer
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textboxScrambled = new System.Windows.Forms.TextBox();
            this.labelLetters = new System.Windows.Forms.Label();
            this.labelWord = new System.Windows.Forms.Label();
            this.textboxWord = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.listboxWords = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelWordFound = new System.Windows.Forms.Label();
            this.lblWordsFound = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelPossibleWord = new System.Windows.Forms.Label();
            this.lblPossibleWords = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.buttonConfigure = new System.Windows.Forms.Button();
            this.groupboxStats = new System.Windows.Forms.GroupBox();
            this.labelGameStats = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupboxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxScrambled
            // 
            this.textboxScrambled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.textboxScrambled.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxScrambled.Location = new System.Drawing.Point(187, 10);
            this.textboxScrambled.Margin = new System.Windows.Forms.Padding(4);
            this.textboxScrambled.Name = "textboxScrambled";
            this.textboxScrambled.ReadOnly = true;
            this.textboxScrambled.Size = new System.Drawing.Size(434, 44);
            this.textboxScrambled.TabIndex = 10;
            // 
            // labelLetters
            // 
            this.labelLetters.AutoSize = true;
            this.labelLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetters.Location = new System.Drawing.Point(6, 20);
            this.labelLetters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLetters.Name = "labelLetters";
            this.labelLetters.Size = new System.Drawing.Size(78, 25);
            this.labelLetters.TabIndex = 9;
            this.labelLetters.Text = "Letters";
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWord.Location = new System.Drawing.Point(13, 100);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(63, 25);
            this.labelWord.TabIndex = 11;
            this.labelWord.Text = "Word";
            // 
            // textboxWord
            // 
            this.textboxWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.textboxWord.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxWord.Location = new System.Drawing.Point(119, 83);
            this.textboxWord.Margin = new System.Windows.Forms.Padding(4);
            this.textboxWord.Name = "textboxWord";
            this.textboxWord.Size = new System.Drawing.Size(387, 44);
            this.textboxWord.TabIndex = 12;
            this.textboxWord.TextChanged += new System.EventHandler(this.textboxWord_TextChanged);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(663, 116);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(85, 31);
            this.labelScore.TabIndex = 19;
            this.labelScore.Text = "Score";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(986, 110);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(112, 37);
            this.lblPoints.TabIndex = 20;
            this.lblPoints.Text = "99999";
            // 
            // listboxWords
            // 
            this.listboxWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.listboxWords.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listboxWords.Font = new System.Drawing.Font("Courier New", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxWords.FormattingEnabled = true;
            this.listboxWords.ItemHeight = 42;
            this.listboxWords.Location = new System.Drawing.Point(13, 259);
            this.listboxWords.Margin = new System.Windows.Forms.Padding(4);
            this.listboxWords.MultiColumn = true;
            this.listboxWords.Name = "listboxWords";
            this.listboxWords.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listboxWords.Size = new System.Drawing.Size(608, 802);
            this.listboxWords.Sorted = true;
            this.listboxWords.TabIndex = 15;
            this.listboxWords.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listboxWords_DrawItem);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonStart.FlatAppearance.BorderSize = 2;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(881, 298);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(260, 110);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "New Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonDone.FlatAppearance.BorderSize = 2;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.Location = new System.Drawing.Point(941, 939);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(200, 120);
            this.buttonDone.TabIndex = 23;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmit.FlatAppearance.BorderSize = 2;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(514, 83);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(107, 44);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // labelWordFound
            // 
            this.labelWordFound.AutoSize = true;
            this.labelWordFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordFound.Location = new System.Drawing.Point(663, 190);
            this.labelWordFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWordFound.Name = "labelWordFound";
            this.labelWordFound.Size = new System.Drawing.Size(92, 62);
            this.labelWordFound.TabIndex = 21;
            this.labelWordFound.Text = "Words\r\nFound";
            // 
            // lblWordsFound
            // 
            this.lblWordsFound.AutoSize = true;
            this.lblWordsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsFound.Location = new System.Drawing.Point(986, 203);
            this.lblWordsFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordsFound.Name = "lblWordsFound";
            this.lblWordsFound.Size = new System.Drawing.Size(74, 37);
            this.lblWordsFound.TabIndex = 22;
            this.lblWordsFound.Text = "999";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemaining.Location = new System.Drawing.Point(13, 215);
            this.labelRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(114, 25);
            this.labelRemaining.TabIndex = 13;
            this.labelRemaining.Text = "Remaining";
            // 
            // labelPossibleWord
            // 
            this.labelPossibleWord.AutoSize = true;
            this.labelPossibleWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPossibleWord.Location = new System.Drawing.Point(663, 14);
            this.labelPossibleWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPossibleWord.Name = "labelPossibleWord";
            this.labelPossibleWord.Size = new System.Drawing.Size(117, 62);
            this.labelPossibleWord.TabIndex = 17;
            this.labelPossibleWord.Text = "Possible\r\nWords";
            // 
            // lblPossibleWords
            // 
            this.lblPossibleWords.AutoSize = true;
            this.lblPossibleWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleWords.Location = new System.Drawing.Point(986, 20);
            this.lblPossibleWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPossibleWords.Name = "lblPossibleWords";
            this.lblPossibleWords.Size = new System.Drawing.Size(141, 37);
            this.lblPossibleWords.TabIndex = 18;
            this.lblPossibleWords.Text = "999,999";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // buttonConfigure
            // 
            this.buttonConfigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonConfigure.FlatAppearance.BorderSize = 2;
            this.buttonConfigure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigure.Location = new System.Drawing.Point(669, 897);
            this.buttonConfigure.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfigure.Name = "buttonConfigure";
            this.buttonConfigure.Size = new System.Drawing.Size(260, 110);
            this.buttonConfigure.TabIndex = 24;
            this.buttonConfigure.Text = "Configure";
            this.buttonConfigure.UseVisualStyleBackColor = false;
            this.buttonConfigure.Click += new System.EventHandler(this.buttonConfigure_Click);
            // 
            // groupboxStats
            // 
            this.groupboxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(112)))), ((int)(((byte)(126)))));
            this.groupboxStats.Controls.Add(this.labelGameStats);
            this.groupboxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxStats.Location = new System.Drawing.Point(660, 469);
            this.groupboxStats.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxStats.Name = "groupboxStats";
            this.groupboxStats.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxStats.Size = new System.Drawing.Size(481, 420);
            this.groupboxStats.TabIndex = 25;
            this.groupboxStats.TabStop = false;
            this.groupboxStats.Text = "End-of-Game Statistics";
            this.groupboxStats.Visible = false;
            // 
            // labelGameStats
            // 
            this.labelGameStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGameStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameStats.Location = new System.Drawing.Point(4, 34);
            this.labelGameStats.Name = "labelGameStats";
            this.labelGameStats.Size = new System.Drawing.Size(473, 382);
            this.labelGameStats.TabIndex = 0;
            this.labelGameStats.Visible = false;
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonSolve.FlatAppearance.BorderSize = 2;
            this.buttonSolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolve.Location = new System.Drawing.Point(669, 329);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(200, 120);
            this.buttonSolve.TabIndex = 26;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(268, 198);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(353, 54);
            this.progressBar.TabIndex = 27;
            // 
            // Game
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(1154, 1069);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.groupboxStats);
            this.Controls.Add(this.buttonConfigure);
            this.Controls.Add(this.lblPossibleWords);
            this.Controls.Add(this.labelPossibleWord);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.lblWordsFound);
            this.Controls.Add(this.labelWordFound);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textboxWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.labelLetters);
            this.Controls.Add(this.textboxScrambled);
            this.Controls.Add(this.listboxWords);
            this.Controls.Add(this.buttonSubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 1140);
            this.MinimumSize = new System.Drawing.Size(1180, 1140);
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrabble";
            this.groupboxStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxScrambled;
        private System.Windows.Forms.Label labelLetters;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textboxWord;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.ListBox listboxWords;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelWordFound;
        private System.Windows.Forms.Label lblWordsFound;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelPossibleWord;
        private System.Windows.Forms.Label lblPossibleWords;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Button buttonConfigure;
        private System.Windows.Forms.GroupBox groupboxStats;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelGameStats;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

