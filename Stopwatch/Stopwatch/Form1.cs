using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {
        int TimeSec; 
        int TimeMS ;
        int TimeMin;
        bool isActive = false; //for buttons
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void ResetTimer()
        {
            TimeSec = 0;
            TimeMS = 0;
            TimeMin = 0;
            isActive = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTimer();
            this.progressBar1.Value = 0;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
            
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("Stopwatch has Started ");
            isActive = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isActive = false;
            this.timer2.Stop();
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("Stopwatch has Stopped ");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTimer();
            this.progressBar1.Value = 0;

            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("Stopwatch has Reseted ");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if( isActive)
            {
                TimeMS++;
                if (TimeMS > 100)
                {
                    TimeSec++;
                    TimeMS = 0;
                    if (TimeSec > 60)
                    {
                        TimeMin++;
                        TimeSec = 0;
                    }
                }
            }
           DrawTime();
        }
        private void DrawTime()
        {
            Milliseconds.Text = string.Format("{0:00}", TimeMS);
            Seconds.Text = string.Format("{0:00}", TimeSec);
            Mintes.Text = string.Format("{0:00}", TimeMin);

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            
        }

       private void progressBar1_Click(object sender, EventArgs e) { }
        
    }
}
