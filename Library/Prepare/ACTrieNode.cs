using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library.Prepare
{
    public class ACTrieNode
    {
        public Dictionary<char, ACTrieNode> Children { get; } = new();

        public ACTrieNode Fail { get; set; }

        public List<MatchInfo> Matches { get; } = new();  

        public bool IsTerminal => Matches.Count > 0;
    }
}
