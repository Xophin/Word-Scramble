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
            Original = "Word";
            Hint1 = "Uh-oh! Someone forgot to add a prompt and hint. We added Word for you.";
            Hint2 = "The answer is Word.";
            Hint3 = "Did you know you can add three hints per prompt? have fun!";
        }
       
        public Prompt(string original)
        {
            Original = original;
            Hint1 = "Uh-oh! Someone forgot to add a hint.";
        }
        
        public Prompt(string original, string hint1)
        {
            Original = original;
            Hint1 = "First and final hint: " + hint1;
        }

        public Prompt(string original, string hint1, string hint2)
        {
            Original = original;
            Hint1 = "First Hint: " + hint1;
            Hint2 = "Second and last Hint: " + hint2;
        }

        public Prompt(string original, string hint1, string hint2, string hint3)
        {
            Original = original;
            Hint1 = "First Hint: " + hint1;
            Hint2 = "Second: " + hint2;
            Hint3 = "Third and final hint: " + hint3;
        }
    }
}
