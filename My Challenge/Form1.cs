using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;



namespace ssds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void keyC1_Click(object sender, EventArgs e)
        {
            

    SoundPlayer mySound = new SoundPlayer(@"D:\VP-Project\My Challenge\Resources\b36.wav");
    mySound.Play();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer mysound = new SoundPlayer();
            mysound.Play();
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
                

        
        }

        private void button23_Click(object sender, EventArgs e)
        {

            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
        }

        private void labelRECORD_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
        }

        private void pianoImage_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
        }

       

        private void keyC1M_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer();

            keysound.Play();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer(@"D:\VP-Project\My Challenge\Resources\d#28.wav");
            keysound.Play();
        }

        private void KeyCM2_Click(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer(@"D:\VP-Project\My Challenge\Resources\c#26.wav");
            keysound.Play();
        }

        private void keyC1M_Click_1(object sender, EventArgs e)
        {
            SoundPlayer keysound = new SoundPlayer(@"D:\VP-Project\My Challenge\Resources\E29.wav");
            keysound.Play();
        }
    }
}
