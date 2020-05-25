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
using System.Diagnostics;

namespace MyGameMed {
    public partial class Game : UserControl {
        public List<Question> que = new List<Question>();
        public List<Categories> cat = new List<Categories>();

        Game_Categories cat_select;
        Game_Questions que_select;
        Game_Qestion quest;
        Game_Answer g_a;
        Game_Finish g_f;

        Serialize s;
        FileStream fs;
        BinaryFormatter formatter;

        public static Game selfref_g {get; set;}

        public Game(string file) {
            InitializeComponent();
            selfref_g = this;
            load_is_file(file);
            curect_path_content(file);
            open_game_category();
        }
        public Game(bool save) {
            InitializeComponent();
            selfref_g = this;
            load_is_file("save.sv");
            open_game_category();
        }
        public void open_game_category() {
            Controls.Clear();
            if (cat_select != null) cat_select = null;
            GC.Collect();
            cat_select = new Game_Categories();
            cat_select.Dock = DockStyle.Fill;
            Controls.Add(cat_select);
            Controls.SetChildIndex(cat_select, 0);
        }
        public void open_game_questions(string name_cat) {
            Controls.Clear();
            if (que_select != null)  que_select = null;
            GC.Collect();
            
            que_select = new Game_Questions(name_cat);
            que_select.Dock = DockStyle.Fill;
            Controls.Add(que_select);
            Controls.SetChildIndex(que_select, 0);
        }
        public void open_game_question(string name, string cat) {
            Controls.Clear();
            if (quest != null) quest = null;
            GC.Collect();

            quest = new Game_Qestion(name, cat);
            quest.Dock = DockStyle.Fill;
            Controls.Add(quest);
            Controls.SetChildIndex(quest, 0);
        }
        public void open_game_answer(string name, string cat) {
            Controls.Clear();
            if (g_a != null) g_a = null;
            GC.Collect();
            
            g_a = new Game_Answer(name, cat);
            g_a.Dock = DockStyle.Fill;
            Controls.Add(g_a);
            Controls.SetChildIndex(g_a, 0);
        }
        public void open_game_finish() {
            Controls.Clear();
            if (g_f != null)  g_f = null;
            GC.Collect();
            
            g_f = new Game_Finish();
            g_f.Dock = DockStyle.Fill;
            Controls.Add(g_f);
            Controls.SetChildIndex(g_f, 0);
        }
        public void save_to_file(string path) {
            s = new Serialize();
            s.cat = cat;
            s.que = que;
            formatter = new BinaryFormatter();
            using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None)) {
                formatter.Serialize(fStream, s);
                fStream.Close();
            }
        }
        public void load_is_file(string path) {
            if (File.Exists(path)) {
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                long size = file.Length;
                if (size > 0) {
                    fs = new FileStream(path, FileMode.Open);
                    formatter = new BinaryFormatter();
                    s = new Serialize();
                    s = (Serialize)formatter.Deserialize(fs);
                    cat = s.cat;
                    que = s.que;
                    fs.Close();
                    que.Sort((p1, p2) => p1.point.CompareTo(p2.point));
                }
            }
        }
        void curect_path_content(string file) {
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file)))
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file));
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image"))
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image");
            string path_pic = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "image";
            if (!Directory.Exists(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video"))
                Directory.CreateDirectory(Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video");
            string path_video = Path.GetDirectoryName(file) + @"\" + Path.GetFileNameWithoutExtension(file) + @"\" + "video";
            for (int i = 0; i < que.Count; i++) {
                if(!String.IsNullOrEmpty(que[i].content_pic) && que[i].content_pic != "Файл не выбран.") que[i].content_pic = path_pic + @"\" + que[i].content_pic;
                if (!String.IsNullOrEmpty(que[i].content_video) && que[i].content_video != "Файл не выбран.") que[i].content_video = path_video + @"\" + que[i].content_video;
                if (!String.IsNullOrEmpty(que[i].answer_pic) && que[i].answer_pic != "Файл не выбран.") que[i].answer_pic = path_pic + @"\" + que[i].answer_pic;
                if (!String.IsNullOrEmpty(que[i].answer_video) && que[i].answer_video != "Файл не выбран.") que[i].answer_video = path_video + @"\" + que[i].answer_video;
            }
        }
    }
}
