using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryApp
{
    public partial class MantEditorial : Form
    {
        public int ex;
        public MantEditorial()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ex = 1;
            Princi inicio = Princi.Instancia;
            inicio.Show();
            this.Hide();
        }

        private void MantEditorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ex == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

        private void btnAddEdito_Click(object sender, EventArgs e)
        {
            ex = 1;
            AddEditorialles edito = new AddEditorialles();
            edito.Show();
            this.Close();
        }

        private void btnListarEdito_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarEditorial List = new ListarEditorial();
            List.Show();
            this.Close();
        }

        private void btnDeletEdito_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarEditorial List = new ListarEditorial();
            List.Show();
            this.Close();
        }

        private void btnEditEdito_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarEditorial List = new ListarEditorial();
            List.Show();
            this.Close();
        }
    }
}
