using System;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
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
            this.Text = "Speaking Clock v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Tim_Main.Enabled = true;
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GenericFunctions.CloseForm(e);
        }

        private void Tim_Main_Tick(object sender, EventArgs e)
        {
            Lb_RealTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ff tt", GlobalVariables.cul_invar);
        }

        private void Ch_AnnounceEvery_CheckedChanged(object sender, EventArgs e)
        {
            Num_AnnounceEvery.Enabled = Ch_AnnounceEvery.Checked;
        }

        private void Lb_Speak_Click(object sender, EventArgs e)
        {
            if (Bg_Speak.IsBusy) return;
            Lb_Speak.Enabled = false;
            Bg_Speak.RunWorkerAsync();
        }

        private void Bg_Speak_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();
                synth.SelectVoice("Microsoft Zira Desktop");
                synth.Speak("It's now " + DateTime.Now.ToString("hh:mm tt", GlobalVariables.cul_invar));
            }
        }

        private void Bg_Speak_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Lb_Speak.Enabled = true;

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Output information about all of the installed voices.
                Console.WriteLine("Installed voices -");
                foreach (InstalledVoice voice in synth.GetInstalledVoices())
                {
                    VoiceInfo info = voice.VoiceInfo;
                    string AudioFormats = "";
                    foreach (SpeechAudioFormatInfo fmt in info.SupportedAudioFormats)
                    {
                        AudioFormats += String.Format("{0}\n",
                        fmt.EncodingFormat.ToString());
                    }

                    Console.WriteLine(" Name:          " + info.Name);
                    Console.WriteLine(" Culture:       " + info.Culture);
                    Console.WriteLine(" Age:           " + info.Age);
                    Console.WriteLine(" Gender:        " + info.Gender);
                    Console.WriteLine(" Description:   " + info.Description);
                    Console.WriteLine(" ID:            " + info.Id);
                    Console.WriteLine(" Enabled:       " + voice.Enabled);
                    if (info.SupportedAudioFormats.Count != 0)
                    {
                        Console.WriteLine(" Audio formats: " + AudioFormats);
                    }
                    else
                    {
                        Console.WriteLine(" No supported audio formats found");
                    }

                    string AdditionalInfo = "";
                    foreach (string key in info.AdditionalInfo.Keys)
                    {
                        AdditionalInfo += String.Format("  {0}: {1}\n", key, info.AdditionalInfo[key]);
                    }

                    Console.WriteLine(" Additional Info - " + AdditionalInfo);
                    Console.WriteLine();
                }
            }
        }
    }
}
