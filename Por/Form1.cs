using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Por
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trbRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = "สีแดง = " + trbRed.Value.ToString();
            lblRed.BackColor = Color.FromArgb(trbRed.Value, 0, 0);
            UpdateColor();
        }

        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = "สีเขียว = " + trbGreen.Value.ToString();
            lblGreen.BackColor = Color.FromArgb(0, trbGreen.Value, 0);
            UpdateColor();
        }

        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = "สีน้ำเงิน = " + trbBlue.Value.ToString();
            lblBlue.BackColor = Color.FromArgb(0, 0, trbBlue.Value);
            UpdateColor();
        }

        private void UpdateColor()
        {
            txtResult.BackColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRed.ForeColor = Color.White;
            lblGreen.ForeColor = Color.White;
            lblBlue.ForeColor = Color.White;
            UpdateColor();
        }

        private void lblRed_Click(object sender, EventArgs e)
        {

        }

        private void lblGreen_Click(object sender, EventArgs e)
        {

        }

        private void lblBlue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
