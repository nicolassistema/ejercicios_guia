
namespace CuentaGanadoForm
{
    partial class FormContador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGente = new System.Windows.Forms.NumericUpDown();
            this.btnInforme = new System.Windows.Forms.Button();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownEmpleados
            // 
            this.numericUpDownEmpleados.Location = new System.Drawing.Point(144, 82);
            this.numericUpDownEmpleados.Name = "numericUpDownEmpleados";
            this.numericUpDownEmpleados.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEmpleados.TabIndex = 0;
            this.numericUpDownEmpleados.ValueChanged += new System.EventHandler(this.numericUpDownEmpleados_ValueChanged);
            // 
            // numericUpDownGente
            // 
            this.numericUpDownGente.Location = new System.Drawing.Point(144, 155);
            this.numericUpDownGente.Name = "numericUpDownGente";
            this.numericUpDownGente.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGente.TabIndex = 1;
            this.numericUpDownGente.ValueChanged += new System.EventHandler(this.numericUpDownGente_ValueChanged);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(144, 22);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(120, 23);
            this.btnInforme.TabIndex = 2;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Location = new System.Drawing.Point(54, 87);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(59, 13);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Location = new System.Drawing.Point(54, 160);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(36, 13);
            this.lblGente.TabIndex = 4;
            this.lblGente.Text = "Gente";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(57, 224);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(533, 150);
            this.dataGridView.TabIndex = 5;
            // 
            // FormContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 443);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.numericUpDownGente);
            this.Controls.Add(this.numericUpDownEmpleados);
            this.Name = "FormContador";
            this.Text = "Contador Nicolas Letticugna";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownEmpleados;
        private System.Windows.Forms.NumericUpDown numericUpDownGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

