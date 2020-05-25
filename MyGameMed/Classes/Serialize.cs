using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameMed {
    [Serializable]
    public class Serialize {
        public List<Categories> cat { get; set;}
        public List<Question> que { get; set; }
    }
}
