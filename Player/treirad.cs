using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class treirad : Form
    {
        private bool Xtur = true;
        private bool XWin = false;
        private bool OWin = false;
        private bool Draw = false;

        public treirad()
        {
            InitializeComponent();

        }

        private void treirad_Load(object sender, EventArgs e)
        {

        }
        private void Resetgrid()
        {
            ruta1.Text = "";
            ruta2.Text = "";
            ruta3.Text = "";
            ruta4.Text = "";
            ruta5.Text = "";
            ruta6.Text = "";
            ruta7.Text = "";
            ruta8.Text = "";
            ruta9.Text = "";
        }
        private void Deactivategrid()
        {
            ruta1.Enabled = false;
            ruta2.Enabled = false;
            ruta3.Enabled = false;
            ruta4.Enabled = false;
            ruta5.Enabled = false;
            ruta6.Enabled = false;
            ruta7.Enabled = false;
            ruta8.Enabled = false;
            ruta9.Enabled = false;
        }
        private void Activategrid()
        {
            ruta1.Enabled = true;
            ruta2.Enabled = true;
            ruta3.Enabled = true;
            ruta4.Enabled = true;
            ruta5.Enabled = true;
            ruta6.Enabled = true;
            ruta7.Enabled = true;
            ruta8.Enabled = true;
            ruta9.Enabled = true;
        }
        private void Vemstur(Button button)
        {
            if (Xtur)
            {
                label1.Text = "Det är O tur";
                Xtur = false;
                button.Text = "X";
            }
            else
            {
                label1.Text = "Det är X tur";
                Xtur = true;
                button.Text = "O";
            }
        }
        private void Winpopup()
        {
            if (XWin)
            {
                label1.Text = "X vann!";
                DialogResult result = MessageBox.Show("Starta ny match?", "X vann!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Resetgrid();
                    Xtur = true;
                    label1.Text = "Det är X tur";
                }
                else
                {
                    
                    Deactivategrid();
                }
            }
            else if (OWin)
            {
                label1.Text = "O vann!";
                DialogResult result = MessageBox.Show("Starta ny match?", "O vann!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Resetgrid();
                    Xtur = true;
                    label1.Text = "Det är X tur";
                }
                else
                {
                    Deactivategrid();
                }
            }
            else if (Draw)
            {
                label1.Text = "Lika!";
                DialogResult result = MessageBox.Show("Starta ny match?", "Lika!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Resetgrid();
                    Xtur = true;
                    label1.Text = "Det är X tur";
                }
                else
                {
                    
                    Deactivategrid();
                }
            }
            XWin = false;
            OWin = false;
            Draw = false;
        }
        private void Win()
        {
            if (ruta1.Text == "X" && ruta2.Text == "X" && ruta3.Text == "X" || ruta4.Text == "X" && ruta5.Text == "X" && ruta6.Text == "X" || ruta7.Text == "X"&& ruta8.Text == "X" && ruta9.Text == "X" || ruta1.Text == "X" && ruta4.Text == "X" && ruta7.Text == "X" || ruta2.Text == "X" && ruta5.Text == "X" && ruta8.Text == "X" || ruta3.Text == "X" && ruta6.Text == "X" && ruta9.Text == "X" || ruta1.Text == "X" && ruta5.Text == "X" && ruta9.Text == "X" || ruta3.Text == "X" && ruta5.Text == "X" && ruta7.Text == "X")
            {
                XWin = true;
            }
            else if (ruta1.Text == "O" && ruta2.Text == "O" && ruta3.Text == "O" || ruta4.Text == "O" && ruta5.Text == "O" && ruta6.Text == "O" || ruta7.Text == "O" && ruta8.Text == "O" && ruta9.Text == "O" || ruta1.Text == "O" && ruta4.Text == "O" && ruta7.Text == "O" || ruta2.Text == "O" && ruta5.Text == "O" && ruta8.Text == "O" || ruta3.Text == "O" && ruta6.Text == "O" && ruta9.Text == "O" || ruta1.Text == "O" && ruta5.Text == "O" && ruta9.Text == "O" || ruta3.Text == "O" && ruta5.Text == "O" && ruta7.Text == "O")
            {
                OWin = true;
            }
            else if (ruta1.Text != "" && ruta2.Text != "" && ruta3.Text != "" && ruta4.Text != "" && ruta5.Text != "" && ruta6.Text != "" && ruta7.Text != "" && ruta8.Text != "" && ruta9.Text != "")
            {
                Draw = true;

            }
            Winpopup();
        }

        private void ruta1_Click(object sender, EventArgs e)
        {
            if (ruta1.Text != "")
            {

            }
            else
            {
                Vemstur(ruta1);
            }
            Win();
        }

        private void ruta2_Click(object sender, EventArgs e)
        {
            if (ruta2.Text != "")
            {

            }
            else
            {
                Vemstur(ruta2);
            }
            Win();
        }

        private void ruta3_Click(object sender, EventArgs e)
        {
            if (ruta3.Text != "")
            {

            }
            else
            {
                Vemstur(ruta3);
            }
            Win();
        }

        private void ruta4_Click(object sender, EventArgs e)
        {
            if (ruta4.Text != "")
            {

            }
            else
            {
                Vemstur(ruta4);
            }
            Win();
        }

        private void ruta5_Click(object sender, EventArgs e)
        {
            if (ruta5.Text != "")
            {

            }
            else
            {
                Vemstur(ruta5);
            }
            Win();
        }

        private void ruta6_Click(object sender, EventArgs e)
        {
            if (ruta6.Text != "")
            {

            }
            else
            {
                Vemstur(ruta6);
            }
            Win();
        }

        private void ruta7_Click(object sender, EventArgs e)
        {
            if (ruta7.Text != "")
            {

            }
            else
            {
                Vemstur(ruta7);
            }
            Win();
        }

        private void ruta8_Click(object sender, EventArgs e)
        {
            if (ruta8.Text != "")
            {

            }
            else
            {
                Vemstur(ruta8);
            }
            Win();
        }

        private void ruta9_Click(object sender, EventArgs e)
        {
            if (ruta9.Text != "")
            {

            }
            else
            {
                Vemstur(ruta9);
            }
            Win();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tillbakabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Välj_spel f1 = new Välj_spel();
            f1.Show();
        }

        private void nymatchbtn_Click(object sender, EventArgs e)
        {
            Resetgrid();
            Activategrid();
            Xtur = true;
            label1.Text = "Det är X tur";
        }
    }
}
