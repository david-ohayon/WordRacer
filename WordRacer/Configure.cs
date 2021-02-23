using System;
using System.Media;
using System.Windows.Forms;
using WordRacer.Properties;

namespace WordRacer
{
    /// <summary>
    /// This class implements the configuration dialog.
    /// </summary>
    public partial class Configure : Form
    {
        // the settings object
        private readonly GameConfig m_config = new GameConfig();
        // integer value representing the current radio button selected for the letter pool mode
        private int m_radiogroupLetterPoolMode = -1;
        // integer value representing the current radio button selected for the timer mode
        private int m_radiogroupTimerMode = -1;

        public Configure()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                Program.AddFont("PixelEmulatorfont", control);
        }

        /// <summary>
        /// Loads the configuration data
        /// </summary>
        private void Configure_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Reload()
        {
            //load data from user.config
            m_config.Reload();

            // letter pool
            switch (m_config.LetterPoolMode)
            {
                case 0:
                    radioLetterPoolRandom.Checked = true;
                    radioLetterPoolStatic.Checked = false;
                    break;
                case 1:
                    radioLetterPoolRandom.Checked = false;
                    radioLetterPoolStatic.Checked = true;
                    break;
            }
            m_radiogroupLetterPoolMode = m_config.LetterPoolMode;

            int letterCount = m_config.LetterCount;
            textboxLetterPool.Text = Convert.ToString(letterCount);

            // Timing
            switch (m_config.TimerMode)
            {
                case 0:
                    radioTimerNone.Checked = true;
                    radioTimerStatic.Checked = false;
                    break;
                case 1:
                    radioTimerNone.Checked = false;
                    radioTimerStatic.Checked = true;
                    break;
                case 2:
                    radioTimerNone.Checked = false;
                    radioTimerStatic.Checked = false;
                    break;
                case 3:
                    radioTimerNone.Checked = false;
                    radioTimerStatic.Checked = false;
                    break;
            }
            m_radiogroupTimerMode = m_config.TimerMode;
            int secondsStatic = m_config.StaticSeconds;
            textboxTimerStatic.Text = Convert.ToString(secondsStatic);

            // other settings
            checkboxPlaySounds.Checked = m_config.PlaySounds;
            checkboxAllowRepeats.Checked = m_config.AllowRepeatedWords;

            // update the enabled/disabled status of the controls
            UpdateControls();
        }

        /// <summary>
        /// Deterines if the OK button can be clicked. If certain radio buttons 
        /// are checked, there must be data in the appropriate text controls.
        /// </summary>
        /// <returns>True if the OK button can be clicked</returns>
        private bool CanClickOK()
        {
            bool canClick = radioLetterPoolRandom.Checked || (radioLetterPoolStatic.Checked && textboxLetterPool.Text != "");
            canClick &= radioTimerNone.Checked || (radioTimerStatic.Checked && (textboxTimerStatic.Text != ""));
            return canClick;
        }

        /// <summary>
        /// Updates the enabled/disabled status of each control
        /// </summary>
        private void UpdateControls()
        {
            textboxLetterPool.Enabled = radioLetterPoolStatic.Checked;
            textboxTimerStatic.Enabled = radioTimerStatic.Checked;

            buttonOK.Enabled = CanClickOK();
        }

        /// <summary>
        /// Validates the text box values
        /// </summary>
        /// <returns>True is all values are valid</returns>
        private bool ValidData()
        {
            bool valid = true;
            int value;
            if (radioLetterPoolStatic.Checked)
            {
                value = Convert.ToInt32(textboxLetterPool.Text);
                valid = value >= Settings.Default.MinLetterPool &&
                         value <= Settings.Default.MaxLetterPool;
            }
            if (!valid)
            {
                MessageBox.Show("The letter pool value must be from 6-10.", "Data Error");
                textboxLetterPool.Focus();
                return valid;
            }
            if (radioTimerStatic.Checked)
            {
                value = Convert.ToInt32(textboxTimerStatic.Text);
                valid = value >= Settings.Default.MinStaticSeconds &&
                          value <= Settings.Default.MaxStaticSeconds;
            }
            if (!valid)
            {
                MessageBox.Show("The static time value must be from 10-100.", "Data Error");
                textboxTimerStatic.Focus();
                return valid;
            }
            return valid;
        }

        /// <summary>
        /// Updates the user.config file with the new settings
        /// </summary>
        private void UpdateConfig()
        {
            m_config.LetterPoolMode = m_radiogroupLetterPoolMode;
            m_config.LetterCount = Convert.ToInt32(textboxLetterPool.Text);
            m_config.TimerMode = m_radiogroupTimerMode;
            m_config.StaticSeconds = Convert.ToInt32(textboxTimerStatic.Text);
            m_config.PlaySounds = checkboxPlaySounds.Checked;
            m_config.AllowRepeatedWords = checkboxAllowRepeats.Checked;
            m_config.Write();
        }

        // resets all config items to their default values, and reloads the config
        private void buttonDefaultSettings_Click(object sender, EventArgs e)
        {
            m_config.SetToDefault();
            Reload();
        }

        /// <summary>
        /// Fired when the user clicks the OK button
        /// </summary>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidData())
            {
                UpdateConfig();
                Close();
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Fired when the user clicks the Cancel button
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //the following functon update their respective indicators and then update the controls
        private void radioLetterPoolRandom_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupLetterPoolMode = 0;
            UpdateControls();
        }
        private void radioLetterPoolStatic_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupLetterPoolMode = 1;
            UpdateControls();
        }
        private void checkboxAwardBonusTime_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
        private void radioTimerNone_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupTimerMode = 0;
            UpdateControls();
        }
        private void radioTimerStatic_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupTimerMode = 1;
            UpdateControls();
        }
        private void radioTimerPerLetter_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupTimerMode = 2;
            UpdateControls();
        }
        private void radioTimerBoth_CheckedChanged(object sender, EventArgs e)
        {
            m_radiogroupTimerMode = 3;
            UpdateControls();
        }
    }
}