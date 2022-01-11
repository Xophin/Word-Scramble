using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scramble
{
    public class Word
    {
        // auto implmented properties
        public string strWord { get; set; }

        // hints are being turned into a list of strings for flexibility.
        public List<string> lstHints { get; set; } = new List<string>();
        

        // Constructors
        public Word()
        {
            strWord = " ";
        }
       
        public Word(string original)
        {
            strWord = original;
        }
        
        public Word(string original, string hint1)
        {
            strWord = original;
        }
    }
}
