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
    public partial class FrmLoading : Form
    {
        private int exibir = 10;
        public FrmLoading()
        {
            InitializeComponent();
            //this.Height = Screen.PrimaryScreen.Bounds.Height;

            //this.Width = Screen.PrimaryScreen.Bounds.Width;

            //this.TopMost = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(exibir-- == 0)
            {
                Hide();
                timer1.Enabled = false;
                new FrmPrincipal().ShowDialog();
                Close();
            }
            buttonPular.Width = buttonPular.Width + 50;
            buttonPular.Text = (decimal.Parse(buttonPular.Text) + 10).ToString();
        }

        private void ButtonPular_Click(object sender, EventArgs e)
        {
            exibir = 0;
        }
    }
}
