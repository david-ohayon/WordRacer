namespace WordRacer
{
    partial class Configure
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioTimerNone = new System.Windows.Forms.RadioButton();
            this.textboxSecondsPerLetter = new System.Windows.Forms.TextBox();
            this.textboxTimerStatic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioTimerBoth = new System.Windows.Forms.RadioButton();
            this.radioTimerPerLetter = new System.Windows.Forms.RadioButton();
            this.radioTimerStatic = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textboxLetterPool = new System.Windows.Forms.TextBox();
            this.radioLetterPoolStatic = new System.Windows.Forms.RadioButton();
            this.radioLetterPoolRandom = new System.Windows.Forms.RadioButton();
            this.checkboxAllowRepeats = new System.Windows.Forms.CheckBox();
            this.checkboxPlaySounds = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(106, 681);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 44);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(270, 681);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 44);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioTimerNone);
            this.groupBox4.Controls.Add(this.textboxSecondsPerLetter);
            this.groupBox4.Controls.Add(this.textboxTimerStatic);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.radioTimerBoth);
            this.groupBox4.Controls.Add(this.radioTimerPerLetter);
            this.groupBox4.Controls.Add(this.radioTimerStatic);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(14, 151);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.Size = new System.Drawing.Size(502, 300);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Timing";
            // 
            // radioTimerNone
            // 
            this.radioTimerNone.AutoSize = true;
            this.radioTimerNone.Location = new System.Drawing.Point(42, 38);
            this.radioTimerNone.Margin = new System.Windows.Forms.Padding(6);
            this.radioTimerNone.Name = "radioTimerNone";
            this.radioTimerNone.Size = new System.Drawing.Size(123, 29);
            this.radioTimerNone.TabIndex = 7;
            this.radioTimerNone.TabStop = true;
            this.radioTimerNone.Text = "No timer";
            this.radioTimerNone.UseVisualStyleBackColor = true;
            this.radioTimerNone.CheckedChanged += new System.EventHandler(this.radioTimerNone_CheckedChanged);
            // 
            // textboxSecondsPerLetter
            // 
            this.textboxSecondsPerLetter.Location = new System.Drawing.Point(390, 246);
            this.textboxSecondsPerLetter.Margin = new System.Windows.Forms.Padding(6);
            this.textboxSecondsPerLetter.MaxLength = 2;
            this.textboxSecondsPerLetter.Name = "textboxSecondsPerLetter";
            this.textboxSecondsPerLetter.Size = new System.Drawing.Size(60, 31);
            this.textboxSecondsPerLetter.TabIndex = 6;
            // 
            // textboxTimerStatic
            // 
            this.textboxTimerStatic.Location = new System.Drawing.Point(390, 202);
            this.textboxTimerStatic.Margin = new System.Windows.Forms.Padding(6);
            this.textboxTimerStatic.MaxLength = 2;
            this.textboxTimerStatic.Name = "textboxTimerStatic";
            this.textboxTimerStatic.Size = new System.Drawing.Size(60, 31);
            this.textboxTimerStatic.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Static time value (10-60 seconds)";
            // 
            // radioTimerBoth
            // 
            this.radioTimerBoth.AutoSize = true;
            this.radioTimerBoth.Location = new System.Drawing.Point(42, 165);
            this.radioTimerBoth.Margin = new System.Windows.Forms.Padding(6);
            this.radioTimerBoth.Name = "radioTimerBoth";
            this.radioTimerBoth.Size = new System.Drawing.Size(351, 29);
            this.radioTimerBoth.TabIndex = 2;
            this.radioTimerBoth.TabStop = true;
            this.radioTimerBoth.Text = "Static value + seconds per letter";
            this.radioTimerBoth.UseVisualStyleBackColor = true;
            this.radioTimerBoth.CheckedChanged += new System.EventHandler(this.radioTimerBoth_CheckedChanged);
            // 
            // radioTimerPerLetter
            // 
            this.radioTimerPerLetter.AutoSize = true;
            this.radioTimerPerLetter.Location = new System.Drawing.Point(42, 121);
            this.radioTimerPerLetter.Margin = new System.Windows.Forms.Padding(6);
            this.radioTimerPerLetter.Name = "radioTimerPerLetter";
            this.radioTimerPerLetter.Size = new System.Drawing.Size(218, 29);
            this.radioTimerPerLetter.TabIndex = 1;
            this.radioTimerPerLetter.TabStop = true;
            this.radioTimerPerLetter.Text = "Seconds per letter";
            this.radioTimerPerLetter.UseVisualStyleBackColor = true;
            this.radioTimerPerLetter.CheckedChanged += new System.EventHandler(this.radioTimerPerLetter_CheckedChanged);
            // 
            // radioTimerStatic
            // 
            this.radioTimerStatic.AutoSize = true;
            this.radioTimerStatic.Location = new System.Drawing.Point(42, 77);
            this.radioTimerStatic.Margin = new System.Windows.Forms.Padding(6);
            this.radioTimerStatic.Name = "radioTimerStatic";
            this.radioTimerStatic.Size = new System.Drawing.Size(201, 29);
            this.radioTimerStatic.TabIndex = 0;
            this.radioTimerStatic.TabStop = true;
            this.radioTimerStatic.Text = "Static time value";
            this.radioTimerStatic.UseVisualStyleBackColor = true;
            this.radioTimerStatic.CheckedChanged += new System.EventHandler(this.radioTimerStatic_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 252);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Seconds per letter (3-10)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textboxLetterPool);
            this.groupBox2.Controls.Add(this.radioLetterPoolStatic);
            this.groupBox2.Controls.Add(this.radioLetterPoolRandom);
            this.groupBox2.Location = new System.Drawing.Point(14, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(502, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Letter Pool";
            // 
            // textboxLetterPool
            // 
            this.textboxLetterPool.Location = new System.Drawing.Point(212, 77);
            this.textboxLetterPool.Margin = new System.Windows.Forms.Padding(6);
            this.textboxLetterPool.MaxLength = 2;
            this.textboxLetterPool.Name = "textboxLetterPool";
            this.textboxLetterPool.Size = new System.Drawing.Size(60, 31);
            this.textboxLetterPool.TabIndex = 2;
            // 
            // radioLetterPoolStatic
            // 
            this.radioLetterPoolStatic.AutoSize = true;
            this.radioLetterPoolStatic.Location = new System.Drawing.Point(42, 79);
            this.radioLetterPoolStatic.Margin = new System.Windows.Forms.Padding(6);
            this.radioLetterPoolStatic.Name = "radioLetterPoolStatic";
            this.radioLetterPoolStatic.Size = new System.Drawing.Size(160, 29);
            this.radioLetterPoolStatic.TabIndex = 1;
            this.radioLetterPoolStatic.TabStop = true;
            this.radioLetterPoolStatic.Text = "Static (6-10)";
            this.radioLetterPoolStatic.UseVisualStyleBackColor = true;
            this.radioLetterPoolStatic.CheckedChanged += new System.EventHandler(this.radioLetterPoolStatic_CheckedChanged);
            // 
            // radioLetterPoolRandom
            // 
            this.radioLetterPoolRandom.AutoSize = true;
            this.radioLetterPoolRandom.Location = new System.Drawing.Point(42, 37);
            this.radioLetterPoolRandom.Margin = new System.Windows.Forms.Padding(6);
            this.radioLetterPoolRandom.Name = "radioLetterPoolRandom";
            this.radioLetterPoolRandom.Size = new System.Drawing.Size(123, 29);
            this.radioLetterPoolRandom.TabIndex = 0;
            this.radioLetterPoolRandom.TabStop = true;
            this.radioLetterPoolRandom.Text = "Random";
            this.radioLetterPoolRandom.UseVisualStyleBackColor = true;
            this.radioLetterPoolRandom.CheckedChanged += new System.EventHandler(this.radioLetterPoolRandom_CheckedChanged);
            // 
            // checkboxAllowRepeats
            // 
            this.checkboxAllowRepeats.AutoSize = true;
            this.checkboxAllowRepeats.Location = new System.Drawing.Point(54, 546);
            this.checkboxAllowRepeats.Margin = new System.Windows.Forms.Padding(6);
            this.checkboxAllowRepeats.Name = "checkboxAllowRepeats";
            this.checkboxAllowRepeats.Size = new System.Drawing.Size(249, 29);
            this.checkboxAllowRepeats.TabIndex = 4;
            this.checkboxAllowRepeats.Text = "Allow words to repeat";
            this.checkboxAllowRepeats.UseVisualStyleBackColor = true;
            // 
            // checkboxPlaySounds
            // 
            this.checkboxPlaySounds.AutoSize = true;
            this.checkboxPlaySounds.Location = new System.Drawing.Point(54, 508);
            this.checkboxPlaySounds.Margin = new System.Windows.Forms.Padding(6);
            this.checkboxPlaySounds.Name = "checkboxPlaySounds";
            this.checkboxPlaySounds.Size = new System.Drawing.Size(221, 29);
            this.checkboxPlaySounds.TabIndex = 3;
            this.checkboxPlaySounds.Text = "Play sound effects";
            this.checkboxPlaySounds.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(14, 463);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(502, 135);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Other Settings";
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.Location = new System.Drawing.Point(148, 613);
            this.buttonDefaultSettings.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(230, 44);
            this.buttonDefaultSettings.TabIndex = 6;
            this.buttonDefaultSettings.Text = "Default Settings";
            this.buttonDefaultSettings.UseVisualStyleBackColor = true;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonDefaultSettings_Click);
            // 
            // Configure
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(532, 739);
            this.Controls.Add(this.buttonDefaultSettings);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkboxAllowRepeats);
            this.Controls.Add(this.checkboxPlaySounds);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Configure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textboxSecondsPerLetter;
        private System.Windows.Forms.TextBox textboxTimerStatic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioTimerBoth;
        private System.Windows.Forms.RadioButton radioTimerPerLetter;
        private System.Windows.Forms.RadioButton radioTimerStatic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxLetterPool;
        private System.Windows.Forms.RadioButton radioLetterPoolStatic;
        private System.Windows.Forms.RadioButton radioLetterPoolRandom;
        private System.Windows.Forms.CheckBox checkboxAllowRepeats;
        private System.Windows.Forms.CheckBox checkboxPlaySounds;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.RadioButton radioTimerNone;
    }
}