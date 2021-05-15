using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextTOSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Speakbutton_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Rate = SpeedtrackBar.Value;
            synth.Volume = SoundtrackBar.Value;
            if(selectcomboBox.Text == "Male"){
                synth.SelectVoiceByHints(VoiceGender.Male);
            }
            if (selectcomboBox.Text == "Female")
            {
                synth.SelectVoiceByHints(VoiceGender.Female);
            }

            synth.Speak(textBox1.Text);
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
