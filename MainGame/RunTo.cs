﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGame
{
    public partial class RunTo : Form
    {
        public RunTo()
        {
            InitializeComponent();
        }

        public int runNumber
        {
            get
            {
                return (int)runGennud.Value;
            }
            set
            {
                runGennud.Value = value;
            }
        }
    }
}
