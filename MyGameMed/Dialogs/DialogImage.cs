using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGameMed {
    public partial class DialogImage : Form {
        public DialogImage(string file) {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(file);
        }
    }
}
