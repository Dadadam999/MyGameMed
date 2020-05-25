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
using System.Runtime.Serialization.Formatters.Binary;

namespace MyGameMed {
    public partial class Editor : UserControl {
        public string file = "";
        public List<Question> que = new List<Question>();
        public List<Categories> cat = new List<Categories>();
        public static Editor selfref_e { get; set; }
        public string name_quest;
        public Editor(string path, bool create) {
            InitializeComponent();
            selfref_e = this;
            file = path;
            status.SelectedIndex = 0;
            if (list.Items.Count > 0) list.SelectedIndex = 0;
            add_category("Категория 1", false);
        }
        public Editor(string path) {
            InitializeComponent();
            selfref_e = this;
            status.SelectedIndex = 0;
            file = path;
            load_is_file(file);
            refrash_tab();
            refrash_question_list();
            if (list.Items.Count > 0){
                list.SelectedIndex = 0;
                refrash_question_select();
            }  
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e) {
            if (category.TabPages.Count > 0)
                if (list.SelectedIndex >= 0)
                    save.PerformClick();
                else
                  if (list.Items.Count <= 1) 
                        create.PerformClick();
            сохранитьToolStripMenuItem.PerformClick();
            Main.selfref_m.load_fmm();
            Hide();
        }
        #region file
        public void save_to_file(string path) {
            Serialize s = new Serialize();
            s.cat = cat;
            s.que = que;
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
                binFormat.Serialize(fStream, s);
                fStream.Close();
            }
        }
        public void load_is_file(string path) {
            if (File.Exists(path)) {
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                long size = file.Length;
                if (size > 0) {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    BinaryFormatter formatter = new BinaryFormatter();
                    Serialize s = new Serialize();
                    s = (Serialize)formatter.Deserialize(fs);
                    cat = s.cat;
                    que = s.que;
                    fs.Close();
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "(*.mg)|*.mg";
            if (file != "") {
                save_question_files(file);
                save_to_file(file);
            } else {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                    file = saveFileDialog1.FileName;
                    save_question_files(file);
                    save_to_file(file);
                    MessageBox.Show("Файл создан.");
                }
            }
        }
        void save_question_files(string file) {
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file)))
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file));
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image"))
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image");
            string path_pic = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image";
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video")) 
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video");
            string path_video = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video";
            for (int i = 0; i < que.Count; i++) {
                    if (File.Exists(que[i].content_pic) && que[i].content_pic != "Файл не выбран.")
                        if (!File.Exists(path_pic + @"\" + Path.GetFileName(que[i].content_pic))) {
                            File.Copy(que[i].content_pic, path_pic + @"\" + Path.GetFileName(que[i].content_pic));
                            que[i].content_pic = Path.GetFileName(que[i].content_pic);
                            content_pic.Text = que[i].content_pic;
                        }
                        else {
                            que[i].content_pic = Path.GetFileName(que[i].content_pic);
                            content_pic.Text = que[i].content_pic;
                        }
                    if (File.Exists(que[i].content_video) && que[i].content_video != "Файл не выбран.")
                        if (!File.Exists(path_video + @"\" + Path.GetFileName(que[i].content_video))) {
                            File.Copy(que[i].content_video, path_video + @"\" + Path.GetFileName(que[i].content_video));
                            que[i].content_video = Path.GetFileName(que[i].content_video);
                            content_video.Text = que[i].content_video;
                        }
                        else {
                            que[i].content_video = Path.GetFileName(que[i].content_video);
                            content_video.Text = que[i].content_video;
                        }
                    if (File.Exists(que[i].answer_pic) && que[i].answer_pic != "Файл не выбран.")
                        if (!File.Exists(path_pic + @"\" + Path.GetFileName(que[i].answer_pic))) {
                            File.Copy(que[i].answer_pic, path_pic + @"\" + Path.GetFileName(que[i].answer_pic));
                            que[i].answer_pic = Path.GetFileName(que[i].answer_pic);
                            answer_pic.Text = que[i].answer_pic;
                        }
                        else {
                            que[i].answer_pic = Path.GetFileName(que[i].answer_pic);
                            answer_pic.Text = que[i].answer_pic;
                        }
                    if (File.Exists(que[i].answer_video) && que[i].answer_video != "Файл не выбран.")
                        if (!File.Exists(path_video + @"\" + Path.GetFileName(que[i].answer_video))) {
                            File.Copy(que[i].answer_video, path_video + @"\" + Path.GetFileName(que[i].answer_video));
                            que[i].answer_video = Path.GetFileName(que[i].answer_video);
                            answer_video.Text = que[i].answer_video;
                        }
                        else {
                            que[i].answer_video = Path.GetFileName(que[i].answer_video);
                            answer_video.Text = que[i].answer_video;
                        }
                }
        }
        #endregion
        #region category
        bool is_clone_cat(string name) {
            foreach (Categories cc in cat)
                if (name == cc.name) return true;
            return false;
        }
        public void add_category(string name, bool iskot) {
            if (is_clone_cat(name)) MessageBox.Show("Категория с таким именем уже существует");
            else {
                Categories c = new Categories();
                c.name = name;
                c.iskot = iskot;
                cat.Add(c);
                refrash_tab();
                category.SelectedIndex = category.TabPages.Count - 1;
                refrash_question_list();
                refrash_question_select();
            }
        }
        public void change_category(string old_name, string name, bool iskot) {
            if (is_clone_cat(name)) MessageBox.Show("Категория с таким именем уже существует");
            else {
                for (int i = 0; i < que.Count; i++)
                    if (que[i].category == old_name)
                        que[i].category = name;
                      
                
                for (int i = 0; i < cat.Count; i++)
                    if (old_name == cat[i].name) {
                        cat.Remove(cat[i]);
                        break;
                    } 
                Categories c = new Categories();
                c.name = name;
                c.iskot = iskot;
                cat.Add(c);
            }
            refrash_tab();
            refrash_question_list();
            refrash_question_select();
        }
        public void refrash_tab() {
            category.TabPages.Clear();
            foreach (Categories c in cat) 
                category.TabPages.Add(new TabPage(c.name));
            сохранитьToolStripMenuItem.PerformClick();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cat.Count > 0)
              for (int i = 0; i < cat.Count; i++)
                if (category.SelectedTab.Text == cat[i].name) {
                   cat.Remove(cat[i]);
                   break;
                }
            refrash_tab();
            refrash_question_list();
            refrash_question_select();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogCategory dc = new DialogCategory();
            dc.Show();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Categories c in cat)
                if (category.SelectedTab.Text == c.name) {
                    DialogCategory dc = new DialogCategory(c.name, c.iskot);
                    dc.Show();
                    break;
                }
        }
        private void category_Selecting(object sender, TabControlCancelEventArgs e) {
            refrash_question_list();
            refrash_question_select();
        }
        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e) {
            DialogCategory dc = new DialogCategory();
            dc.Show();
        }
        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e) {
            foreach (Categories c in cat)
                if (category.SelectedTab.Text == c.name) {
                    DialogCategory dc = new DialogCategory(c.name, c.iskot);
                    dc.Show();
                    break;
                }
            refrash_tab();
        }
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (cat.Count > 0)
                for (int i = 0; i < cat.Count; i++)
                    if (category.SelectedTab.Text == cat[i].name) {
                        cat.Remove(cat[i]);
                        break;
                    }
            refrash_tab();
            refrash_question_list();
            refrash_question_select();
        }
        private void переместитьВправоToolStripMenuItem_Click(object sender, EventArgs e) {
            if (category.TabPages.Count > 1)
                for (int i = 0; i < cat.Count; i++)
                    if (category.SelectedTab.Text == cat[i].name && i < cat.Count - 1) {
                        int index_temp = category.SelectedIndex;

                        Categories temp = new Categories();
                        temp.name = cat[i + 1].name;
                        temp.iskot = cat[i + 1].iskot;

                        cat[i + 1].name = cat[i].name;
                        cat[i + 1].iskot = cat[i].iskot;

                        cat[i].name = temp.name;
                        cat[i].iskot = temp.iskot;

                        refrash_tab();
                        category.SelectTab(index_temp + 1);
                        refrash_question_list();
                        refrash_question_select();

                        break;
                    }
        }
        private void переместитьВлевоToolStripMenuItem_Click(object sender, EventArgs e) {
            if (category.TabPages.Count > 1)
                for (int i = 0; i < cat.Count; i++)
                    if (category.SelectedTab.Text == cat[i].name && i > 0) {
                        int index_temp = category.SelectedIndex;

                        Categories temp = new Categories();
                        temp.name = cat[i - 1].name;
                        temp.iskot = cat[i - 1].iskot;

                        cat[i - 1].name = cat[i].name;
                        cat[i - 1].iskot = cat[i].iskot;

                        cat[i].name = temp.name;
                        cat[i].iskot = temp.iskot;

                        refrash_tab();
                        category.SelectTab(index_temp - 1);
                        refrash_question_list();
                        refrash_question_select();

                        break;
                    }
        }
        #endregion
        #region question
        bool is_clone_que(string name) {
            foreach (Question q in que)
                if (name == q.name && q.category == category.SelectedTab.Text) return true;
            return false;
        }
        private void button4_Click(object sender, EventArgs e) {
            DialogText dt = new DialogText(ref content_text, "Текст вопроса");
            dt.Show();
        }
        private void button7_Click(object sender, EventArgs e) {
            DialogText dt = new DialogText(ref answer, "Тект ответа");
            dt.Show();
        }
        private void button5_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                content_pic.Text = openFileDialog1.FileName;
        }
        private void button6_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "All files (*.*)|*.*|(*.avi)|*.avi|(*.mp4)|*.mp4|(*.3gp)|*.3gp|(*.mov)|*.mov|(*.mpg)|*.mpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                content_video.Text = openFileDialog1.FileName;
        }
        void clear_e() {
            name_quest = "";
            content_text.Rtf = "";
            content_pic.Text = "Файл не выбран.";
            content_video.Text = "Файл не выбран.";
            answer.Rtf = "";
            answer_pic.Text = "Файл не выбран.";
            answer_video.Text = "Файл не выбран.";
            point.Value = 10;
            status.Text = "";
            time.Value = 1;
        }
        private void create_Click(object sender, EventArgs e) {
            if (category.TabPages.Count > 0) {
                string error = "";
                if (is_clone_que(name_quest)) error += "Ошибка: Такой вопрос уже существует в данной категории.\n";
                if (error != "") MessageBox.Show(error);
                else {
                    Question q = new Question();
                    q.name = get_quest_name(category.SelectedTab.Text);
                    q.category = category.SelectedTab.Text;
                    q.content_text = content_text.Rtf;
                    q.content_pic = content_pic.Text;
                    q.content_video = content_video.Text;
                    q.answer_text = answer.Rtf;
                    q.answer_pic = answer_pic.Text;
                    q.answer_video = answer_video.Text;
                    q.point = Convert.ToInt32(point.Value);
                    q.status = status.SelectedIndex;
                    q.time = Convert.ToInt32(time.Value);
                    que.Add(q);
                    refrash_question_list();
                    refrash_question_select();
                }
            }
        }
        string get_quest_name(string cat) {
            int k = 1;
            foreach (Question q in que)
                if (q.category == cat)
                    k++;
            return "Вопрос " + k.ToString();
        }
        private void save_Click(object sender, EventArgs e) {
            if (category.TabPages.Count > 0 ) {
                for (int i = 0; i < que.Count; i++)
                        if (que[i].name == name_quest && que[i].category == category.SelectedTab.Text) {
                            que[i].content_text = content_text.Rtf;
                            que[i].content_pic = content_pic.Text;
                            que[i].content_video = content_video.Text;
                            que[i].answer_text = answer.Rtf;
                            que[i].answer_pic = answer_pic.Text;
                            que[i].answer_video = answer_video.Text;
                            que[i].point = Convert.ToInt32(point.Value);
                            que[i].status = status.SelectedIndex;
                            que[i].time = Convert.ToInt32(time.Value);
                            int temp_list = list.SelectedIndex;
                            refrash_question_list();
                            list.SelectedIndex = temp_list;
                            refrash_question_select();
                            break;
                        }
            }
        }
        public void refrash_question_list() {
            list.Items.Clear();
            if (category.TabPages.Count > 0) {
                foreach (Question q in que)
                    if (q.category == category.SelectedTab.Text)
                        list.Items.Add(q.name);
                list.Items.Add("(новый)");
            }
            create.Visible = true;
            save.Visible = false;
            сохранитьToolStripMenuItem.PerformClick();
        }
        public void refrash_question_select() {
            clear_e();
            if (list.SelectedIndex >= 0 && category.TabPages.Count > 0) 
                foreach(Question q in que)
                    if(list.SelectedItem.ToString() != "(новый)" && list.SelectedItem.ToString() == q.name && category.SelectedTab.Text == q.category) {
                        name_quest = q.name;
                        content_text.Rtf = q.content_text;
                        content_pic.Text = q.content_pic;
                        content_video.Text = q.content_video;
                        answer.Rtf = q.answer_text;
                        answer_pic.Text = q.answer_pic;
                        answer_video.Text = q.answer_video;
                        point.Value = q.point;
                        status.SelectedIndex = q.status;
                        time.Value = q.time;
                        create.Visible = false;
                        save.Visible = true;
                        break;
                    } 
        }
        private void удалитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e) {
            if (list.SelectedIndex >= 0 && category.TabPages.Count > 0)
                for (int i = 0; i < que.Count; i++)
                    if (list.SelectedItem.ToString() == que[i].name && category.SelectedTab.Text == que[i].category) {
                        int index = list.SelectedIndex - 1;
                        que.Remove(que[i]);
                        reindexing_que();
                        if (index >= 0) list.SetSelected(index, true);
                        refrash_question_list();
                        refrash_question_select();
                        break;
                    }
        }
        void reindexing_que() {
            int k = 1;
            for (int i = 0; i < que.Count; i++)
                if (category.SelectedTab.Text == que[i].category)
                    que[i].name = "Вопрос " + k++.ToString();
        }
        private void list_SelectedIndexChanged(object sender, EventArgs e) {
            save.PerformClick();
            сохранитьToolStripMenuItem.PerformClick();
            refrash_question_select();
            
        }
        private void content_video_DoubleClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(content_video.Text) && content_video.Text != "Файл не выбран.") {
                string path_temp = "";
                if (!content_video.Text.Contains(@"\"))
                    path_temp = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + @"video\" + content_video.Text;
                else
                    path_temp = content_video.Text;
                DialogVideo dv = new DialogVideo(path_temp);
                dv.Show();
            }
        }
        private void answer_video_DoubleClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(answer_video.Text) && answer_video.Text != "Файл не выбран.") {
                string path_temp = "";
                if (!answer_video.Text.Contains(@"\"))
                    path_temp = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + @"video\" + answer_video.Text;
                else
                    path_temp = answer_video.Text;
                DialogVideo dv = new DialogVideo(path_temp);
                dv.Show();
            }
        }
        private void answer_pic_DoubleClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(answer_pic.Text) && answer_pic.Text != "Файл не выбран.") {
                string path_temp = "";
                if (!answer_pic.Text.Contains(@"\"))
                    path_temp = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + @"image\" + answer_pic.Text;
                else
                    path_temp = answer_pic.Text;
                DialogImage dv = new DialogImage(path_temp);
                dv.Show();
            }
        }
        private void content_pic_DoubleClick(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(content_pic.Text) && content_pic.Text != "Файл не выбран.") {
                string path_temp = "";
                if (!content_pic.Text.Contains(@"\"))
                    path_temp = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + @"image\" + content_pic.Text;
                else
                    path_temp = content_pic.Text;
                DialogImage dv = new DialogImage(path_temp);
                dv.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                answer_pic.Text = openFileDialog1.FileName;
        }
        private void button2_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "(*.avi)|*.avi|(*.mp4)|*.mp4|(*.3gp)|*.3gp|(*.mov)|*.mov|(*.mpg)|*.mpg|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                answer_video.Text = openFileDialog1.FileName;
        }
        private void очиститьФотоВопросаToolStripMenuItem_Click(object sender, EventArgs e) { content_pic.Text = "Файл не выбран."; }
        private void очиститьВидеоВопросаToolStripMenuItem_Click(object sender, EventArgs e) { content_video.Text = "Файл не выбран."; }
        private void очиститьФотоОтветаToolStripMenuItem_Click(object sender, EventArgs e) { answer_pic.Text = "Файл не выбран."; }
        private void очиститьВидеоОтветаToolStripMenuItem_Click(object sender, EventArgs e) { answer_video.Text = "Файл не выбран."; }
        #endregion
    }
}
