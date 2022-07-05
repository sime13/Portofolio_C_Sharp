using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0, PesoIdeal = 0;
                Altura = double.Parse(txtAltura.Text);

                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + "Seu peso Ideal é : " + PesoIdeal.ToString() + "KG", "Peso Ideal ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + "Seu peso Ideal é : " + PesoIdeal.ToString() + "KG", "Peso Ideal ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Escholha o Sexo ", "Peso Ideal ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informado", "Peso ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Update();
            txtAltura.Update();
            cmbSexo.Text = " ";
            txtNome.Focus();

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
