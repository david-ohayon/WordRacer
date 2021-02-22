
namespace WordRacer
{
    partial class GameStart
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
            this.instructions = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(173)))));
            this.instructions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.instructions.Location = new System.Drawing.Point(0, 56);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(794, 393);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Instructions";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.credits.Dock = System.Windows.Forms.DockStyle.Top;
            this.credits.Location = new System.Drawing.Point(0, 0);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(794, 57);
            this.credits.TabIndex = 1;
            this.credits.Text = "credits";
            this.credits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(676, 368);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 70);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "OK";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(12, 367);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(112, 70);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "NO";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 449);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.instructions);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 520);
            this.Name = "GameStart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
    }
}