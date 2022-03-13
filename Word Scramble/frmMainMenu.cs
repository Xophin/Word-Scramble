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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnWordScramble_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmScrambleSolve = new ScrambleSolve();
                frmScrambleSolve.ShowDialog();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnListEditor_Click(object sender, EventArgs e)
        {
            try
            {
                Form fListEdit = new ListEditor();
                fListEdit.ShowDialog();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
