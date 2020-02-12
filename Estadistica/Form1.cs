using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            lblRespuesta_Serie.Text = "X=" + objEstadistica.media(txtSerie.Text.Split(','));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {

        }
    }
}
