using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistoConsultaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Inserir()
        {
            MessageBox.Show("Inserir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }



        private void Limpar()
        {
            MessageBox.Show("Limpar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }



        private void Consultar()
        {
            MessageBox.Show("Consultar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void toolStripBtn1_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        private void toolStripBtn2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void toolStripBtn3_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
