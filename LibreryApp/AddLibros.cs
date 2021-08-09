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
    public partial class AddLibros : Form
    {
        
        ServicioLibro Servicio;
        
        public AddLibros()
        {
            InitializeComponent();
           
            Servicio = new ServicioLibro();
        }
        #region events
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardLibro_Click(object sender, EventArgs e)
        {
            Validacion();
        }

        private void CbxEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            MantLibros m = new MantLibros();
            m.Show();
            this.Hide();
        }

        private void BtnCancelLibro_Click(object sender, EventArgs e)
        {

            MantLibros m = new MantLibros();
            m.Show();
            this.Hide();
        }

        private void AddLibros_Load(object sender, EventArgs e)
        {
           loadCBX();
        }
        
        #endregion

        #region methods


      private void loadCBX()
        {
            CbxAutor.Items.Add("Seleccione el autor");
            foreach (var i in Repositorio.Instancia.Autores)
            {
                _ = CbxAutor.Items.Add(i.NameAutor);
            }
            CbxAutor.SelectedItem = "Seleccione el autor";
            CbxEditorial.Items.Add("Seleccione la Editorial");
            foreach (var i in Repositorio.Instancia.Editoriales)
            {

                _ = CbxEditorial.Items.Add(i.NameEditorial);
            }
            CbxEditorial.SelectedItem = "Seleccione la Editorial";
        }
        private void Validacion()
        {
            if (CbxEditorial.Text == "Seleccione la Editorial")
            {
                MessageBox.Show("Debes seleccionar la editorial del libro, si no esta en la base de datos debes agregarla primero");
            } 
            else if (CbxAutor.Text == "Seleccione el autor")
            {
                MessageBox.Show("Debes seleccionar el autor del libro, si no esta en la base de datos debes agregarlo primero");
            }
            else if (TxtAnLibro.Text == ""|| TxtNameLibro.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else { Guardar(); this.Close(); }
        }
        private void Guardar()
        {
            Libros Libro = new Libros(TxtNameLibro.Text, TxtAnLibro.Text, CbxAutor.Text, CbxEditorial.Text);
            Libro.NameLibro = TxtNameLibro.Text;
            Libro.Date = TxtAnLibro.Text;
            Libro.Autor =  (string)CbxAutor.SelectedItem;
            Libro.Editorial = (string)CbxEditorial.SelectedItem;
            Servicio.AddL(Libro);
            MessageBox.Show("Se guardo con exito", "Notificacion");
            this.Close();
        }

        
        #endregion


 
    }
}
