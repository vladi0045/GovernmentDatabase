using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positionsBtn_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new PositionsForm();
            positionsForm.ShowDialog();
        }

        private void partiesBtn_Click(object sender, EventArgs e)
        {
            PartiesForm partiesForm = new PartiesForm();
            partiesForm.ShowDialog();
        }

        private void politiciansBtn_Click(object sender, EventArgs e)
        {
            PoliticiansForm politiciansForm = new PoliticiansForm();
            politiciansForm.ShowDialog();
        }
    }
}
