using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace guitar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {
            SoundPlayer mysound = new SoundPlayer(@"D:\VP-Project\guitar\Resources\b24.wav");
            mysound.Play();
        }

        private void lineShape2_Click(object sender, EventArgs e)
        {
            SoundPlayer mysound = new SoundPlayer(@"D:\VP-Project\guitar\Resources\b24.wav");
            mysound.Play();
        }
    }
}