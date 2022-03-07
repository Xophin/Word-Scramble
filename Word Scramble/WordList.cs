using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scramble
{
    class WordList
    {
        // This stores a list of Words.
        public string strListName { get; set; }
        public List<List<Word>> lstWordList { get; set; } = new List<List<Word>>();

    }
}
