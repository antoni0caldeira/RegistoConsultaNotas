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
    public partial class fmrConsulta : Form
    {
        public fmrConsulta()
        {
            InitializeComponent();
        }

        private void bntRegisto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
