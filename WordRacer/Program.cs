using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WordRacer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GameStart());
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        ///-----------
        ///| helpers |
        ///-----------
        public static void AddFont(string font, params Control[] controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile($@"..\..\Resources\Fonts\{font}.ttf");
            foreach (Control control in controls)
                control.Font = new Font(pfc.Families[0], control.Font.Size);
        }
        // change color of progess bar
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
