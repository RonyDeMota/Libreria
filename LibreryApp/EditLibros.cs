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
    public partial class EditLibros : Form
    {
        public int idL;
        ServicioLibro Servicio;
        public EditLibros()
        {
            InitializeComponent();
         
            Servicio = new ServicioLibro();
        }
        private void btnGuardLibro_Click(object sender, EventArgs e)
        {
            EditContact();
            this.Close();
        }

        private void LoadEdit()
        {
            Libros eas = Servicio.GetbyIdL(idL);

            TxtNameLibro.Text = eas.NameLibro;
            TxtAnLibro.Text = eas.Date;
            CbxAutor.Text = (string)eas.Autor;
            foreach (var i in Repositorio.Instancia.Autores)
            {
                _ = CbxAutor.Items.Add(i.NameAutor);
            }
            foreach (var i in Repositorio.Instancia.Editoriales)
            {
                _ = CbxEditorial.Items.Add(i.NameEditorial);
            }
            CbxEditorial.Text = (string)eas.Editorial;
        }
        public void EditContact()
        {
            Libros eass = new Libros(TxtNameLibro.Text, TxtAnLibro.Text, CbxAutor.Text, CbxEditorial.Text);
            Servicio.EditL(idL, eass);
            eass.NameLibro = TxtNameLibro.Text;
            eass.Date = TxtAnLibro.Text;
            eass.Autor = CbxAutor.SelectedIndex;
            eass.Editorial = CbxEditorial.SelectedIndex;
        }
        private void EditLibros_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }

        private void EditLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarLibros listar = new ListarLibros();
            listar.Show();
        }

        private void BtnCancelLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
