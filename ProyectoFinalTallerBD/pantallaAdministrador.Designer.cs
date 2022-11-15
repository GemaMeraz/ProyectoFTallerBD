
namespace ProyectoFinalTallerBD
{
    partial class pantallaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantallaAdministrador));
            this.pnlMenuAdmin = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pnlSubmenuClientes = new System.Windows.Forms.Panel();
            this.btnPendPago = new System.Windows.Forms.Button();
            this.btnClCreditos = new System.Windows.Forms.Button();
            this.btnTdClientes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVistasDatos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlMenuAdmin.SuspendLayout();
            this.pnlSubmenuClientes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuAdmin
            // 
            this.pnlMenuAdmin.BackColor = System.Drawing.Color.Teal;
            this.pnlMenuAdmin.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuAdmin.Controls.Add(this.btnVentas);
            this.pnlMenuAdmin.Controls.Add(this.pnlSubmenuClientes);
            this.pnlMenuAdmin.Controls.Add(this.btnClientes);
            this.pnlMenuAdmin.Controls.Add(this.btnProductos);
            this.pnlMenuAdmin.Controls.Add(this.btnProveedores);
            this.pnlMenuAdmin.Controls.Add(this.btnEmpleados);
            this.pnlMenuAdmin.Controls.Add(this.panel1);
            this.pnlMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuAdmin.Name = "pnlMenuAdmin";
            this.pnlMenuAdmin.Size = new System.Drawing.Size(170, 472);
            this.pnlMenuAdmin.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 364);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnVentas.Size = new System.Drawing.Size(170, 37);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pnlSubmenuClientes
            // 
            this.pnlSubmenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSubmenuClientes.Controls.Add(this.btnPendPago);
            this.pnlSubmenuClientes.Controls.Add(this.btnClCreditos);
            this.pnlSubmenuClientes.Controls.Add(this.btnTdClientes);
            this.pnlSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuClientes.Location = new System.Drawing.Point(0, 258);
            this.pnlSubmenuClientes.Name = "pnlSubmenuClientes";
            this.pnlSubmenuClientes.Size = new System.Drawing.Size(170, 106);
            this.pnlSubmenuClientes.TabIndex = 5;
            this.pnlSubmenuClientes.Visible = false;
            // 
            // btnPendPago
            // 
            this.btnPendPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendPago.FlatAppearance.BorderSize = 0;
            this.btnPendPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendPago.Font = new System.Drawing.Font("Poetsen One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendPago.ForeColor = System.Drawing.Color.White;
            this.btnPendPago.Location = new System.Drawing.Point(0, 66);
            this.btnPendPago.Name = "btnPendPago";
            this.btnPendPago.Size = new System.Drawing.Size(170, 33);
            this.btnPendPago.TabIndex = 2;
            this.btnPendPago.Text = "Pendientes de pago";
            this.btnPendPago.UseVisualStyleBackColor = true;
            // 
            // btnClCreditos
            // 
            this.btnClCreditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClCreditos.FlatAppearance.BorderSize = 0;
            this.btnClCreditos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClCreditos.Font = new System.Drawing.Font("Poetsen One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClCreditos.ForeColor = System.Drawing.Color.White;
            this.btnClCreditos.Location = new System.Drawing.Point(0, 33);
            this.btnClCreditos.Name = "btnClCreditos";
            this.btnClCreditos.Size = new System.Drawing.Size(170, 33);
            this.btnClCreditos.TabIndex = 1;
            this.btnClCreditos.Text = "Clientes con credito";
            this.btnClCreditos.UseVisualStyleBackColor = true;
            this.btnClCreditos.Click += new System.EventHandler(this.btnClCreditos_Click);
            // 
            // btnTdClientes
            // 
            this.btnTdClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTdClientes.FlatAppearance.BorderSize = 0;
            this.btnTdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTdClientes.Font = new System.Drawing.Font("Poetsen One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTdClientes.ForeColor = System.Drawing.Color.White;
            this.btnTdClientes.Location = new System.Drawing.Point(0, 0);
            this.btnTdClientes.Name = "btnTdClientes";
            this.btnTdClientes.Size = new System.Drawing.Size(170, 33);
            this.btnTdClientes.TabIndex = 0;
            this.btnTdClientes.Text = "Todos los clientes";
            this.btnTdClientes.UseVisualStyleBackColor = true;
            this.btnTdClientes.Click += new System.EventHandler(this.btnTdClientes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 221);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnClientes.Size = new System.Drawing.Size(170, 37);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 184);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(170, 37);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 147);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(170, 37);
            this.btnProveedores.TabIndex = 2;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 110);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(170, 37);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "  Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 110);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.lblTitulo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 36);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlVistasDatos
            // 
            this.pnlVistasDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVistasDatos.Location = new System.Drawing.Point(170, 36);
            this.pnlVistasDatos.Name = "pnlVistasDatos";
            this.pnlVistasDatos.Size = new System.Drawing.Size(649, 436);
            this.pnlVistasDatos.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitulo.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Muebleria DEM";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Poetsen One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 401);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(170, 37);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Ventas";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pantallaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.pnlVistasDatos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMenuAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pantallaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pantallaAdministrador";
            this.Load += new System.EventHandler(this.pantallaAdministrador_Load);
            this.pnlMenuAdmin.ResumeLayout(false);
            this.pnlSubmenuClientes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlSubmenuClientes;
        private System.Windows.Forms.Button btnPendPago;
        private System.Windows.Forms.Button btnClCreditos;
        private System.Windows.Forms.Button btnTdClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel pnlVistasDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}