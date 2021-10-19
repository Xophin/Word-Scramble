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
    public partial class ListEditor : Form
    {
        /* This form will handle adding, selecting, deleting, and editing lists.
         * It will take lists selected to go into rotation and merge them into one lists which gets sent back to ScrambleSolve.
         */

        // Default lists!
        List<Prompt> lstDefault = new List<Prompt>();
        List<Prompt> lstFarm = new List<Prompt>();

        public ListEditor()
        {
            InitializeComponent();

            // DefaultList stuff
            Prompt Moon = new Prompt("Moon", "Orbits the Earth");
            Prompt Soon = new Prompt("Soon", "In or after a short time.", "If its followed by (TM) you know its not happening anytime ____.");
            Prompt Loom = new Prompt("Loom", "An apparatus for making fabric by weaving yarn or thread.", "Weaver and their ____.");
            Prompt Craft = new Prompt("Craft", "The act of creating something.");
            Prompt Mine = new Prompt("Mine", "Digging in the ground for resources such as coal.", "It's not yours its ____.");
            Prompt Town = new Prompt("Town", "Larger than a village, smaller than a city.", "Just a small ____ girl Livin' in a lonely world");
            Prompt Cute = new Prompt("Cute", "attractive in a pretty or endearing way.", "As ____ as a kitten.");

            // Add prompts
            lstDefault.Add(Moon);
            lstDefault.Add(Soon);
            lstDefault.Add(Loom);
            lstDefault.Add(Craft);
            lstDefault.Add(Mine);
            lstDefault.Add(Town);
            lstDefault.Add(Cute);

            // FarmList stuff
            Prompt Barn = new Prompt("Barn", "A large building for animal housing or storage.");
            Prompt Coop = new Prompt("Coop", "A small building for housing poultry.", "When built freestanding, often has a method of closing it to keep predators from getting in.");
            Prompt Pasture = new Prompt("Pasture", "Outdoor pen with grass", "Land for grazing animals.");
            Prompt Stall = new Prompt("Stall", "An individual compartment for an animal in a stable or barn.");
            Prompt Hay = new Prompt("Hay", "Animal feed made from dried grass.", "Comes in bales.");
            Prompt Corn = new Prompt("Corn", "Grows on a stalk, commonly depicted as yellow.", "Starred in the horror movie Children of the ____");
            Prompt Cow = new Prompt("Cow", "Bovine that can be raised for milk or meat or both.", "Moo");
            Prompt Chicken = new Prompt("Chicken", "Poultry raised for meat or eggs.", "Known for being Kentucky Fried.", "Cluck");
            Prompt Sheep = new Prompt("Sheep", "Ovine raised for wool, meat, and/or milk.", "Has lambs, needs to be sheered.", "Baa");
            Prompt Horse = new Prompt("Horse", "The noble Equine, raised for running or working.", "Neigh");

            // Add prompts
            lstFarm.Add(Barn);
            lstFarm.Add(Coop);
            lstFarm.Add(Pasture);
            lstFarm.Add(Stall);
            lstFarm.Add(Hay);
            lstFarm.Add(Corn);
            lstFarm.Add(Cow);
            lstFarm.Add(Chicken);
            lstFarm.Add(Sheep);
            lstFarm.Add(Horse);
        }

        private void frmListSelector_Load(object sender, EventArgs e)
        {
            clbAvailableLists.Items.Add(new ListItem<List<Prompt>>("Default", lstDefault), true);
            clbAvailableLists.Items.Add(new ListItem<List<Prompt>>("Farm", lstFarm), false);

        }
    }
}
