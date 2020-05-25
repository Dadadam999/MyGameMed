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
    public partial class Main : Form {
        public static Main selfref_m { get; set; }
        public Main() {
            InitializeComponent();
            // Screen..Bounds
            WindowState = FormWindowState.Maximized;
            selfref_m = this;
            load_fmm();
        }
        public void load_fmm() {
            Controls.Clear();
            FirstMainMenu fmm = new FirstMainMenu();
            fmm.Dock = DockStyle.Fill;
            Controls.Add(fmm);
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            if (Editor.selfref_e != null)
                if (Editor.selfref_e.Visible == true)
                {
                    if (Editor.selfref_e.category.TabPages.Count > 0)
                        if (Editor.selfref_e.list.SelectedIndex >= 0)
                            Editor.selfref_e.save.PerformClick();
                        else
                          if (Editor.selfref_e.list.Items.Count <= 1)
                            Editor.selfref_e.create.PerformClick();

                    Editor.selfref_e.сохранитьToolStripMenuItem.PerformClick();
                }
            if (e.CloseReason != CloseReason.UserClosing) return;
            e.Cancel = DialogResult.Yes != MessageBox.Show("Вы действительно хотите выйти из приложения?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
