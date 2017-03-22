using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cake_Factory_New
{
    public partial class Form1 : Form
    {
        RoundCake round;
        Square square;

        public Form1()
        {
            InitializeComponent();

            square = new Square(txtCakeWriting.Text, txtCakeWriting.TextLength,
                (int) nudSizeSquare.Value, 
                chbChocoIcingSquare.Checked,
                dtpSquare.Value);

            round = new RoundCake(chbFruitOption.Checked, (int)nudSizeRound.Value,
               chbChocoIceRound.Checked,
               dtpRound.Value);

            DisplayCostRound();
            DisplayCostSquare();
        }

        private void DisplayCostRound() 
        {
            decimal total = 0;
            total = round.CalculateTotalCost();
            lblCostRound.Text = total.ToString("c");
        }

        private void DisplayCostSquare() 
        { 
            decimal total = 0;
            total = square.CalculateTotalCost();
            lblCostSquare.Text = total.ToString("c");
        }

        private void nudSizeRound_ValueChanged(object sender, EventArgs e)
        {
            round.OrderSize = (int)nudSizeRound.Value;
            DisplayCostRound();
        }

        private void chbChocoIceRound_CheckedChanged(object sender, EventArgs e)
        {
            round.ChocoIce = chbChocoIceRound.Checked;
            DisplayCostRound();
        }

        private void chbFruitOption_CheckedChanged(object sender, EventArgs e)
        {
            round.FruitOption = chbFruitOption.Checked;
            DisplayCostRound();
        }

        private void btnSaveRound_Click(object sender, EventArgs e)
        {
            lstCakes.Items.Add(round);
            DisplayCostRound();
        }

        private void nudSizeSquare_ValueChanged(object sender, EventArgs e)
        {
            square.OrderSize = (int)nudSizeSquare.Value;
            DisplayCostSquare();
        }

        private void chbChocoIcingSquare_CheckedChanged(object sender, EventArgs e)
        {
            square.ChocoIce = chbChocoIcingSquare.Checked;
            DisplayCostSquare();
        }

        private void txtCakeWriting_TextChanged(object sender, EventArgs e)
        {
            square.CakeWriting = txtCakeWriting.Text;
            DisplayCostSquare();
        }

        private void btnSaveSquare_Click(object sender, EventArgs e)
        {
            lstCakes.Items.Add(square);
            DisplayCostSquare();
        }
    }
}
