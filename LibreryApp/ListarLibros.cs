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
    public partial class ListarLibros : Form
    {
        ServicioLibro Servicio;
        public int IdK;
        public int ep;
        public bool edit;
        public bool borr;

        public ListarLibros()
        {
            InitializeComponent();

            Servicio = new ServicioLibro();
        }

        private void ViewLibros_VisibleChanged(object sender, EventArgs e)
        {


        }

        private void ListarLibros_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ep = 1;
            MantLibros Man = new MantLibros();
            Man.Show();
            this.Close();
        }

        private void ViewLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
        }

        private void ListarLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
            ViewLibros.ClearSelection();
        }

        private void ViewLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdK = e.RowIndex;
            }
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            Edit();

        }

       private void Edit()
        {
            if (IdK >= 0)
            {
                ep = 1;
                EditLibros edit = new EditLibros();
                edit.idL = IdK;
                edit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el campo que desea editar");
            }
        }

        private void DeleteContact()
        {
            if (IdK >= 0)
            {
                DialogResult response = MessageBox.Show("Estas Seguro que quieres eliminar este Libro",
                  "Advertencia", MessageBoxButtons.OKCancel);
                if (response == DialogResult.OK)
                {
                    Servicio.RemoveL(IdK);
                }

            }
            else
            {
                MessageBox.Show("Selecciona el contacto que deseas eliminar");
            }
        }



        private void CargarLibros()
        {
            ViewLibros.Rows.Clear();
            foreach (Libros Item in Repositorio.Instancia.Libros)
            {
                ViewLibros.Rows.Add(Item.NameLibro, Item.Date, Item.Autor, Item.Editorial);
            }
        }
        private void eyyy()
        {
            
        }

        private void ListarLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ep == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }
    }
}
