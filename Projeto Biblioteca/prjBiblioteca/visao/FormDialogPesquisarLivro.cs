﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBiblioteca.visao
{

    public partial class FormDialogPesquisarLivro : Form
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public FormDialogPesquisarLivro()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (lbLivro.Text.Equals(""))
            {
                MessageBox.Show("Selecione um aluno válido");
            }
            else
            {
                Dispose();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Id = Int16.Parse(dg.CurrentRow.Cells[0].Value.ToString());
                lbLivro.Text = dg.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                this.Id = 0;
                txtNome.Text = "";
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            controle.LivroDB lDB = new controle.LivroDB();
            lDB.filtrar(dg, txtNome.Text);
        }
    }
}
