using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDeSO_1
{
    public partial class FrmUmCampoGenerico : Form
    {
        public string Descricao { get; set; } = "Descrição";
        public string Valor { get; set; } = "0";
        public FrmUmCampoGenerico()
        {
            InitializeComponent();
            txtValor.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtValor.Text.Trim().Equals(string.Empty))
                {
                    throw new Exception("O Campo não pode ser vazio!");
                }

                decimal aux;
                if (!decimal.TryParse(txtValor.Text,out aux))
                {
                    throw new Exception("Digite apenas numeros!");
                }

                if (aux < 0)
                {
                    throw new Exception("Digite um número maior do que zero!");
                }

                Valor = txtValor.Text;
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistemas Operacionais", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
            }
        }

        private void FrmUmCampoGenerico_Load(object sender, EventArgs e)
        {
            txtValor.Text = Valor;
            labelDescricao.Text = Descricao;
        }

        private void FrmUmCampoGenerico_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnOk_Click(null, null);
        }


        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnOk_Click(null, null);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
        }
    }
}
