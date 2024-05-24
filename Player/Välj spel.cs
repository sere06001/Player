using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Välj_spel : Form
    {
        public Välj_spel()
        {
            InitializeComponent();
        }

        private void treiradbtn_Click(object sender, EventArgs e)
        {
            treirad treirad = new treirad();
            this.Hide();
            treirad.Show();
        }

        private void minesweeperbtn_Click(object sender, EventArgs e)
        {
            Minesweeper minesweeper = new Minesweeper();
            this.Hide();
            minesweeper.Show();
        }
    }
}
