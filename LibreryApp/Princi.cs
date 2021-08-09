using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreryApp
{
    public partial class Princi : Form
    {
        public static Princi Instancia { get; } = new Princi();
        public Princi()
        {
            InitializeComponent();
        }

        private void BtnMantAutores_Click(object sender, EventArgs e)
        {
            MantAutores autor = new MantAutores();
            autor.Show();
            this.Hide();
        }

        private void BtnMantLibros_Click(object sender, EventArgs e)
        {
            MantLibros Liblo = new MantLibros();
            Liblo.Show();
            this.Hide();
        }

        private void BtnMantEditorial_Click(object sender, EventArgs e)
        {
            MantEditorial Edito = new MantEditorial();
            Edito.Show();
            this.Hide();
        }
    }
}
