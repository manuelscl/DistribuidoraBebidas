namespace DistribuidoraBebidas
{
    partial class AgregarCategoria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label4 = new Label();
            dgv_categorias = new DataGridView();
            panel1 = new Panel();
            btn_limpiar = new Button();
            btn_eliminar = new Button();
            btn_editar = new Button();
            btn_agregar = new Button();
            this.nombreCategoria = new TextBox();
            label2 = new Label();
            ID_categoria = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categorias).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dgv_categorias);
            panel2.Location = new Point(373, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 544);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(18, 13);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 18;
            label4.Text = "Datos de los Clientes";
            // 
            // dgv_categorias
            // 
            dgv_categorias.BackgroundColor = SystemColors.GradientActiveCaption;
            dgv_categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categorias.Location = new Point(18, 41);
            dgv_categorias.Name = "dgv_categorias";
            dgv_categorias.RowHeadersWidth = 62;
            dgv_categorias.Size = new Size(656, 489);
            dgv_categorias.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_limpiar);
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(btn_agregar);
            panel1.Controls.Add(this.nombreCategoria);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ID_categoria);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 544);
            panel1.TabIndex = 4;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(0, 115, 209);
            btn_limpiar.Cursor = Cursors.Hand;
            btn_limpiar.FlatAppearance.BorderSize = 0;
            btn_limpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_limpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_limpiar.ForeColor = Color.White;
            btn_limpiar.Image = Properties.Resources.icono_limpiar;
            btn_limpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_limpiar.Location = new Point(184, 481);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Padding = new Padding(14, 0, 0, 0);
            btn_limpiar.Size = new Size(155, 49);
            btn_limpiar.TabIndex = 16;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(0, 115, 209);
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_eliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Image = Properties.Resources.icono_borrar;
            btn_eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_eliminar.Location = new Point(14, 481);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Padding = new Padding(14, 0, 0, 0);
            btn_eliminar.Size = new Size(155, 49);
            btn_eliminar.TabIndex = 15;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.FromArgb(0, 115, 209);
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_editar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_editar.ForeColor = Color.White;
            btn_editar.Image = Properties.Resources.icono_editar3;
            btn_editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editar.Location = new Point(184, 410);
            btn_editar.Name = "btn_editar";
            btn_editar.Padding = new Padding(14, 0, 0, 0);
            btn_editar.Size = new Size(155, 49);
            btn_editar.TabIndex = 14;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(0, 115, 209);
            btn_agregar.Cursor = Cursors.Hand;
            btn_agregar.FlatAppearance.BorderSize = 0;
            btn_agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_agregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_agregar.ForeColor = Color.White;
            btn_agregar.Image = Properties.Resources.icono_agregar;
            btn_agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_agregar.Location = new Point(14, 410);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Padding = new Padding(14, 0, 0, 0);
            btn_agregar.Size = new Size(155, 49);
            btn_agregar.TabIndex = 13;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // nombreCategoria
            // 
            this.nombreCategoria.Font = new Font("Segoe UI", 14F);
            this.nombreCategoria.Location = new Point(14, 135);
            this.nombreCategoria.Name = "nombreCategoria";
            this.nombreCategoria.Size = new Size(325, 32);
            this.nombreCategoria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(14, 102);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Categoría";
            // 
            // ID_categoria
            // 
            ID_categoria.Font = new Font("Segoe UI", 14F);
            ID_categoria.Location = new Point(14, 42);
            ID_categoria.Name = "ID_categoria";
            ID_categoria.Size = new Size(325, 32);
            ID_categoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Categoria";
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarCategoria";
            Size = new Size(1085, 573);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categorias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private DataGridView dgv_categorias;
        private Panel panel1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Button btn_limpiar;
        private Button btn_eliminar;
        private Button btn_editar;
        private Button btn_agregar;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox ID_categoria;
        private Label label1;
    }
}
