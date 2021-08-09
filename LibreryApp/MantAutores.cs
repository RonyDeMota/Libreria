using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace LibreryApp
{
    public partial class MantAutores : Form
    {
        public int ex;
        object ppp;
        public MantAutores()
        {
            InitializeComponent();
        }
       

        private void btnAutorDelet_Click(object sender, EventArgs e)
        {
            eppp = 1;
            ex = 1;
            ListarAutor lisAut = new ListarAutor();
            lisAut.Show();
            this.Close();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ex = 1;
            Princi inicio = Princi.Instancia;
            inicio.Show();
            this.Hide();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MantAutores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ex == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

        private void btnAutorAdd_Click(object sender, EventArgs e)
        {
            ex = 1;
            
            AddAutores aut = new AddAutores();
            aut.Show();
            this.Close();
        }

        private void btnAutorListar_Click(object sender, EventArgs e)
        {
            ex = 1;
            ListarAutor lisAut = new ListarAutor();
            lisAut.Show();
            this.Close();
        }

        private void btnAutorEdit_Click(object sender, EventArgs e)
        { 
            ex = 1;
            eyyy();
            ListarAutor lisAut = new ListarAutor();
            lisAut.Show();
            this.Close();
        } public int eppp;
          private void eyyy()
        {
            ListarLibros Lib = new ListarLibros();
            if
              (btnAutorEdit.Text == "Borrar")
            {
                Lib.borr = true;
            } else
            {
                Lib.borr = false;
            }
        }
    }

}
