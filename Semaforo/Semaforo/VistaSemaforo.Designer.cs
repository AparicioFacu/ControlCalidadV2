
namespace Semaforo
{
    partial class VistaSemaforo
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
            this.dgvDefectos = new System.Windows.Forms.DataGridView();
            this.lblTotalDefectos = new System.Windows.Forms.Label();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblLimitesInferiorObservado = new System.Windows.Forms.Label();
            this.btnSemaforo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLimitesInferiorReproceso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLimitesSuperiorObservado = new System.Windows.Forms.Label();
            this.lblLimitesSuperiorReproceso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefectos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDefectos
            // 
            this.dgvDefectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefectos.Location = new System.Drawing.Point(73, 161);
            this.dgvDefectos.Name = "dgvDefectos";
            this.dgvDefectos.Size = new System.Drawing.Size(209, 226);
            this.dgvDefectos.TabIndex = 0;
            // 
            // lblTotalDefectos
            // 
            this.lblTotalDefectos.AutoSize = true;
            this.lblTotalDefectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDefectos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalDefectos.Location = new System.Drawing.Point(423, 397);
            this.lblTotalDefectos.Name = "lblTotalDefectos";
            this.lblTotalDefectos.Size = new System.Drawing.Size(122, 22);
            this.lblTotalDefectos.TabIndex = 1;
            this.lblTotalDefectos.Text = "TotalDefectos";
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.AutoSize = true;
            this.lblNumeroOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroOrden.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroOrden.Location = new System.Drawing.Point(103, 31);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(155, 22);
            this.lblNumeroOrden.TabIndex = 2;
            this.lblNumeroOrden.Text = "Orden Produccion";
            // 
            // lblLimitesInferiorObservado
            // 
            this.lblLimitesInferiorObservado.AutoSize = true;
            this.lblLimitesInferiorObservado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitesInferiorObservado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimitesInferiorObservado.Location = new System.Drawing.Point(228, 76);
            this.lblLimitesInferiorObservado.Name = "lblLimitesInferiorObservado";
            this.lblLimitesInferiorObservado.Size = new System.Drawing.Size(66, 22);
            this.lblLimitesInferiorObservado.TabIndex = 3;
            this.lblLimitesInferiorObservado.Text = "Limites";
            // 
            // btnSemaforo
            // 
            this.btnSemaforo.Location = new System.Drawing.Point(379, 210);
            this.btnSemaforo.Name = "btnSemaforo";
            this.btnSemaforo.Size = new System.Drawing.Size(190, 128);
            this.btnSemaforo.TabIndex = 4;
            this.btnSemaforo.Text = "Semaforo";
            this.btnSemaforo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Limite Inferior Observado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Limite Inferior Reproceso";
            // 
            // lblLimitesInferiorReproceso
            // 
            this.lblLimitesInferiorReproceso.AutoSize = true;
            this.lblLimitesInferiorReproceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitesInferiorReproceso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimitesInferiorReproceso.Location = new System.Drawing.Point(228, 110);
            this.lblLimitesInferiorReproceso.Name = "lblLimitesInferiorReproceso";
            this.lblLimitesInferiorReproceso.Size = new System.Drawing.Size(66, 22);
            this.lblLimitesInferiorReproceso.TabIndex = 8;
            this.lblLimitesInferiorReproceso.Text = "Limites";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(300, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Limite Superior Observado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(301, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Limite Superior Reproceso";
            // 
            // lblLimitesSuperiorObservado
            // 
            this.lblLimitesSuperiorObservado.AutoSize = true;
            this.lblLimitesSuperiorObservado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitesSuperiorObservado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimitesSuperiorObservado.Location = new System.Drawing.Point(529, 76);
            this.lblLimitesSuperiorObservado.Name = "lblLimitesSuperiorObservado";
            this.lblLimitesSuperiorObservado.Size = new System.Drawing.Size(66, 22);
            this.lblLimitesSuperiorObservado.TabIndex = 11;
            this.lblLimitesSuperiorObservado.Text = "Limites";
            // 
            // lblLimitesSuperiorReproceso
            // 
            this.lblLimitesSuperiorReproceso.AutoSize = true;
            this.lblLimitesSuperiorReproceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitesSuperiorReproceso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLimitesSuperiorReproceso.Location = new System.Drawing.Point(529, 110);
            this.lblLimitesSuperiorReproceso.Name = "lblLimitesSuperiorReproceso";
            this.lblLimitesSuperiorReproceso.Size = new System.Drawing.Size(66, 22);
            this.lblLimitesSuperiorReproceso.TabIndex = 12;
            this.lblLimitesSuperiorReproceso.Text = "Limites";
            // 
            // VistaSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(659, 495);
            this.Controls.Add(this.lblLimitesSuperiorReproceso);
            this.Controls.Add(this.lblLimitesSuperiorObservado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLimitesInferiorReproceso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSemaforo);
            this.Controls.Add(this.lblLimitesInferiorObservado);
            this.Controls.Add(this.lblNumeroOrden);
            this.Controls.Add(this.lblTotalDefectos);
            this.Controls.Add(this.dgvDefectos);
            this.Name = "VistaSemaforo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaSemaforo";
            this.Load += new System.EventHandler(this.VistaSemaforo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDefectos;
        private System.Windows.Forms.Label lblTotalDefectos;
        private System.Windows.Forms.Label lblNumeroOrden;
        private System.Windows.Forms.Label lblLimitesInferiorObservado;
        private System.Windows.Forms.Button btnSemaforo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimitesInferiorReproceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLimitesSuperiorObservado;
        private System.Windows.Forms.Label lblLimitesSuperiorReproceso;
    }
}