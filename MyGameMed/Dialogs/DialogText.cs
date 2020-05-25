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
    public partial class DialogText : Form {
        public DialogText(ref RichTextBox output, string name_form) {
            InitializeComponent();
            richTextBox1.Rtf = output.Rtf;
            vault = output;
            Text = name_form;
        }
        RichTextBox vault { get; set; }
        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e) {
            vault.Rtf = richTextBox1.Rtf;
        }
        private void DialogText_FormClosing(object sender, FormClosingEventArgs e) {
            vault.Rtf = richTextBox1.Rtf;
        }
        private void toolStripButton4_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void toolStripButton5_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void toolStripButton6_Click(object sender, EventArgs e) {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
