using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace MyGameMed {
    public partial class Game_Qestion : UserControl {
        string categotry, question;
        ToolTip t1 = new ToolTip();
        ToolTip t2 = new ToolTip();
        ToolTip t3 = new ToolTip();
        ToolTip t4 = new ToolTip();
        bool video_k = false;
        #region переменные таймера
        int limit = 120; // время для отсчета
        int visible_second = 60; // используется для визуализации в формате минуты:секнуд
        double temp; // временная переменная для преобразования дробного к целому
        int[] one_numb = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //массив для одиночных цифр
        bool first_interval = true; // для отслеживания первого интервала таймера 
        #endregion 
        public Game_Qestion(string name, string cat) {
            InitializeComponent();
            t1.SetToolTip(start_time, "Запустить таймер.");
            t2.SetToolTip(start_answer, "Перейти к ответу.");
            t3.SetToolTip(back, "Назад к списку вопросов.");
            t4.SetToolTip(video, "Показать/скрыть видео.");

            question = name;
            categotry = cat;

            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name) {
                    text.Rtf = q.content_text;
                    if (text.Rtf.Length != 133) {
                        text.Visible = true;
                    }
                    if (q.content_pic != "Файл не выбран." && !String.IsNullOrEmpty(q.content_pic)) {
                        picture.Image = Image.FromFile(q.content_pic);
                        picture.Visible = true;
                        if (text.Rtf.Length == 133) picture.Dock = DockStyle.Fill;
                    }
                    if (q.content_video != "Файл не выбран." && !String.IsNullOrEmpty(q.content_video)) {
                        video.Visible = true;
                    }
                    break;
                }
        }
        private void timer1_Tick(object sender, EventArgs e) {
            if (limit >= 0){
                temp = limit / 60;
                if (visible_second <= 0) visible_second = 60; //визуализация секунд
               // MessageBox.Show(fix_second(visible_second));
                timer_label.Text = Convert.ToString(Convert.ToInt32(Math.Truncate(temp))) + ":" + fix_second(visible_second);
                if (first_interval) {
                    timer_label.Text = "00:00";
                    first_interval = false;
                }
                limit--; // на секунду меньше
                visible_second--; // на секунду меньше для визуализации
            }
            else {
                timer1.Stop();
                timer_label.Text = "00:00";
                first_interval = true;
                visible_second = 60;
            }
        }
        string fix_second(int n) {
            foreach (int i in one_numb)
                if (i == n) return "0" + n.ToString();
            return n.ToString();
        }
        private void start_answer_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            garbage_collector();
            Game.selfref_g.open_game_answer(question, categotry);
        }
        private void back_Click(object sender, EventArgs e) {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            garbage_collector();
            Game.selfref_g.open_game_questions(categotry);
        }
        private void video_Click(object sender, EventArgs e)  {
            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name)
                    if (!video_k) {
                        axWindowsMediaPlayer1.Dock = DockStyle.Fill;
                        axWindowsMediaPlayer1.URL = q.content_video;
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
        private void start_time_Click(object sender, EventArgs e) {
            foreach (Question q in Game.selfref_g.que)
                if (categotry == q.category && question == q.name) {
                    if (q.time > 0) {
                        limit = q.time * 60;
                        timer_label.Text = "00:00";
                        timer1.Start();
                    }
                    else MessageBox.Show("В данном вопросе отключено время.");
                    break;
                }
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
            timer1.Stop();
            Controls.Clear();
            body_answer.Controls.Clear();
            doc.Controls.Clear();
            //content
            text.Rtf = "";
            picture.Image = null;
            back.Image = null;
            start_answer.Image = null;
            start_time.Image = null;
            //object
            axWindowsMediaPlayer1 = null;
            picture = null;
            text = null;
            back = null;
            splitter1 = null;
            video = null;
            start_time = null;
            start_answer = null;
            timer1 = null;
            timer_label = null;
            t1 = null;
            t2 = null;
            t3 = null;
            t4 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
