using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID", "Histórico");
        }



        private void btnCalc_Click(object sender, EventArgs e)
        {

           
            double altura = double.Parse(txtAltura.Text);
            double peso = double.Parse(txtPeso.Text);
            double IMC = Math.Round(peso / (altura * altura));
            string texto = "Seu IMC é: ";
            txtResultado.Text = texto + IMC;




            dataGridView1.Rows.Add(txtResultado.Text);


        }
    }
}
