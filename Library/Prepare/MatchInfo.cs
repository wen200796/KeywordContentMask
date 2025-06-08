using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Prepare
{
    public class MatchInfo
    {
        public string Keyword { get; set; }

        public List<Rule> Rules { get; set; } = new();

        public int Weight { get; set; }
    }
}
