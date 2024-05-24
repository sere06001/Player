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
        private void Winpopup()
        {
            if (XWin)
            {
                DialogResult result = MessageBox.Show("Starta ny match?", "X vann!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
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

            }
            else if (OWin)
            {
                MessageBox.Show("Starta ny match?", "O vann!", MessageBoxButtons.YesNo);
            }
            else if (Draw)
            {
                MessageBox.Show("Starta ny match?", "Lika!", MessageBoxButtons.YesNo);
            }
            XWin = false;
            OWin = false;
            Draw = false;
        }
        private void Win()
        {
            if (ruta1.Text=="X"&&ruta2.Text=="X"&&ruta3.Text=="X"||ruta1.Text=="X"&&ruta4.Text=="X"&&ruta7.Text=="X"||ruta2.Text=="X"&&ruta5.Text=="X"&&ruta8.Text=="X"||ruta3.Text=="X"&&ruta6.Text=="X"&&ruta9.Text=="X"||ruta1.Text=="X"&&ruta5.Text=="X"&&ruta9.Text=="X"||ruta3.Text=="X"&&ruta5.Text=="X"&&ruta7.Text=="X")
            { 
                XWin = true;
            }
            else if (ruta1.Text == "O" && ruta2.Text == "O" && ruta3.Text == "O" || ruta1.Text == "O" && ruta4.Text == "O" && ruta7.Text == "O" || ruta2.Text == "O" && ruta5.Text == "O" && ruta8.Text == "O" || ruta3.Text == "O" && ruta6.Text == "O" && ruta9.Text == "O" || ruta1.Text == "O" && ruta5.Text == "O" && ruta9.Text == "O" || ruta3.Text == "O" && ruta5.Text == "O" && ruta7.Text == "O")
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
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta1.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta1.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta2_Click(object sender, EventArgs e)
        {
            if (ruta2.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta2.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta2.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta3_Click(object sender, EventArgs e)
        {
            if (ruta3.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta3.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta3.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta4_Click(object sender, EventArgs e)
        {
            if (ruta4.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta4.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta4.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta5_Click(object sender, EventArgs e)
        {
            if (ruta5.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta5.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta5.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta6_Click(object sender, EventArgs e)
        {
            if (ruta6.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta6.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är X tur";
                ruta6.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta7_Click(object sender, EventArgs e)
        {
            if (ruta7.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta7.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta7.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta8_Click(object sender, EventArgs e)
        {
            if (ruta8.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta8.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta8.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void ruta9_Click(object sender, EventArgs e)
        {
            if (ruta9.Text != "")
            {

            }
            else if (Xtur)
            {
                label1.Text = "Det är X tur";
                ruta9.Text = "X";
                Xtur = false;
            }
            else
            {
                label1.Text = "Det är O tur";
                ruta9.Text = "O";
                Xtur = true;
            }
            Win();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
