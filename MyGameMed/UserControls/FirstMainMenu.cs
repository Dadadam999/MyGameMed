using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyGameMed
{
    public partial class FirstMainMenu : UserControl
    {
        public FirstMainMenu()
        {
            InitializeComponent();
            openFileDialog1.Filter = "(*.mg)|*.mg";
            menu_resize();
        }
        private void Form1_Resize(object sender, EventArgs e) { menu_resize(); }
        void menu_resize()
        {
            menu.Top = Height / 2 - menu.Height / 2;
            menu.Left = Width / 2 - menu.Width / 2;
        }
        private void exit_Click(object sender, EventArgs e) { Main.selfref_m.Close(); }
        private void help_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Dock = DockStyle.Fill;
            Controls.Add(h);
            Controls.SetChildIndex(h, 0);
        }
        private void editor_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.mg)|*.mg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    Editor ed = new Editor(saveFileDialog1.FileName, true);
                    ed.Dock = DockStyle.Fill;
                    Controls.Add(ed);
                    Controls.SetChildIndex(ed, 0);
                }
        }
        private void load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Game g = new Game(openFileDialog1.FileName);
                g.Dock = DockStyle.Fill;
                Controls.Add(g);
                Controls.SetChildIndex(g, 0);
            }
        }
        private void change_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Editor ed = new Editor(openFileDialog1.FileName);
                ed.Dock = DockStyle.Fill;
                Controls.Add(ed);
                Controls.SetChildIndex(ed, 0);
            }
        }
        private void contin_Click(object sender, EventArgs e)
        {
            if (File.Exists("save.sv"))
            {
                Game g = new Game(true);
                g.Dock = DockStyle.Fill;
                Controls.Add(g);
                Controls.SetChildIndex(g, 0);
            }
            else MessageBox.Show("Нет предыдущих версий игры.");
        }
    }
}
