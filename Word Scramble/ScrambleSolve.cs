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
        // Create the initial List of words.
        List<String> lstDefaultList = new List<String>() { "Moon", "Soon", "Loom", "Craft", "Mine", "Town", "Cute", "Cozy", "Quail", "Quilt", "Lost", "Shoe" };
        Random random = new Random();
        String strOriginalWord = "";

        public frmScrambleSolve()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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

                strOriginalWord = lstDefaultList[intSelectedWordIndex];

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
