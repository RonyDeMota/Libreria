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
    public partial class AddAutores : Form
    {
        ServicioAutores Servicio;

        public AddAutores()
        {
            InitializeComponent();
         
            Servicio = new ServicioAutores();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnGuardAut_Click(object sender, EventArgs e)
        {
            MantAutores man = new MantAutores();
            Validar();
            man.Show();
            
        }

        private void Validar()
        {
            if (TxtNameAutor.Text != "" && TxtCorreoAut.Text != "")
            {
                guardar();
            }
        }

        private void guardar()
        {
            Autores autor = new Autores(TxtNameAutor.Text, TxtCorreoAut.Text);
           
            autor.NameAutor = TxtNameAutor.Text;
            autor.Correo = TxtCorreoAut.Text;
            Servicio.AddA(autor);
            MessageBox.Show("Se guardo con exito", "Notificacion");
            this.Close();
        }

        private void AddAutores_Load(object sender, EventArgs e)
        {
            
        }
    
    }
}
