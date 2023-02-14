
namespace Presentador.Vistas
{
    partial class VistaAdministrarOrden
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrdenProducciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoDefecto = new System.Windows.Forms.ComboBox();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalIzquierdoPorHora = new System.Windows.Forms.Label();
            this.btnBuscarOrden = new System.Windows.Forms.Button();
            this.txtBuscarOrden = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMasPrimera = new System.Windows.Forms.Button();
            this.btnMenosPrimera = new System.Windows.Forms.Button();
            this.lblTotalPrimera = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalDerecho = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalIzquierda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPieIzquierdo = new System.Windows.Forms.Panel();
            this.btnAgregarDefecto = new System.Windows.Forms.Button();
            this.cbxDefecto = new System.Windows.Forms.ComboBox();
            this.lblTotalDerechoPorHora = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxPie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPieDerecho = new System.Windows.Forms.DataGridView();
            this.dgvPieIzquierdo = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConsultarSemaforo = new System.Windows.Forms.Button();
            this.btnVincularEmpleado = new System.Windows.Forms.Button();
            this.btnRenaudarOP = new System.Windows.Forms.Button();
            this.btnFinalizarOP = new System.Windows.Forms.Button();
            this.btnPausarOP = new System.Windows.Forms.Button();
            this.btnDesvincularEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenProducciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPieIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieDerecho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieIzquierdo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenProducciones
            // 
            this.dgvOrdenProducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenProducciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenProducciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrdenProducciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdenProducciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenProducciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenProducciones.ColumnHeadersHeight = 30;
            this.dgvOrdenProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenProducciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenProducciones.EnableHeadersVisualStyles = false;
            this.dgvOrdenProducciones.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvOrdenProducciones.Location = new System.Drawing.Point(113, 12);
            this.dgvOrdenProducciones.Name = "dgvOrdenProducciones";
            this.dgvOrdenProducciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenProducciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrdenProducciones.Size = new System.Drawing.Size(587, 165);
            this.dgvOrdenProducciones.TabIndex = 0;
            this.dgvOrdenProducciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenProducciones_CellClick);
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(57, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Defecto";
            // 
            // cbxTipoDefecto
            // 
            this.cbxTipoDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoDefecto.FormattingEnabled = true;
            this.cbxTipoDefecto.Location = new System.Drawing.Point(201, 199);
            this.cbxTipoDefecto.Name = "cbxTipoDefecto";
            this.cbxTipoDefecto.Size = new System.Drawing.Size(159, 28);
            this.cbxTipoDefecto.TabIndex = 4;
            this.cbxTipoDefecto.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDefecto_SelectedIndexChanged);
            // 
            // cbxTurno
            // 
            this.cbxTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Location = new System.Drawing.Point(559, 199);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(159, 28);
            this.cbxTurno.TabIndex = 5;
            this.cbxTurno.SelectedIndexChanged += new System.EventHandler(this.cbxTurno_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(482, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(7, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(7, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Defecto";
            // 
            // lblTotalIzquierdoPorHora
            // 
            this.lblTotalIzquierdoPorHora.AutoSize = true;
            this.lblTotalIzquierdoPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIzquierdoPorHora.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalIzquierdoPorHora.Location = new System.Drawing.Point(375, 227);
            this.lblTotalIzquierdoPorHora.Name = "lblTotalIzquierdoPorHora";
            this.lblTotalIzquierdoPorHora.Size = new System.Drawing.Size(22, 22);
            this.lblTotalIzquierdoPorHora.TabIndex = 26;
            this.lblTotalIzquierdoPorHora.Text = "T";
            // 
            // btnBuscarOrden
            // 
            this.btnBuscarOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarOrden.Location = new System.Drawing.Point(906, 22);
            this.btnBuscarOrden.Name = "btnBuscarOrden";
            this.btnBuscarOrden.Size = new System.Drawing.Size(75, 36);
            this.btnBuscarOrden.TabIndex = 11;
            this.btnBuscarOrden.Text = "Buscar";
            this.btnBuscarOrden.UseVisualStyleBackColor = true;
            this.btnBuscarOrden.Click += new System.EventHandler(this.btnBuscarOrden_Click);
            // 
            // txtBuscarOrden
            // 
            this.txtBuscarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarOrden.Location = new System.Drawing.Point(783, 26);
            this.txtBuscarOrden.Name = "txtBuscarOrden";
            this.txtBuscarOrden.Size = new System.Drawing.Size(100, 27);
            this.txtBuscarOrden.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMasPrimera);
            this.panel2.Controls.Add(this.btnMenosPrimera);
            this.panel2.Controls.Add(this.lblTotalPrimera);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTotalDerecho);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblTotalIzquierda);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(760, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 258);
            this.panel2.TabIndex = 25;
            // 
            // btnMasPrimera
            // 
            this.btnMasPrimera.FlatAppearance.BorderSize = 0;
            this.btnMasPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasPrimera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMasPrimera.Image = global::Presentador.Properties.Resources.mas;
            this.btnMasPrimera.Location = new System.Drawing.Point(153, 174);
            this.btnMasPrimera.Name = "btnMasPrimera";
            this.btnMasPrimera.Size = new System.Drawing.Size(34, 36);
            this.btnMasPrimera.TabIndex = 29;
            this.btnMasPrimera.UseVisualStyleBackColor = true;
            this.btnMasPrimera.Click += new System.EventHandler(this.btnMasPrimera_Click);
            // 
            // btnMenosPrimera
            // 
            this.btnMenosPrimera.FlatAppearance.BorderSize = 0;
            this.btnMenosPrimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenosPrimera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenosPrimera.Image = global::Presentador.Properties.Resources.menos;
            this.btnMenosPrimera.Location = new System.Drawing.Point(22, 174);
            this.btnMenosPrimera.Name = "btnMenosPrimera";
            this.btnMenosPrimera.Size = new System.Drawing.Size(60, 36);
            this.btnMenosPrimera.TabIndex = 30;
            this.btnMenosPrimera.UseVisualStyleBackColor = true;
            this.btnMenosPrimera.Click += new System.EventHandler(this.btnMenosPrimera_Click);
            // 
            // lblTotalPrimera
            // 
            this.lblTotalPrimera.AutoSize = true;
            this.lblTotalPrimera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrimera.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalPrimera.Location = new System.Drawing.Point(100, 181);
            this.lblTotalPrimera.Name = "lblTotalPrimera";
            this.lblTotalPrimera.Size = new System.Drawing.Size(22, 22);
            this.lblTotalPrimera.TabIndex = 32;
            this.lblTotalPrimera.Text = "T";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(53, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Pares de Primera";
            // 
            // lblTotalDerecho
            // 
            this.lblTotalDerecho.AutoSize = true;
            this.lblTotalDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDerecho.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalDerecho.Location = new System.Drawing.Point(149, 72);
            this.lblTotalDerecho.Name = "lblTotalDerecho";
            this.lblTotalDerecho.Size = new System.Drawing.Size(70, 22);
            this.lblTotalDerecho.TabIndex = 30;
            this.lblTotalDerecho.Text = "TOTAL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(12, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Pie Derecho";
            // 
            // lblTotalIzquierda
            // 
            this.lblTotalIzquierda.AutoSize = true;
            this.lblTotalIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIzquierda.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalIzquierda.Location = new System.Drawing.Point(149, 18);
            this.lblTotalIzquierda.Name = "lblTotalIzquierda";
            this.lblTotalIzquierda.Size = new System.Drawing.Size(70, 22);
            this.lblTotalIzquierda.TabIndex = 28;
            this.lblTotalIzquierda.Text = "TOTAL";
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Pie Izquiero";
            // 
            // pnlPieIzquierdo
            // 
            this.pnlPieIzquierdo.AutoScroll = true;
            this.pnlPieIzquierdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPieIzquierdo.Controls.Add(this.btnAgregarDefecto);
            this.pnlPieIzquierdo.Controls.Add(this.cbxDefecto);
            this.pnlPieIzquierdo.Controls.Add(this.lblTotalDerechoPorHora);
            this.pnlPieIzquierdo.Controls.Add(this.label13);
            this.pnlPieIzquierdo.Controls.Add(this.cbxPie);
            this.pnlPieIzquierdo.Controls.Add(this.label7);
            this.pnlPieIzquierdo.Controls.Add(this.dgvPieDerecho);
            this.pnlPieIzquierdo.Controls.Add(this.label5);
            this.pnlPieIzquierdo.Controls.Add(this.dgvPieIzquierdo);
            this.pnlPieIzquierdo.Controls.Add(this.lblTotalIzquierdoPorHora);
            this.pnlPieIzquierdo.Controls.Add(this.label3);
            this.pnlPieIzquierdo.Location = new System.Drawing.Point(84, 287);
            this.pnlPieIzquierdo.Name = "pnlPieIzquierdo";
            this.pnlPieIzquierdo.Size = new System.Drawing.Size(634, 262);
            this.pnlPieIzquierdo.TabIndex = 28;
            // 
            // btnAgregarDefecto
            // 
            this.btnAgregarDefecto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarDefecto.Location = new System.Drawing.Point(98, 164);
            this.btnAgregarDefecto.Name = "btnAgregarDefecto";
            this.btnAgregarDefecto.Size = new System.Drawing.Size(102, 36);
            this.btnAgregarDefecto.TabIndex = 33;
            this.btnAgregarDefecto.Text = "Agregar Defecto";
            this.btnAgregarDefecto.UseVisualStyleBackColor = true;
            this.btnAgregarDefecto.Click += new System.EventHandler(this.btnAgregarDefecto_Click);
            // 
            // cbxDefecto
            // 
            this.cbxDefecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDefecto.FormattingEnabled = true;
            this.cbxDefecto.Location = new System.Drawing.Point(116, 94);
            this.cbxDefecto.Name = "cbxDefecto";
            this.cbxDefecto.Size = new System.Drawing.Size(133, 24);
            this.cbxDefecto.TabIndex = 30;
            // 
            // lblTotalDerechoPorHora
            // 
            this.lblTotalDerechoPorHora.AutoSize = true;
            this.lblTotalDerechoPorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDerechoPorHora.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalDerechoPorHora.Location = new System.Drawing.Point(536, 227);
            this.lblTotalDerechoPorHora.Name = "lblTotalDerechoPorHora";
            this.lblTotalDerechoPorHora.Size = new System.Drawing.Size(22, 22);
            this.lblTotalDerechoPorHora.TabIndex = 32;
            this.lblTotalDerechoPorHora.Text = "T";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label13.Location = new System.Drawing.Point(489, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "Pie Derecho";
            // 
            // cbxPie
            // 
            this.cbxPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPie.FormattingEnabled = true;
            this.cbxPie.Location = new System.Drawing.Point(116, 36);
            this.cbxPie.Name = "cbxPie";
            this.cbxPie.Size = new System.Drawing.Size(133, 24);
            this.cbxPie.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(330, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Pie Izquiero";
            // 
            // dgvPieDerecho
            // 
            this.dgvPieDerecho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPieDerecho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieDerecho.ColumnHeadersVisible = false;
            this.dgvPieDerecho.Location = new System.Drawing.Point(474, 36);
            this.dgvPieDerecho.Name = "dgvPieDerecho";
            this.dgvPieDerecho.RowHeadersVisible = false;
            this.dgvPieDerecho.Size = new System.Drawing.Size(132, 176);
            this.dgvPieDerecho.TabIndex = 28;
            this.dgvPieDerecho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPieDerecho_CellContentClick);
            this.dgvPieDerecho.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPieDerecho_CellPainting);
            // 
            // dgvPieIzquierdo
            // 
            this.dgvPieIzquierdo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPieIzquierdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieIzquierdo.ColumnHeadersVisible = false;
            this.dgvPieIzquierdo.Location = new System.Drawing.Point(323, 36);
            this.dgvPieIzquierdo.Name = "dgvPieIzquierdo";
            this.dgvPieIzquierdo.RowHeadersVisible = false;
            this.dgvPieIzquierdo.Size = new System.Drawing.Size(132, 176);
            this.dgvPieIzquierdo.TabIndex = 27;
            this.dgvPieIzquierdo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPieIzquierdo_CellContentClick);
            this.dgvPieIzquierdo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPieIzquierdo_CellPainting);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(849, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 25);
            this.button3.TabIndex = 32;
            this.button3.Text = "Realizar Hermanado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnConsultarSemaforo
            // 
            this.btnConsultarSemaforo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarSemaforo.Location = new System.Drawing.Point(728, 260);
            this.btnConsultarSemaforo.Name = "btnConsultarSemaforo";
            this.btnConsultarSemaforo.Size = new System.Drawing.Size(115, 25);
            this.btnConsultarSemaforo.TabIndex = 33;
            this.btnConsultarSemaforo.Text = "Consultar Semaforo";
            this.btnConsultarSemaforo.UseVisualStyleBackColor = true;
            this.btnConsultarSemaforo.Click += new System.EventHandler(this.btnConsultarSemaforo_Click);
            // 
            // btnVincularEmpleado
            // 
            this.btnVincularEmpleado.FlatAppearance.BorderSize = 0;
            this.btnVincularEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnVincularEmpleado.Image = global::Presentador.Properties.Resources.Vincular;
            this.btnVincularEmpleado.Location = new System.Drawing.Point(776, 149);
            this.btnVincularEmpleado.Name = "btnVincularEmpleado";
            this.btnVincularEmpleado.Size = new System.Drawing.Size(110, 87);
            this.btnVincularEmpleado.TabIndex = 35;
            this.btnVincularEmpleado.Text = "Vincular";
            this.btnVincularEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVincularEmpleado.UseVisualStyleBackColor = true;
            this.btnVincularEmpleado.Click += new System.EventHandler(this.btnVincularEmpleado_Click);
            // 
            // btnRenaudarOP
            // 
            this.btnRenaudarOP.FlatAppearance.BorderSize = 0;
            this.btnRenaudarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenaudarOP.ForeColor = System.Drawing.Color.White;
            this.btnRenaudarOP.Image = global::Presentador.Properties.Resources.Renaudar;
            this.btnRenaudarOP.Location = new System.Drawing.Point(783, 60);
            this.btnRenaudarOP.Name = "btnRenaudarOP";
            this.btnRenaudarOP.Size = new System.Drawing.Size(67, 83);
            this.btnRenaudarOP.TabIndex = 34;
            this.btnRenaudarOP.Text = "Renaudar";
            this.btnRenaudarOP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenaudarOP.UseVisualStyleBackColor = true;
            this.btnRenaudarOP.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFinalizarOP
            // 
            this.btnFinalizarOP.FlatAppearance.BorderSize = 0;
            this.btnFinalizarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarOP.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarOP.Image = global::Presentador.Properties.Resources.Finalizar;
            this.btnFinalizarOP.Location = new System.Drawing.Point(922, 64);
            this.btnFinalizarOP.Name = "btnFinalizarOP";
            this.btnFinalizarOP.Size = new System.Drawing.Size(68, 79);
            this.btnFinalizarOP.TabIndex = 31;
            this.btnFinalizarOP.Text = "Finalizar";
            this.btnFinalizarOP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarOP.UseVisualStyleBackColor = true;
            this.btnFinalizarOP.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPausarOP
            // 
            this.btnPausarOP.FlatAppearance.BorderSize = 0;
            this.btnPausarOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausarOP.ForeColor = System.Drawing.Color.White;
            this.btnPausarOP.Image = global::Presentador.Properties.Resources.Pausar;
            this.btnPausarOP.Location = new System.Drawing.Point(849, 58);
            this.btnPausarOP.Name = "btnPausarOP";
            this.btnPausarOP.Size = new System.Drawing.Size(67, 85);
            this.btnPausarOP.TabIndex = 30;
            this.btnPausarOP.Text = "Pausar";
            this.btnPausarOP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPausarOP.UseVisualStyleBackColor = true;
            this.btnPausarOP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesvincularEmpleado
            // 
            this.btnDesvincularEmpleado.FlatAppearance.BorderSize = 0;
            this.btnDesvincularEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesvincularEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnDesvincularEmpleado.Image = global::Presentador.Properties.Resources.Desvincular;
            this.btnDesvincularEmpleado.Location = new System.Drawing.Point(890, 149);
            this.btnDesvincularEmpleado.Name = "btnDesvincularEmpleado";
            this.btnDesvincularEmpleado.Size = new System.Drawing.Size(100, 87);
            this.btnDesvincularEmpleado.TabIndex = 29;
            this.btnDesvincularEmpleado.Text = "Desvincular";
            this.btnDesvincularEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesvincularEmpleado.UseVisualStyleBackColor = true;
            this.btnDesvincularEmpleado.Click += new System.EventHandler(this.btnDesvincularEmpleado_Click);
            // 
            // VistaAdministrarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btnVincularEmpleado);
            this.Controls.Add(this.btnRenaudarOP);
            this.Controls.Add(this.btnConsultarSemaforo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFinalizarOP);
            this.Controls.Add(this.btnPausarOP);
            this.Controls.Add(this.btnDesvincularEmpleado);
            this.Controls.Add(this.pnlPieIzquierdo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscarOrden);
            this.Controls.Add(this.btnBuscarOrden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.cbxTipoDefecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrdenProducciones);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "VistaAdministrarOrden";
            this.Text = "0";
            this.Load += new System.EventHandler(this.VistaAdministrarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenProducciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPieIzquierdo.ResumeLayout(false);
            this.pnlPieIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieDerecho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieIzquierdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenProducciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoDefecto;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarOrden;
        private System.Windows.Forms.TextBox txtBuscarOrden;
        private System.Windows.Forms.Label lblTotalIzquierdoPorHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPrimera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalDerecho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalIzquierda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPieIzquierdo;
        private System.Windows.Forms.DataGridView dgvPieIzquierdo;
        private System.Windows.Forms.ComboBox cbxDefecto;
        private System.Windows.Forms.Label lblTotalDerechoPorHora;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxPie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPieDerecho;
        private System.Windows.Forms.Button btnAgregarDefecto;
        private System.Windows.Forms.Button btnMasPrimera;
        private System.Windows.Forms.Button btnDesvincularEmpleado;
        private System.Windows.Forms.Button btnPausarOP;
        private System.Windows.Forms.Button btnFinalizarOP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConsultarSemaforo;
        private System.Windows.Forms.Button btnRenaudarOP;
        private System.Windows.Forms.Button btnVincularEmpleado;
        private System.Windows.Forms.Button btnMenosPrimera;
    }
}