﻿using Principal.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.GUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Cronometro.Start();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
