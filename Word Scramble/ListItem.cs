using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Scramble
{
    public class ListItem<ItemType>
    {
        // Allows for a wordlist to be displayed in a CheckBox
        public string DisplayText { get; set; }
        public ItemType Value { get; set; }

        public ListItem(string displaytext, ItemType value)
        {
            DisplayText = displaytext;
            Value = value;
        }

        public override string ToString()
        {
            return DisplayText.ToString();
        }
    }
}
