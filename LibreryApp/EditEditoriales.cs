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
    public partial class EditEditoriales : Form
    {
        public int IdC;
        ServicioEdito Servicio;

        public EditEditoriales()
        {
            InitializeComponent();
            Servicio = new ServicioEdito();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnGuardEdito_Click(object sender, EventArgs e)
        {
            Edit();
            this.Close();
        }
        private void EditEditoriales_Load(object sender, EventArgs e)
        {
            LoadEdit();
        }
        private void EditEditoriales_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarEditorial listar = new ListarEditorial();
            listar.Show();
        }

        private void BtnCancelEdito_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadEdit()
        {
            Editorial eas = Servicio.GetbyIdE(IdC);

            TxtNombreEdito.Text = eas.NameEditorial;
            TxtPaisEditorial.Text = eas.Pais;
            TxtPhoneEditorial.Text = eas.Telefono;
        }
        public void Edit()
        {
            Editorial eass = new Editorial(TxtNombreEdito.Text, TxtPaisEditorial.Text, TxtPhoneEditorial.Text);

            Servicio.EditE(IdC, eass);

            eass.NameEditorial = TxtNombreEdito.Text;
            eass.Pais = TxtPaisEditorial.Text;
            eass.Telefono = TxtPhoneEditorial.Text;
        }
    }
}
