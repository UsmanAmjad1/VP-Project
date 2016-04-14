using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using NAudio.wave;
using NAudio.Lame;

namespace ssds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RECORDING_Click(object sender, EventArgs e)
        {
            if (notePiano.Checked)
            {
            SoundPlayer keySound = new SoundPlayer(Notes.c1);           
            keySound.Play();      
            }

            if (noteBass.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.double_bass_C1_1_forte_arco_normal);
                keySound.Play();            
            }

            if (noteOrgan.Checked)
            {
                SoundPlayer keySound = new SoundPlayer(Notes.o1);
                keySound.Play();
            }
        }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelRECORD_Click(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void pianoImage_Click(object sender, EventArgs e)
        {

        }

        private void keyC1_Click(object sender, EventArgs e)
        {

        }

        private void keyC1M_Click(object sender, EventArgs e)
        {

        }
    }
}
