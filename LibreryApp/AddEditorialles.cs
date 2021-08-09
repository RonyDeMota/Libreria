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
    public partial class AddEditorialles : Form
    {
        ServicioEdito Servicio;



        public AddEditorialles()
        {
            InitializeComponent();
         
            Servicio = new ServicioEdito();
        }

        private void AddEditorialles_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardEdito_Click(object sender, EventArgs e)
        {
            Validacion();
        }






        private void guardar()
        {
            Editorial Edito = new Editorial(TxtNombreEdito.Text, TxtPhoneEditorial.Text, TxtPaisEditorial.Text);
            Edito.NameEditorial = TxtNombreEdito.Text;
            Edito.Telefono = TxtPhoneEditorial.Text;
            Edito.Pais = TxtPaisEditorial.Text;
            MessageBox.Show("Se guardo con exito", "Notificacion");

            Servicio.AddE(Edito);
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Validacion()
        {
            if (TxtNombreEdito.Text != "" && TxtPaisEditorial.Text != "" && TxtPhoneEditorial.Text != "")
            {
                guardar();
            }
        }

        private void AddEditorialles_FormClosed(object sender, FormClosedEventArgs e)
        {
            MantEditorial man = new MantEditorial();
            man.Show();
        }
    }
}
