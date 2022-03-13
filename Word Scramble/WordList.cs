using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scramble
{
    class WordList
    {
       /*This stores a List of ListItems.
        ListItem holds the name of a list of Words, and the list of Words.
        A Word contains a word (to be scramble, unscrambled) and its Hints. */
        public string strListName { get; set; }
        public List<List<Word>> lstWordList { get; set; } = new List<List<Word>>();

    }
}
