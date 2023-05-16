using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Definir nosso métodos
        //Método: Atualizar Cores
        private void AtualizarCores()
        {
            lbl_paleta.BackColor = Color.FromArgb(
                RedScrollBar.Value,
                GreenScrollBar.Value,
                BlueScrollBar.Value
                );
            lblContRed.Text = RedScrollBar.Value.ToString();
            lblContGreen.Text = GreenScrollBar.Value.ToString();
            lblContBlue.Text = BlueScrollBar.Value.ToString();
        }

        private void RedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            AtualizarCores();
        }

        private void BlueScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            AtualizarCores();
        }

        private void GreenScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            AtualizarCores();
        }
    }
}
