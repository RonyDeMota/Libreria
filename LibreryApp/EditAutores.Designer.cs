
namespace LibreryApp
{
    partial class EditAutores
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancelAut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardAut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEditNameAutor = new System.Windows.Forms.TextBox();
            this.TxtEditCorreoAut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.98801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.01199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.49315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.50685F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCancelAut, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardAut, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtEditNameAutor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtEditCorreoAut, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(161, 107);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07527F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.92473F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 255);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnCancelAut
            // 
            this.BtnCancelAut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancelAut.Location = new System.Drawing.Point(3, 188);
            this.BtnCancelAut.Name = "BtnCancelAut";
            this.BtnCancelAut.Size = new System.Drawing.Size(242, 43);
            this.BtnCancelAut.TabIndex = 0;
            this.BtnCancelAut.Text = "Cancelar";
            this.BtnCancelAut.UseVisualStyleBackColor = true;
            this.BtnCancelAut.Click += new System.EventHandler(this.BtnCancelAut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 95);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del autor:";
            // 
            // btnGuardAut
            // 
            this.btnGuardAut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardAut.Location = new System.Drawing.Point(251, 188);
            this.btnGuardAut.Name = "btnGuardAut";
            this.btnGuardAut.Size = new System.Drawing.Size(243, 43);
            this.btnGuardAut.TabIndex = 0;
            this.btnGuardAut.Text = "Guardar";
            this.btnGuardAut.UseVisualStyleBackColor = true;
            this.btnGuardAut.Click += new System.EventHandler(this.btnGuardAut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(179, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 90);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correo:";
            // 
            // TxtEditNameAutor
            // 
            this.TxtEditNameAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtEditNameAutor.Location = new System.Drawing.Point(251, 3);
            this.TxtEditNameAutor.Name = "TxtEditNameAutor";
            this.TxtEditNameAutor.Size = new System.Drawing.Size(243, 27);
            this.TxtEditNameAutor.TabIndex = 2;
            // 
            // TxtEditCorreoAut
            // 
            this.TxtEditCorreoAut.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtEditCorreoAut.Location = new System.Drawing.Point(251, 98);
            this.TxtEditCorreoAut.Name = "TxtEditCorreoAut";
            this.TxtEditCorreoAut.Size = new System.Drawing.Size(243, 27);
            this.TxtEditCorreoAut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 104);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditAutores";
            this.Text = "EditAutores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditAutores_FormClosed);
            this.Load += new System.EventHandler(this.EditAutores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnCancelAut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardAut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEditNameAutor;
        private System.Windows.Forms.TextBox TxtEditCorreoAut;
        private System.Windows.Forms.Label label1;
    }
}