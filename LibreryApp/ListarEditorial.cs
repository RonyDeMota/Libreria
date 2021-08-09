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
    public partial class ListarEditorial : Form
    {
        ServicioEdito Servicio;
        public int ep;
        public int IdD;

        public ListarEditorial()
        {
            InitializeComponent();
            Servicio = new ServicioEdito();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IdD = e.RowIndex;
            }
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void Borrar_Click(object sender, EventArgs e)
        {
            //DeleteEdito();
            LoadV();
        }

        private void ListarEditorial_Load(object sender, EventArgs e)
        {
            LoadV();
        }

        private void LoadV()
        {
           ViewEdito.Rows.Clear();
             foreach (Editorial Item in Repositorio.Instancia.Editoriales)
             {
                 ViewEdito.Rows.Add(Item.NameEditorial, Item.Telefono, Item.Pais);
             }
        }

        private void ViewEdito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Atras_Click(object sender, EventArgs e)
        {
            ep = 1;
            MantEditorial Man = new MantEditorial();
            Man.Show();
            this.Close();
        }

        private void ListarEditorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ep == 1)
            {
                e.Cancel = false;
            }
            else { e.Cancel = true; }
        }

        public void Edit()
        {
            if (IdD >= 0)
            {
                ep = 1;
                EditEditoriales edit = new EditEditoriales();
                edit.IdC = IdD;
                edit.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el campo que desea editar");
            }

        }

       /* private void DeleteEdito()
        {
            if (idDB != -1)
            {
                DialogResult result = MessageBox.Show("Quiere borrar este Autor", "Notificacion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    bool tipo = Servicio.GetDependens(idDB, true);
                    if (tipo == false)
                    {
                        Servicio.RemoveE(idDB);
                    }
                    else
                    {
                        MessageBox.Show("Este Autor no se puede eliminar, un libro lo esta usando", "Notificacion DANGER");
                    }
                }
            }
        }*/
    }
}
