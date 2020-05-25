using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameMed {
    [Serializable]
    public class Question {
        public string name { get; set;}
        public string content_text { get; set; }
        public string content_pic { get; set; }
        public string content_video { get; set; }
        public string answer_text { get; set; }
        public string answer_pic { get; set; }
        public string answer_video { get; set; }
        public int point { get; set; }
        public int status { get; set; }
        public int time { get; set; }
        public string category { get; set; }
    }
}
