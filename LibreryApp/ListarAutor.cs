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
    public partial class ListarAutor : Form
    {
        public static ListarAutor Instancia = new ListarAutor();

        ServicioAutores Servicio;
        public int idA;
        public int ep;
      


        public ListarAutor()
        {
            InitializeComponent();
        
            Servicio = new ServicioAutores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
           Delete();
            LoadV();
        }

        private void VewAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idA = e.RowIndex;
            }
        }

        private void ListarAutor_Load(object sender, EventArgs e)
        {
            LoadV();
        }


        private void Atras_Click(object sender, EventArgs e)
        {
            ep = 1;
            MantAutores man = new MantAutores();
            man.Show();
            this.Close();
        }

        private void ListarAutor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void VewAutores_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void ListarAutor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ep == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

         private void Delete()
        {
            if (idA >= 0)
            {
                DialogResult response = MessageBox.Show("Estas Seguro que quieres eliminar este Autor",
                  "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    Servicio.RemoveA(idA);
                }

            }
            else
            {
                MessageBox.Show("Selecciona el contacto que deseas eliminar");
            }
        }
        private void LoadV()
        {
            VewAutores.Rows.Clear();
            foreach (Autores Item in Repositorio.Instancia.Autores)
            {
                VewAutores.Rows.Add(Item.NameAutor, Item.Correo);
            }
        }
        public void Edit()
        {
            if (idA >= 0)
            {
                ep = 1;
                EditAutores edit = new EditAutores();
                edit.idR = idA;
                edit.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("debe seleccionar el campo que desea editar");
            }

        }
    }
}
