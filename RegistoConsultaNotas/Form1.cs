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
    public partial class frmRegisto : Form
    {

        // Variáveis globais
        string[] Nomes = new string[10];
        int[,] DisciplinaNotas = new int[10, 3];
        int registo = 0;

        public frmRegisto()
        {
            InitializeComponent();
        }




        private void Inserir()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Indique o Nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (registo >= 10)
            {
                MessageBox.Show("Array completo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nomes[registo] = txtNome.Text;
            DisciplinaNotas[registo, 0] = (int)nudPortugues.Value;
            DisciplinaNotas[registo, 1] = (int)nudMatematica.Value;
            DisciplinaNotas[registo, 2] = (int)nudTIC.Value;
            registo++;
            Limpar();
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
