using System.Windows.Forms;

namespace SpeakingClock.Classes
{
    internal class GenericFunctions
    {
        internal static void CloseForm(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure to close the speaking clock app?", "Are you?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
