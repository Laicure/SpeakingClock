using System;
using System.Windows.Forms;
using SpeakingClock.Classes;

namespace SpeakingClock.Forms
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Tim_Main.Enabled = true;
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GenericFunctions.CloseForm(e);
        }

        private void Tim_Main_Tick(object sender, EventArgs e)
        {

        }
    }
}
