﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameMed {
    public partial class DialogVideo : Form {
        public DialogVideo(string file) {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = file;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void DialogVideo_FormClosing(object sender, FormClosingEventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1 = null;
            GC.Collect();
        }
    }
}
