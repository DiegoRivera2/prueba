using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button btnGualterPistola;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn111;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn222;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnOla;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor=Color.Chocolate;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Aquamarine;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Goldenrod;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.BlueViolet;
        }
        
        private void btn5_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor= Color.Green;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Gray;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Orchid;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Khaki;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Salmon;
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Navy;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor=Color.Azure;
        }

        private void btn222_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Lime;
        }

        private void btnGualterPistola_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2();
            
            ventana.Show();
        }
        
    }
}