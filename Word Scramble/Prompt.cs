using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scramble
{
    class Prompt
    {
        // auto implmented properties
        public string Original { get; set; }
        public string Hint1 { get; set; }
        public string Hint2 { get; set; }
        public string Hint3 { get; set; }

        // Constructors
        public Prompt()
        {
            Original = " ";
            Hint1 = "Uh-oh! Someone forgot to add a prompt and hint.";
        }
       
        public Prompt(string original)
        {
            Original = original;;
        }
        
        public Prompt(string original, string hint1)
        {
            Original = original;
            Hint1 = hint1;
        }

        public Prompt(string original, string hint1, string hint2)
        {
            Original = original;
            Hint1 = hint1;
            Hint2 = hint2;
        }

        public Prompt(string original, string hint1, string hint2, string hint3)
        {
            Original = original;
            Hint1 = hint1;
            Hint2 = hint2;
            Hint3 = hint3;
        }
    }
}
