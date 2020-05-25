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
    public partial class Game_Answer : UserControl {
        string categotry, question;
        ToolTip t1 = new ToolTip();
        ToolTip t2 = new ToolTip();
        bool video_k = false;
        public Game_Answer(string name, string cat) {
            InitializeComponent();
            t1.SetToolTip(answering, "Венуться к категориям.");
            t2.SetToolTip(back, "Назад к вопросу.");

            question = name;
            categotry = cat;

            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name) {
                    text.Rtf = q.answer_text;
                    if (text.Rtf.Length != 133) {
                        text.Visible = true;
                    }
                    if (q.answer_pic != "Файл не выбран." && !String.IsNullOrEmpty(q.answer_pic)) {
                        picture.Image = Image.FromFile(q.answer_pic);
                        picture.Visible = true;
                        if (text.Rtf.Length == 133) picture.Dock = DockStyle.Fill;
                    }
                    if (q.answer_video != "Файл не выбран." && !String.IsNullOrEmpty(q.answer_video)) {
                        video.Visible = true;
                    }
                    break;
                }
        }
        private void start_answer_Click(object sender, EventArgs e) {
            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name) {
                    q.status = 1;
                    if (!is_finish()) {
                        File.Delete("save.sv");
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        garbage_collector();
                        Game.selfref_g.open_game_finish();
                    }
                    else {
                        Game.selfref_g.save_to_file("save.sv");
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        garbage_collector();
                        Game.selfref_g.open_game_category();
                    }
                    break;
                }
        }
        private void back_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Game.selfref_g.open_game_question(question, categotry);
            garbage_collector();
        }
        private void pictureBox2_Click(object sender, EventArgs e) {
            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name)
                    if (!video_k) {
                        axWindowsMediaPlayer1.Dock = DockStyle.Fill;
                        axWindowsMediaPlayer1.URL = q.answer_video;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        axWindowsMediaPlayer1.Visible = true;
                        body_answer.Visible = false;
                        axWindowsMediaPlayer1.BringToFront();
                        video_k = true;
                        break;
                    }
                    else {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        axWindowsMediaPlayer1.Visible = false;
                        body_answer.Visible = true;
                        video_k = false;
                        break;
                    }
        }
        bool is_finish() {
            foreach (Question q in Game.selfref_g.que)
                if (q.status == 0) return true;
            return false;
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
            if (e.newState == 1) {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.Visible = false;
                body_answer.Visible = true;
                video_k = false;
            }
        }
        void garbage_collector() {
            //control
            Controls.Clear();
            body_answer.Controls.Clear();
            doc.Controls.Clear();
            //content
            text.Rtf = "";
            picture.Image = null;
            back.Image = null;
            answering.Image = null;
            //object
            axWindowsMediaPlayer1 = null;
            picture.Image = null;
            picture = null;
            text = null;
            back = null;
            splitter1 = null;
            video = null;
            answering = null;
            categotry = null;
            question = null;
            t1 = null;
            t2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
