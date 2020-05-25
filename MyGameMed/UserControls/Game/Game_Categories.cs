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
using System.Diagnostics;

namespace MyGameMed {
    public partial class Game_Categories : UserControl {
        List<Panel> category_visible = new List<Panel>();
        List<Label> category_label = new List<Label>();
        public Game_Categories() {
            InitializeComponent();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "header.png")) {
                header.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\header.png");
                header.Visible = true;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "footer.png")) {
                footer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\footer.png");
                footer.Visible = true;
            }
            init_cat();
            kote_resize();
            body_resize();
            foreach (Categories c in Game.selfref_g.cat)
                if (c.iskot == true) {
                    kote.Visible = true;
                    break;
                }
        }
        private void cat_click(object sender, EventArgs e) {
            garbage_collector();
            Game.selfref_g.open_game_questions(((Label)sender).Text);
        }
        void init_cat() {
            int widh_block = SystemInformation.PrimaryMonitorSize.Width / 6, height_block = SystemInformation.PrimaryMonitorSize.Width / 6;
            float font_F = SystemInformation.PrimaryMonitorSize.Height / 60;
            float font_F_k = SystemInformation.PrimaryMonitorSize.Height / 90;

            body.Width = widh_block * 5 + widh_block/4; //+ widh_block / 10;
            body.Height = height_block * 2 + widh_block / 5; //+ height_block / 10;

            kote.Width = SystemInformation.PrimaryMonitorSize.Width / 14;
            kote.Height = SystemInformation.PrimaryMonitorSize.Width / 14;

            header.Height = SystemInformation.PrimaryMonitorSize.Width / 10;
            footer.Height = SystemInformation.PrimaryMonitorSize.Width / 14;

            foreach (Categories c in Game.selfref_g.cat)
              if (c.iskot == false) {
                category_visible.Add(new Panel());
                    category_visible[category_visible.Count - 1].Width = widh_block;
                    category_visible[category_visible.Count - 1].Height = height_block;
                    category_visible[category_visible.Count - 1].BackgroundImage = Properties.Resources.категория;
                    category_visible[category_visible.Count - 1].BackgroundImageLayout = ImageLayout.Zoom;
                category_label.Add(new Label());
                    category_label[category_label.Count - 1].Text = c.name;
                    category_label[category_label.Count - 1].Font = new Font("Microsoft Sans Serif", font_F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    category_label[category_label.Count - 1].Padding = new Padding(15, 0, 15, 0);
                    category_label[category_label.Count - 1].AutoSize = false;
                    category_label[category_label.Count - 1].Dock = DockStyle.Fill;
                    category_label[category_label.Count - 1].TextAlign = ContentAlignment.MiddleCenter;
                    category_label[category_label.Count - 1].Click += new EventHandler(cat_click);
                    category_visible[category_visible.Count - 1].Controls.Add(category_label[category_label.Count - 1]);
                category_label.Add(new Label());
                    if (count_qest(c.name) <= 0) category_label[category_label.Count - 1].Text = "Все отвечено!"; else category_label[category_label.Count - 1].Text = "Осталось: " + count_qest(c.name).ToString();
                    category_label[category_label.Count - 1].Font = new Font("Microsoft Sans Serif", font_F_k, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    category_label[category_label.Count - 1].Dock = DockStyle.Bottom;
                    category_label[category_label.Count - 1].TextAlign = ContentAlignment.TopLeft;
                    category_label[category_label.Count - 1].Padding = new Padding(30, 0, 0, 0);
                    category_label[category_label.Count - 1].AutoSize = false;
                    category_label[category_label.Count - 1].Height = 35;
                    category_visible[category_visible.Count - 1].Controls.Add(category_label[category_label.Count - 1]);
                    category_visible[category_visible.Count - 1].Controls.SetChildIndex(category_label[category_label.Count - 1], 0);

                body.Controls.Add(category_visible[category_visible.Count - 1]);
            }
        }
        bool is_all_answer(string cat_name) {
            foreach (Question q in Game.selfref_g.que)
                if (cat_name == q.category && q.status == 0) return false;
            return true;
        }
        int count_qest(string cat_name) {
            int k = 0;
            foreach (Question q in Game.selfref_g.que)
                if (cat_name == q.category && q.status == 0)
                    k++;
            return k;
        }
        private void back_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Вы точно хотите выйти из игры?","", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                garbage_collector();
                Main.selfref_m.load_fmm();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e) { //кот в мешке 
            foreach (Categories c in Game.selfref_g.cat)
                if (c.iskot == true) {
                    garbage_collector();
                    Game.selfref_g.open_game_questions(c.name);
                    break;
                }
        }
        public void kote_resize() {
            kote.Top = Height - kote.Height;
            kote.Left = 0;
        }
        public void body_resize() {
            body.Top = Height / 2 - body.Height / 2 + body.Height/10; // - /10 отступ видео сверху
            body.Left = Width / 2 - body.Width / 2;
        }
        private void Game_Categories_Resize(object sender, EventArgs e) {
            kote_resize();
            body_resize();
        }
        void garbage_collector() {
            //Controls.Clear();
            uppanel.Controls.Clear();
            body.Controls.Clear();
            category_visible.Clear();
            category_label.Clear();
            //content
            footer.Image = null;
            header.Image = null;
            kote.Image = null;
            back.Image = null;
            //object
            category_visible = null;
            category_label = null;
            footer = null;
            header = null;
            kote = null;
            back = null;
            uppanel = null;
            body = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
