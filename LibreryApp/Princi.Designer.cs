
namespace LibreryApp
{
    partial class Princi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnMantLibros = new System.Windows.Forms.Button();
            this.BtnMantEditorial = new System.Windows.Forms.Button();
            this.BtnMantAutores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.47038F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.52962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.Controls.Add(this.BtnMantLibros, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnMantEditorial, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnMantAutores, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.21739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnMantLibros
            // 
            this.BtnMantLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMantLibros.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMantLibros.Location = new System.Drawing.Point(247, 173);
            this.BtnMantLibros.Name = "BtnMantLibros";
            this.BtnMantLibros.Size = new System.Drawing.Size(287, 84);
            this.BtnMantLibros.TabIndex = 0;
            this.BtnMantLibros.Text = "Mantenimiento de Libros";
            this.BtnMantLibros.UseVisualStyleBackColor = true;
            this.BtnMantLibros.Click += new System.EventHandler(this.BtnMantLibros_Click);
            // 
            // BtnMantEditorial
            // 
            this.BtnMantEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMantEditorial.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMantEditorial.Location = new System.Drawing.Point(540, 173);
            this.BtnMantEditorial.Name = "BtnMantEditorial";
            this.BtnMantEditorial.Size = new System.Drawing.Size(257, 84);
            this.BtnMantEditorial.TabIndex = 0;
            this.BtnMantEditorial.Text = "Mantenimiento de Editoriales";
            this.BtnMantEditorial.UseVisualStyleBackColor = true;
            this.BtnMantEditorial.Click += new System.EventHandler(this.BtnMantEditorial_Click);
            // 
            // BtnMantAutores
            // 
            this.BtnMantAutores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMantAutores.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMantAutores.Location = new System.Drawing.Point(3, 173);
            this.BtnMantAutores.Name = "BtnMantAutores";
            this.BtnMantAutores.Size = new System.Drawing.Size(238, 84);
            this.BtnMantAutores.TabIndex = 0;
            this.BtnMantAutores.Text = "Mantenimiento de Autores";
            this.BtnMantAutores.UseVisualStyleBackColor = true;
            this.BtnMantAutores.Click += new System.EventHandler(this.BtnMantAutores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 170);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libreria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Princi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Princi";
            this.Text = "Principal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnMantLibros;
        private System.Windows.Forms.Button BtnMantEditorial;
        private System.Windows.Forms.Button BtnMantAutores;
        private System.Windows.Forms.Label label1;
    }
}

