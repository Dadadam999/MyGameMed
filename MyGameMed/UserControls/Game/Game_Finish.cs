using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameMed {
    public partial class Game_Finish : UserControl {
        public Game_Finish() {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) {
            Main.selfref_m.load_fmm();
        }
    }
}
