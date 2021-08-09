using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibreryApp
{
    public partial class MantLibros : Form
    {
        public int ex;
        public MantLibros()
        {
            InitializeComponent();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ex = 1;
            Princi inicio = Princi.Instancia;
            inicio.Show();
            this.Hide();
        }

        private void MantLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ex == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ex = 1;
            AddLibros lib = new AddLibros();
            lib.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarLibros lib = new ListarLibros();
            lib.Show();
            this.Close();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarLibros lib = new ListarLibros();
            lib.Show();
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarLibros lib = new ListarLibros();
            lib.Show();
            this.Close();
        }
    }
}
