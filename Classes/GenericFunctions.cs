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

        internal static void Misc_LoadComboBoxData(ComboBox cmb, string[] cblist)
        {
            {
                cmb.BeginUpdate();
                cmb.Items.Clear();
                cmb.Items.AddRange(cblist);
                cmb.EndUpdate();
                if (cblist.Length > 0) cmb.SelectedIndex = 0;
            }
        }
    }
}
