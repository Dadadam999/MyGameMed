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

namespace MyGameMed {
    public partial class Game_Questions : UserControl {
        string cat_name;
        List<Panel> questions_visible = new List<Panel>();
        ToolTip t1 = new ToolTip();
        public Game_Questions(string name_category) {
            InitializeComponent();
            resize_q();
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "header.png")) {
                header.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\header.png");
                header.Visible = true;
            }
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "footer.png")) {
                footer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\footer.png");
                footer.Visible = true;
            }
            t1.SetToolTip(back, "Назад к списку категорий.");
            cat_name = name_category;
            init_que();

        }
        bool onerow = true;
        private void que_click(object sender, EventArgs e) {
            garbage_collector();
            Game.selfref_g.open_game_question(((Panel)sender).Tag.ToString(), cat_name);
        }
        void init_que() {
            int count = 0, left = 0, top = 0;
            int widh_block = SystemInformation.PrimaryMonitorSize.Width / 8, height_block = SystemInformation.PrimaryMonitorSize.Width / 8;

            header.Height = SystemInformation.PrimaryMonitorSize.Width / 10;
            footer.Height = SystemInformation.PrimaryMonitorSize.Width / 14;

            for (int i = 0; i < Game.selfref_g.que.Count; i++)
                if (cat_name == Game.selfref_g.que[i].category) {
                    questions_visible.Add(new Panel());
                    questions_visible[questions_visible.Count - 1].Width = widh_block;
                    questions_visible[questions_visible.Count - 1].Height = height_block;
                    questions_visible[questions_visible.Count - 1].BackgroundImageLayout = ImageLayout.Zoom;
                    questions_visible[questions_visible.Count - 1].Click += new EventHandler(que_click);
                    questions_visible[questions_visible.Count - 1].Tag = Game.selfref_g.que[i].name;
                    switch (Game.selfref_g.que[i].point) {
                        case 10:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._10;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a10;
                            break;
                        case 20:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._20;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a20;
                            break;
                        case 30:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._30;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a30;
                            break;
                        case 40:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._40;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a40;
                            break;
                        case 50:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._50;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a50;
                            break;
                        case 70:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources._70;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.a70;
                            break;
                        default:
                            if (Game.selfref_g.que[i].status == 0) questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.empty;
                            else questions_visible[questions_visible.Count - 1].BackgroundImage = Properties.Resources.aempty;
                            break;
                    }
                    ///не торгать оно работает
                    if (count > 3) {

                        count = 0;

                        questions_visible[questions_visible.Count - 1].Top = top;
                        top += questions_visible[questions_visible.Count - 1].Height;

                        questions_visible[questions_visible.Count - 1].Left = left;
                        left += questions_visible[questions_visible.Count - 1].Width;

                        left = 0;

                        onerow = false;
                    }
                    else {

                        questions_visible[questions_visible.Count - 1].Top = top;

                        questions_visible[questions_visible.Count - 1].Left = left;
                        left += questions_visible[questions_visible.Count - 1].Width;
                        
                        count++;
                    }

             //  debug   MessageBox.Show("W:" + p.Left + "\nH:" + p.Top + "\nC:" + count);
                    body.Controls.Add(questions_visible[questions_visible.Count - 1]);
                }
            body.Width = widh_block * 5 + widh_block/5;
            if (onerow) body.Height = height_block;
            else body.Height = height_block * 2;
        }
        private void back_Click(object sender, EventArgs e) {
            garbage_collector();
            Game.selfref_g.open_game_category();
        }
        private void Game_Questions_Resize(object sender, EventArgs e) { resize_q(); }
        void resize_q() {
            body.Top = Height / 2 - body.Height / 2 + 10;
            body.Left = Width / 2 - body.Width / 2;
        }
        void garbage_collector() {
            //Control
            Controls.Clear();
            questions_visible.Clear();
            uppanel.Controls.Clear();
            body.Controls.Clear();
            //content
            footer.Image = null;
            header.Image = null;
            back.Image = null;
            //object
            questions_visible = null;
            footer.Image = null;
            header.Image = null;
            back.Image = null;
            uppanel = null;
            body = null;
            t1 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
