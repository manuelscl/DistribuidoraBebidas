namespace DistribuidoraBebidas
{
    partial class FormPrincipal
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
            panel1 = new Panel();
            btn_cerrar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btn_cerrarSesion = new Button();
            button5 = new Button();
            button4 = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 45);
            panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.FromArgb(192, 0, 0);
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.FlatAppearance.BorderSize = 0;
            btn_cerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(168, 0, 0);
            btn_cerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 0, 0);
            btn_cerrar.FlatStyle = FlatStyle.Flat;
            btn_cerrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cerrar.ForeColor = Color.White;
            btn_cerrar.Location = new Point(1249, 9);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(39, 29);
            btn_cerrar.TabIndex = 8;
            btn_cerrar.Text = "X";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 7;
            label1.Text = "Bebidas Eli | Distribuidora de Bebidas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 115, 209);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_cerrarSesion);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 573);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(172, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 9;
            // 
            // btn_cerrarSesion
            // 
            btn_cerrarSesion.BackColor = Color.FromArgb(0, 115, 209);
            btn_cerrarSesion.Cursor = Cursors.Hand;
            btn_cerrarSesion.FlatAppearance.BorderSize = 0;
            btn_cerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btn_cerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btn_cerrarSesion.FlatStyle = FlatStyle.Flat;
            btn_cerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_cerrarSesion.ForeColor = Color.White;
            btn_cerrarSesion.Image = Properties.Resources.cierre_de_sesion_de_usuario;
            btn_cerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cerrarSesion.Location = new Point(12, 504);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Padding = new Padding(15, 0, 0, 0);
            btn_cerrarSesion.Size = new Size(187, 49);
            btn_cerrarSesion.TabIndex = 13;
            btn_cerrarSesion.Text = "      Cerrar Sesión";
            btn_cerrarSesion.UseVisualStyleBackColor = false;
            btn_cerrarSesion.Click += btn_cerrarSesion_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.factura_punto_de_venta;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 425);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 5, 0);
            button5.Size = new Size(211, 49);
            button5.TabIndex = 12;
            button5.Text = "         Ventas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.etiquetas;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 370);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 5, 0);
            button4.Size = new Size(211, 49);
            button4.TabIndex = 11;
            button4.Text = "         Categorías";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 140);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 10;
            label3.Text = "Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 140);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 9;
            label2.Text = "Bienvenido, ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(72, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.cajas;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 315);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 5, 0);
            button3.Size = new Size(211, 49);
            button3.TabIndex = 4;
            button3.Text = "         Productos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.usuarios;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 260);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 5, 0);
            button2.Size = new Size(211, 49);
            button2.TabIndex = 3;
            button2.Text = "         Usuarios";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icono_inicio;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 205);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 5, 0);
            button1.Size = new Size(211, 49);
            button1.TabIndex = 2;
            button1.Text = "         Inicio";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Location = new Point(244, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 618);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_cerrar;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button btn_cerrarSesion;
        private Button button5;
        private Button button4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
    }
}