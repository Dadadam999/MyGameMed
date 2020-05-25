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
    public partial class DialogCategory : Form {
        string old = "";
        public DialogCategory() {
            InitializeComponent();
        }
        public DialogCategory(string oldname, bool iskot) {
           InitializeComponent();
           old = oldname;
           name.Text = oldname;
           kot.Checked = iskot; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(old))
            {
                Editor.selfref_e.add_category(name.Text, kot.Checked);
                Close();
            }
            else
            {
                Editor.selfref_e.change_category(old, name.Text, kot.Checked);
                Close();
            }
        }
        bool clone_kote() {
            foreach (Categories c in Editor.selfref_e.cat)
                if (c.iskot) return true;
            return false;
        }
        private void kot_Click(object sender, EventArgs e) {
            if (clone_kote()) {
                MessageBox.Show("Кот в мешке уже существует.");
                kot.Checked = false;
            }
        }
    }
}
