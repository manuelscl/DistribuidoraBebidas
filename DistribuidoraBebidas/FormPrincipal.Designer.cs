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
            btnClientes = new Button();
            button6 = new Button();
            panel4 = new Panel();
            btn_cerrarSesion = new Button();
            button5 = new Button();
            btnCategorias = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btnUsuarios = new Button();
            btnInicio = new Button();
            adminUsuarios1 = new AdminUsuarios();
            panelAdmin1 = new PanelAdmin();
            adminAgregarClientes1 = new AdminAgregarClientes();
            agregarCategoria1 = new AgregarCategoria();
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
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btn_cerrarSesion);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnUsuarios);
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 665);
            panel2.TabIndex = 1;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = Properties.Resources.icono_clientes;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 251);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(15, 0, 5, 0);
            btnClientes.Size = new Size(218, 49);
            btnClientes.TabIndex = 15;
            btnClientes.Text = "         Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.icono_ventaDetalle1;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 471);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 5, 0);
            button6.Size = new Size(218, 72);
            button6.TabIndex = 14;
            button6.Text = "         Detalles de                 Ventas";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
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
            btn_cerrarSesion.Location = new Point(14, 604);
            btn_cerrarSesion.Name = "btn_cerrarSesion";
            btn_cerrarSesion.Padding = new Padding(5, 0, 0, 0);
            btn_cerrarSesion.Size = new Size(188, 49);
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
            button5.Image = Properties.Resources.factura_punto_de_venta1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 416);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 5, 0);
            button5.Size = new Size(215, 49);
            button5.TabIndex = 12;
            button5.Text = "         Ventas";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = Properties.Resources.etiquetas1;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(0, 361);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Padding = new Padding(15, 0, 5, 0);
            btnCategorias.Size = new Size(218, 49);
            btnCategorias.TabIndex = 11;
            btnCategorias.Text = "         Categorías";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_bebidas_eli_vf;
            pictureBox1.Location = new Point(13, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            button3.Location = new Point(0, 306);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 5, 0);
            button3.Size = new Size(218, 49);
            button3.TabIndex = 4;
            button3.Text = "         Productos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Image = Properties.Resources.usuarios;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 200);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(15, 0, 5, 0);
            btnUsuarios.Size = new Size(218, 49);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "         Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 100, 181);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 100, 181);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = Properties.Resources.icono_inicio;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 145);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(15, 0, 5, 0);
            btnInicio.Size = new Size(218, 49);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "         Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // adminUsuarios1
            // 
            adminUsuarios1.BackColor = Color.Teal;
            adminUsuarios1.Location = new Point(217, 45);
            adminUsuarios1.Name = "adminUsuarios1";
            adminUsuarios1.Size = new Size(1085, 665);
            adminUsuarios1.TabIndex = 2;
            // 
            // panelAdmin1
            // 
            panelAdmin1.Location = new Point(219, 45);
            panelAdmin1.Name = "panelAdmin1";
            panelAdmin1.Size = new Size(1085, 665);
            panelAdmin1.TabIndex = 9;
            // 
            // adminAgregarClientes1
            // 
            adminAgregarClientes1.BackColor = Color.Teal;
            adminAgregarClientes1.Location = new Point(219, 45);
            adminAgregarClientes1.Margin = new Padding(2);
            adminAgregarClientes1.Name = "adminAgregarClientes1";
            adminAgregarClientes1.Size = new Size(1085, 665);
            adminAgregarClientes1.TabIndex = 9;
            // 
            // agregarCategoria1
            // 
            agregarCategoria1.BackColor = Color.Teal;
            agregarCategoria1.Location = new Point(215, 45);
            agregarCategoria1.Name = "agregarCategoria1";
            agregarCategoria1.Size = new Size(1085, 665);
            agregarCategoria1.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 710);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelAdmin1);
            Controls.Add(adminUsuarios1);
            Controls.Add(adminAgregarClientes1);
            Controls.Add(agregarCategoria1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btn_cerrar;
        private Button btnInicio;
        private Button button3;
        private Button btnUsuarios;
        private Button btn_cerrarSesion;
        private Button button5;
        private Button btnCategorias;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button button6;
        private AdminUsuarios adminUsuarios1;
        private Button btnClientes;
        private PanelAdmin panelAdmin1;
        private AdminAgregarClientes adminAgregarClientes1;
        private AgregarCategoria agregarCategoria1;
    }
}