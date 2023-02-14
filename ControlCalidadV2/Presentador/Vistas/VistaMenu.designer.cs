
namespace Presentador.Vistas
{
    partial class MenuInicio
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListarColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnListarModelos = new System.Windows.Forms.Button();
            this.btnAddModelos = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.panelSubMenuVenta = new System.Windows.Forms.Panel();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.btnAddEmpleados = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panelSubMenuProducto = new System.Windows.Forms.Panel();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnAdministrarOrden = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnListaProducto = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblRolEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmepleado = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            this.panelSubMenuVenta.SuspendLayout();
            this.panelSubMenuProducto.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuLateral.Controls.Add(this.panel1);
            this.panelMenuLateral.Controls.Add(this.btnColores);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuCliente);
            this.panelMenuLateral.Controls.Add(this.btnModelos);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuVenta);
            this.panelMenuLateral.Controls.Add(this.btnEmpleados);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuProducto);
            this.panelMenuLateral.Controls.Add(this.btnProducto);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(240, 749);
            this.panelMenuLateral.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnListarColor);
            this.panel1.Controls.Add(this.btnAddColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 736);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 86);
            this.panel1.TabIndex = 8;
            // 
            // btnListarColor
            // 
            this.btnListarColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarColor.FlatAppearance.BorderSize = 0;
            this.btnListarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarColor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnListarColor.Location = new System.Drawing.Point(0, 40);
            this.btnListarColor.Name = "btnListarColor";
            this.btnListarColor.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListarColor.Size = new System.Drawing.Size(240, 40);
            this.btnListarColor.TabIndex = 1;
            this.btnListarColor.Text = "Listar Colores";
            this.btnListarColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarColor.UseVisualStyleBackColor = true;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddColor.FlatAppearance.BorderSize = 0;
            this.btnAddColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddColor.Location = new System.Drawing.Point(0, 0);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAddColor.Size = new System.Drawing.Size(240, 40);
            this.btnAddColor.TabIndex = 0;
            this.btnAddColor.Text = "Crear Color";
            this.btnAddColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // btnColores
            // 
            this.btnColores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnColores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnColores.FlatAppearance.BorderSize = 0;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnColores.Location = new System.Drawing.Point(0, 676);
            this.btnColores.Name = "btnColores";
            this.btnColores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnColores.Size = new System.Drawing.Size(240, 60);
            this.btnColores.TabIndex = 7;
            this.btnColores.Text = "Colores";
            this.btnColores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColores.UseVisualStyleBackColor = false;
            this.btnColores.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuCliente.Controls.Add(this.btnListarModelos);
            this.panelSubMenuCliente.Controls.Add(this.btnAddModelos);
            this.panelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCliente.Location = new System.Drawing.Point(0, 590);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(240, 86);
            this.panelSubMenuCliente.TabIndex = 6;
            // 
            // btnListarModelos
            // 
            this.btnListarModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarModelos.FlatAppearance.BorderSize = 0;
            this.btnListarModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarModelos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnListarModelos.Location = new System.Drawing.Point(0, 40);
            this.btnListarModelos.Name = "btnListarModelos";
            this.btnListarModelos.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListarModelos.Size = new System.Drawing.Size(240, 40);
            this.btnListarModelos.TabIndex = 1;
            this.btnListarModelos.Text = "Listar Modelos";
            this.btnListarModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarModelos.UseVisualStyleBackColor = true;
            // 
            // btnAddModelos
            // 
            this.btnAddModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddModelos.FlatAppearance.BorderSize = 0;
            this.btnAddModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModelos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddModelos.Location = new System.Drawing.Point(0, 0);
            this.btnAddModelos.Name = "btnAddModelos";
            this.btnAddModelos.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAddModelos.Size = new System.Drawing.Size(240, 40);
            this.btnAddModelos.TabIndex = 0;
            this.btnAddModelos.Text = "Crear Modelo";
            this.btnAddModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddModelos.UseVisualStyleBackColor = true;
            this.btnAddModelos.Click += new System.EventHandler(this.btnAddModelos_Click);
            // 
            // btnModelos
            // 
            this.btnModelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModelos.Location = new System.Drawing.Point(0, 530);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnModelos.Size = new System.Drawing.Size(240, 60);
            this.btnModelos.TabIndex = 5;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModelos.UseVisualStyleBackColor = false;
            this.btnModelos.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // panelSubMenuVenta
            // 
            this.panelSubMenuVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuVenta.Controls.Add(this.btnListarEmpleados);
            this.panelSubMenuVenta.Controls.Add(this.btnAddEmpleados);
            this.panelSubMenuVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVenta.Location = new System.Drawing.Point(0, 444);
            this.panelSubMenuVenta.Name = "panelSubMenuVenta";
            this.panelSubMenuVenta.Size = new System.Drawing.Size(240, 86);
            this.panelSubMenuVenta.TabIndex = 4;
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnListarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEmpleados.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnListarEmpleados.Location = new System.Drawing.Point(0, 40);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListarEmpleados.Size = new System.Drawing.Size(240, 40);
            this.btnListarEmpleados.TabIndex = 1;
            this.btnListarEmpleados.Text = "Listar Empleados";
            this.btnListarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnAddEmpleados
            // 
            this.btnAddEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAddEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpleados.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnAddEmpleados.Name = "btnAddEmpleados";
            this.btnAddEmpleados.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAddEmpleados.Size = new System.Drawing.Size(240, 40);
            this.btnAddEmpleados.TabIndex = 0;
            this.btnAddEmpleados.Text = "Crear empleado";
            this.btnAddEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmpleados.UseVisualStyleBackColor = true;
            this.btnAddEmpleados.Click += new System.EventHandler(this.btnListaVenta_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 384);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(240, 60);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelSubMenuProducto
            // 
            this.panelSubMenuProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenuProducto.Controls.Add(this.btnMarca);
            this.panelSubMenuProducto.Controls.Add(this.btnAdministrarOrden);
            this.panelSubMenuProducto.Controls.Add(this.btnAgregarProducto);
            this.panelSubMenuProducto.Controls.Add(this.btnListaProducto);
            this.panelSubMenuProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProducto.Location = new System.Drawing.Point(0, 214);
            this.panelSubMenuProducto.Name = "panelSubMenuProducto";
            this.panelSubMenuProducto.Size = new System.Drawing.Size(240, 170);
            this.panelSubMenuProducto.TabIndex = 2;
            // 
            // btnMarca
            // 
            this.btnMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMarca.Location = new System.Drawing.Point(0, 120);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnMarca.Size = new System.Drawing.Size(240, 40);
            this.btnMarca.TabIndex = 3;
            this.btnMarca.Text = "Consultar Semaforo";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarOrden
            // 
            this.btnAdministrarOrden.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministrarOrden.FlatAppearance.BorderSize = 0;
            this.btnAdministrarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarOrden.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdministrarOrden.Location = new System.Drawing.Point(0, 80);
            this.btnAdministrarOrden.Name = "btnAdministrarOrden";
            this.btnAdministrarOrden.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAdministrarOrden.Size = new System.Drawing.Size(240, 40);
            this.btnAdministrarOrden.TabIndex = 2;
            this.btnAdministrarOrden.Text = "Administrar Orden";
            this.btnAdministrarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministrarOrden.UseVisualStyleBackColor = true;
            this.btnAdministrarOrden.Click += new System.EventHandler(this.btnAdministrarOrden_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 40);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAgregarProducto.Size = new System.Drawing.Size(240, 40);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Orden";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnListaProducto
            // 
            this.btnListaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnListaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaProducto.FlatAppearance.BorderSize = 0;
            this.btnListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnListaProducto.Location = new System.Drawing.Point(0, 0);
            this.btnListaProducto.Name = "btnListaProducto";
            this.btnListaProducto.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnListaProducto.Size = new System.Drawing.Size(240, 40);
            this.btnListaProducto.TabIndex = 0;
            this.btnListaProducto.Text = "Lista Ordenes";
            this.btnListaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaProducto.UseVisualStyleBackColor = false;
            this.btnListaProducto.Click += new System.EventHandler(this.btnListaProducto_Click_1);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProducto.Location = new System.Drawing.Point(0, 154);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnProducto.Size = new System.Drawing.Size(240, 60);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "OdenProduccion";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.lblRolEmpleado);
            this.panelLogo.Controls.Add(this.lblNombreEmepleado);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 154);
            this.panelLogo.TabIndex = 0;
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolEmpleado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRolEmpleado.Location = new System.Drawing.Point(38, 78);
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(0, 18);
            this.lblRolEmpleado.TabIndex = 1;
            // 
            // lblNombreEmepleado
            // 
            this.lblNombreEmepleado.AutoSize = true;
            this.lblNombreEmepleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmepleado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNombreEmepleado.Location = new System.Drawing.Point(38, 38);
            this.lblNombreEmepleado.Name = "lblNombreEmepleado";
            this.lblNombreEmepleado.Size = new System.Drawing.Size(0, 22);
            this.lblNombreEmepleado.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(240, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1024, 749);
            this.panelForm.TabIndex = 2;
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenuLateral);
            this.Name = "MenuInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInicio";
            this.panelMenuLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelSubMenuCliente.ResumeLayout(false);
            this.panelSubMenuVenta.ResumeLayout(false);
            this.panelSubMenuProducto.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Panel panelSubMenuVenta;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnAddEmpleados;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel panelSubMenuProducto;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnAdministrarOrden;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnListaProducto;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private System.Windows.Forms.Button btnListarModelos;
        private System.Windows.Forms.Button btnAddModelos;
        public System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblNombreEmepleado;
        private System.Windows.Forms.Label lblRolEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnColores;
    }
}