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
            this.timingGroupBox = new System.Windows.Forms.GroupBox();
            this.radioTimerNone = new System.Windows.Forms.RadioButton();
            this.textboxTimerStatic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioTimerStatic = new System.Windows.Forms.RadioButton();
            this.letterPoolGroupBox = new System.Windows.Forms.GroupBox();
            this.textboxLetterPool = new System.Windows.Forms.TextBox();
            this.radioLetterPoolStatic = new System.Windows.Forms.RadioButton();
            this.radioLetterPoolRandom = new System.Windows.Forms.RadioButton();
            this.checkboxAllowRepeats = new System.Windows.Forms.CheckBox();
            this.checkboxPlaySounds = new System.Windows.Forms.CheckBox();
            this.otherGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonDefaultSettings = new System.Windows.Forms.Button();
            this.timingGroupBox.SuspendLayout();
            this.letterPoolGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(111, 565);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(149, 44);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(275, 565);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(149, 44);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timingGroupBox
            // 
            this.timingGroupBox.Controls.Add(this.radioTimerNone);
            this.timingGroupBox.Controls.Add(this.textboxTimerStatic);
            this.timingGroupBox.Controls.Add(this.label7);
            this.timingGroupBox.Controls.Add(this.radioTimerStatic);
            this.timingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timingGroupBox.Location = new System.Drawing.Point(13, 151);
            this.timingGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.timingGroupBox.Name = "timingGroupBox";
            this.timingGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.timingGroupBox.Size = new System.Drawing.Size(501, 178);
            this.timingGroupBox.TabIndex = 2;
            this.timingGroupBox.TabStop = false;
            this.timingGroupBox.Text = "Timing";
            // 
            // radioTimerNone
            // 
            this.radioTimerNone.AutoSize = true;
            this.radioTimerNone.Location = new System.Drawing.Point(43, 38);
            this.radioTimerNone.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioTimerNone.Name = "radioTimerNone";
            this.radioTimerNone.Size = new System.Drawing.Size(123, 29);
            this.radioTimerNone.TabIndex = 7;
            this.radioTimerNone.TabStop = true;
            this.radioTimerNone.Text = "No timer";
            this.radioTimerNone.UseVisualStyleBackColor = true;
            this.radioTimerNone.CheckedChanged += new System.EventHandler(this.radioTimerNone_CheckedChanged);
            // 
            // textboxTimerStatic
            // 
            this.textboxTimerStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.textboxTimerStatic.Location = new System.Drawing.Point(329, 135);
            this.textboxTimerStatic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textboxTimerStatic.MaxLength = 3;
            this.textboxTimerStatic.Name = "textboxTimerStatic";
            this.textboxTimerStatic.Size = new System.Drawing.Size(67, 31);
            this.textboxTimerStatic.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 50);
            this.label7.TabIndex = 3;
            this.label7.Text = "Static time value\r\n(10-100 seconds)";
            // 
            // radioTimerStatic
            // 
            this.radioTimerStatic.AutoSize = true;
            this.radioTimerStatic.Location = new System.Drawing.Point(43, 78);
            this.radioTimerStatic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.radioTimerStatic.Name = "radioTimerStatic";
            this.radioTimerStatic.Size = new System.Drawing.Size(201, 29);
            this.radioTimerStatic.TabIndex = 0;
            this.radioTimerStatic.TabStop = true;
            this.radioTimerStatic.Text = "Static time value";
            this.radioTimerStatic.UseVisualStyleBackColor = true;
            this.radioTimerStatic.CheckedChanged += new System.EventHandler(this.radioTimerStatic_CheckedChanged);
            // 
            // letterPoolGroupBox
            // 
            this.letterPoolGroupBox.Controls.Add(this.textboxLetterPool);
            this.letterPoolGroupBox.Controls.Add(this.radioLetterPoolStatic);
            this.letterPoolGroupBox.Controls.Add(this.radioLetterPoolRandom);
            this.letterPoolGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterPoolGroupBox.Location = new System.Drawing.Point(13, 10);
            this.letterPoolGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.letterPoolGroupBox.Name = "letterPoolGroupBox";
            this.letterPoolGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.letterPoolGroupBox.Size = new System.Drawing.Size(501, 129);
            this.letterPoolGroupBox.TabIndex = 0;
            this.letterPoolGroupBox.TabStop = false;
            this.letterPoolGroupBox.Text = "Letter Pool";
            // 
            // textboxLetterPool
            // 
            this.textboxLetterPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(221)))), ((int)(((byte)(203)))));
            this.textboxLetterPool.Location = new System.Drawing.Point(329, 79);
            this.textboxLetterPool.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textboxLetterPool.MaxLength = 2;
            this.textboxLetterPool.Name = "textboxLetterPool";
            this.textboxLetterPool.Size = new System.Drawing.Size(60, 31);
            this.textboxLetterPool.TabIndex = 2;
            // 
            // radioLetterPoolStatic
            // 
            this.radioLetterPoolStatic.AutoSize = true;
            this.radioLetterPoolStatic.Location = new System.Drawing.Point(43, 79);
            this.radioLetterPoolStatic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.radioLetterPoolRandom.Location = new System.Drawing.Point(43, 38);
            this.radioLetterPoolRandom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.checkboxAllowRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAllowRepeats.Location = new System.Drawing.Point(55, 432);
            this.checkboxAllowRepeats.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkboxAllowRepeats.Name = "checkboxAllowRepeats";
            this.checkboxAllowRepeats.Size = new System.Drawing.Size(249, 29);
            this.checkboxAllowRepeats.TabIndex = 4;
            this.checkboxAllowRepeats.Text = "Allow words to repeat";
            this.checkboxAllowRepeats.UseVisualStyleBackColor = true;
            // 
            // checkboxPlaySounds
            // 
            this.checkboxPlaySounds.AutoSize = true;
            this.checkboxPlaySounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxPlaySounds.Location = new System.Drawing.Point(55, 395);
            this.checkboxPlaySounds.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkboxPlaySounds.Name = "checkboxPlaySounds";
            this.checkboxPlaySounds.Size = new System.Drawing.Size(221, 29);
            this.checkboxPlaySounds.TabIndex = 3;
            this.checkboxPlaySounds.Text = "Play sound effects";
            this.checkboxPlaySounds.UseVisualStyleBackColor = true;
            // 
            // otherGroupBox
            // 
            this.otherGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherGroupBox.Location = new System.Drawing.Point(15, 350);
            this.otherGroupBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.otherGroupBox.Name = "otherGroupBox";
            this.otherGroupBox.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.otherGroupBox.Size = new System.Drawing.Size(501, 135);
            this.otherGroupBox.TabIndex = 5;
            this.otherGroupBox.TabStop = false;
            this.otherGroupBox.Text = "Other Settings";
            // 
            // buttonDefaultSettings
            // 
            this.buttonDefaultSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(220)))));
            this.buttonDefaultSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefaultSettings.Location = new System.Drawing.Point(153, 498);
            this.buttonDefaultSettings.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDefaultSettings.Name = "buttonDefaultSettings";
            this.buttonDefaultSettings.Size = new System.Drawing.Size(229, 44);
            this.buttonDefaultSettings.TabIndex = 6;
            this.buttonDefaultSettings.Text = "Default Settings";
            this.buttonDefaultSettings.UseVisualStyleBackColor = false;
            this.buttonDefaultSettings.Click += new System.EventHandler(this.buttonDefaultSettings_Click);
            // 
            // Configure
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(173)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(529, 629);
            this.Controls.Add(this.buttonDefaultSettings);
            this.Controls.Add(this.timingGroupBox);
            this.Controls.Add(this.letterPoolGroupBox);
            this.Controls.Add(this.checkboxAllowRepeats);
            this.Controls.Add(this.checkboxPlaySounds);
            this.Controls.Add(this.otherGroupBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 700);
            this.MinimumSize = new System.Drawing.Size(555, 700);
            this.Name = "Configure";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure";
            this.Load += new System.EventHandler(this.Configure_Load);
            this.timingGroupBox.ResumeLayout(false);
            this.timingGroupBox.PerformLayout();
            this.letterPoolGroupBox.ResumeLayout(false);
            this.letterPoolGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox timingGroupBox;
        private System.Windows.Forms.TextBox textboxTimerStatic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioTimerStatic;
        private System.Windows.Forms.GroupBox letterPoolGroupBox;
        private System.Windows.Forms.TextBox textboxLetterPool;
        private System.Windows.Forms.RadioButton radioLetterPoolStatic;
        private System.Windows.Forms.RadioButton radioLetterPoolRandom;
        private System.Windows.Forms.CheckBox checkboxAllowRepeats;
        private System.Windows.Forms.CheckBox checkboxPlaySounds;
        private System.Windows.Forms.GroupBox otherGroupBox;
        private System.Windows.Forms.Button buttonDefaultSettings;
        private System.Windows.Forms.RadioButton radioTimerNone;
    }
}