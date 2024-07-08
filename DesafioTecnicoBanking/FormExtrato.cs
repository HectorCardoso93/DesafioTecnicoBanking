using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioTecnicoBanking
{
    public partial class FormExtrato : Form
    {
        private Form1 formPrincipal;
        public FormExtrato(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
