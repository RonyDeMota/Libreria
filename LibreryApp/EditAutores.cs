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
    public partial class EditAutores : Form
    {
      
        ServicioAutores Servicio;
        public int idR;


        public EditAutores()
        {
            InitializeComponent();



            Servicio = new ServicioAutores();
        }

        private void btnGuardAut_Click(object sender, EventArgs e)
        {
            EditContact();

            this.Close();
        }

        
        public void LoadEdit()
        {
            Autores eas = Servicio.GetbyIdA(idR);

            TxtEditNameAutor.Text = eas.NameAutor;
            TxtEditCorreoAut.Text = eas.Correo;
        }
        public void EditContact()
        {
            Autores eass = new Autores(TxtEditNameAutor.Text, TxtEditCorreoAut.Text);

            Servicio.EditA(idR, eass);

            eass.NameAutor = TxtEditNameAutor.Text;
            eass.Correo = TxtEditCorreoAut.Text;
         
        }


        private void EditAutores_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }

        private void EditAutores_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarAutor listar = new ListarAutor();
            listar.Show();
        }

        private void BtnCancelAut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
