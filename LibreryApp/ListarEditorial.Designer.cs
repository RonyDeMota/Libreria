
namespace LibreryApp
{
    partial class ListarEditorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewEdito = new System.Windows.Forms.DataGridView();
            this.NombreEdit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutordeLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atras = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Borrar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewEdito)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.97313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.02687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewEdito, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Atras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.17962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.82037F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 508);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editoriales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewEdito
            // 
            this.ViewEdito.AllowUserToAddRows = false;
            this.ViewEdito.AllowUserToDeleteRows = false;
            this.ViewEdito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewEdito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEdit,
            this.Correo,
            this.AutordeLib});
            this.ViewEdito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewEdito.Location = new System.Drawing.Point(113, 93);
            this.ViewEdito.Name = "ViewEdito";
            this.ViewEdito.ReadOnly = true;
            this.ViewEdito.RowHeadersWidth = 51;
            this.ViewEdito.RowTemplate.Height = 29;
            this.ViewEdito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewEdito.Size = new System.Drawing.Size(536, 332);
            this.ViewEdito.TabIndex = 0;
            this.ViewEdito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.ViewEdito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewEdito_CellContentClick);
            // 
            // NombreEdit
            // 
            this.NombreEdit.HeaderText = "Nombre del editorial";
            this.NombreEdit.MinimumWidth = 6;
            this.NombreEdit.Name = "NombreEdit";
            this.NombreEdit.ReadOnly = true;
            this.NombreEdit.Width = 180;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Teléfono";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 170;
            // 
            // AutordeLib
            // 
            this.AutordeLib.HeaderText = "País";
            this.AutordeLib.MinimumWidth = 6;
            this.AutordeLib.Name = "AutordeLib";
            this.AutordeLib.ReadOnly = true;
            this.AutordeLib.Width = 140;
            // 
            // Atras
            // 
            this.Atras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Atras.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Atras.Location = new System.Drawing.Point(3, 3);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(104, 84);
            this.Atras.TabIndex = 1;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Borrar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Editar, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(113, 431);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(536, 74);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Borrar
            // 
            this.Borrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Borrar.Location = new System.Drawing.Point(3, 3);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(530, 31);
            this.Borrar.TabIndex = 0;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Editar
            // 
            this.Editar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editar.Location = new System.Drawing.Point(3, 40);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(530, 31);
            this.Editar.TabIndex = 0;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // ListarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListarEditorial";
            this.Text = "ListarEditorial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListarEditorial_FormClosing);
            this.Load += new System.EventHandler(this.ListarEditorial_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewEdito)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewEdito;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutordeLib;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Editar;
    }
}