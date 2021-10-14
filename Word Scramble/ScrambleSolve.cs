using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Scramble
{
    public partial class frmScrambleSolve : Form
    {
        // Default List!
        List<Prompt> lstDefaultList = new List<Prompt>();

        Random random = new Random();
        String strOriginalWord = "";

        public frmScrambleSolve()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Create the initial List of words.
            Prompt Moon = new Prompt("Moon", "Orbits the Earth");
            Prompt Soon = new Prompt("Soon", "In or after a short time.", "If its followed by (TM) you know its not happening anytime ____.");
            Prompt Loom = new Prompt("Loom", "An apparatus for making fabric by weaving yarn or thread.", "Weaver and their ____.");
            Prompt Craft = new Prompt("Craft", "The act of creating something.");
            Prompt Mine = new Prompt("Mine", "Digging in the ground for resources such as coal.", "It's not yours its ____.");
            Prompt Town = new Prompt("Town", "Larger than a village, smaller than a city.", "Just a small ____ girl Livin' in a lonely world");
            Prompt Cute = new Prompt("Cute", "attractive in a pretty or enduring way.", "As ____ as a kitten.");

            // Add default prompts to default list
            lstDefaultList.Add(Moon);
            lstDefaultList.Add(Soon);
            lstDefaultList.Add(Loom);
            lstDefaultList.Add(Craft);
            lstDefaultList.Add(Mine);
            lstDefaultList.Add(Town);
            lstDefaultList.Add(Cute);
        }

        private void btnStartScramble_Click(object sender, EventArgs e)
        {
            // This will randomly pick a word from the word list then send it through the scrambler.
            String strScrambledWord = "";
            int intWordListLength = 0;
            int intSelectedWordIndex = 0;

            // Check how long the list is.
            for (int i = 0; i < lstDefaultList.Count; i++)
            {
                intWordListLength = i;
            }
            
            if(intWordListLength <= 0)
            {
                MessageBox.Show("There are no words in the word list. Please add words to the word list before trying to scramble.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pick a random word from the List
                intSelectedWordIndex = random.Next(-1, intWordListLength);

                strOriginalWord = lstDefaultList[intSelectedWordIndex].Original;

                // Check string length
                if(strOriginalWord.Length > 0)
                {
                    // Get scrambled version of word
                    strScrambledWord = Scrambler(strOriginalWord, strOriginalWord.Length);

                    // Change the label text for the scrambled word to the scrambled word.
                    lblScrambledWord.Text = strScrambledWord;

                }
                else
                {
                    MessageBox.Show("The word selected had no characters.  Word selected was at index " + intSelectedWordIndex.ToString() + " of list lstWordsToScramble", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtAnswer.Text == strOriginalWord)
            {
                MessageBox.Show("Success! You unscrambled the word correctly.", "Success", MessageBoxButtons.OK);
                lblScrambledWord.Text = "";
                txtAnswer.Text = "";
                // add counter for correct answers here.
                // Maybe something for tries?
                // Would need class level variable.
            }
            else
            {
                MessageBox.Show("Incorrect. That is not the word. Please try again.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String Scrambler(String strOriginalWord, int intWordLength)
        {
            // Takes in a word, uses Random class to shuffle the word, then passes the shuffled word out.
            // Code comes from a comment by user nan on stackoverflow with minor edit.
            // edits include: changing a var out for a char. 
            char chrSwap = ' ';
            char[] chrScramble;
            int intFirstIndex = 0;
            int intCharacterCount = intWordLength;
            int intScrambleIndex = 0;
            int intShuffleCount = 200;

            // Converts string to character array for easier manipulation.
            chrScramble = strOriginalWord.ToCharArray(0, intWordLength);

            // Shuffle the word multiple times.
            while(intShuffleCount > 1)
            {
                intShuffleCount--;
                intCharacterCount = intWordLength;
                while (intCharacterCount > 1)
                {
                    // We move backwards through the original word.
                    intCharacterCount--;
                    // grabbing the index of the first character to shuffle.
                    intScrambleIndex = random.Next(intCharacterCount + 1);
                    // grabbing the first character to shuffle
                    chrSwap = chrScramble[intScrambleIndex];
                    // Shuffle! We replace the character that we saved off into chrSwap with the one from from where chrSwap will go
                    chrScramble[intScrambleIndex] = chrScramble[intCharacterCount];
                    // putting chrSwap back into the array.
                    chrScramble[intCharacterCount] = chrSwap;
                }
            }
            
            // Return the Scrambled word as a String.
            String strScrambledWord = new string(chrScramble);
            return strScrambledWord;
        }
    }
}
