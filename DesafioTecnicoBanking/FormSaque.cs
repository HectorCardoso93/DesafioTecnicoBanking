﻿using DesafioTecnicoBanking.Objetos;
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
    public partial class FormSaque : Form
    {
        List<Conta> contas;
        private Form1 formPrincipal;
        public FormSaque(Form1 formPrincipal)
        {
            contas = new List<Conta>();
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        internal void SetTitulares(List<Conta> titulares)
        {
            foreach (var titular in titulares)
            {
                comboTitulares.Items.Add(titular);
                contas.Add(titular);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            int indice = comboTitulares.SelectedIndex;
            Conta selecionada = contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);

            selecionada.Saque(valor);
        }
    }
}
