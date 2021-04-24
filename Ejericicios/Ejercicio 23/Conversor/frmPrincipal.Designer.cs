
namespace Conversor
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label4 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.btnCovertEuro = new System.Windows.Forms.Button();
            this.btnCovertDolar = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cotizacion";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(16, 88);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(47, 20);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(16, 114);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(52, 20);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(18, 140);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 20);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoA.Location = new System.Drawing.Point(552, 51);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(49, 20);
            this.lblPesoA.TabIndex = 6;
            this.lblPesoA.Text = "Peso";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(425, 51);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(52, 20);
            this.lblDolarA.TabIndex = 5;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(303, 51);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(47, 20);
            this.lblEuroA.TabIndex = 4;
            this.lblEuroA.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(80, 82);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuro.TabIndex = 4;
            this.txtEuro.Leave += new System.EventHandler(this.txtEuro_Leave);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(80, 145);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(80, 114);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 5;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(3, 46);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 14;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(3, 77);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAEuro.TabIndex = 17;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(3, 14);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 11;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(128, 46);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 15;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(128, 77);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesoADolar.TabIndex = 18;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(128, 14);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 12;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(254, 46);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPeso.TabIndex = 16;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(254, 77);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPesoAPeso.TabIndex = 19;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(254, 14);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPeso.TabIndex = 13;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(527, 25);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionPeso.TabIndex = 3;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(401, 25);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionDolar.TabIndex = 2;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCotizacionEuro.Location = new System.Drawing.Point(276, 25);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 20);
            this.txtCotizacionEuro.TabIndex = 1;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // btnCovertEuro
            // 
            this.btnCovertEuro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCovertEuro.Location = new System.Drawing.Point(186, 80);
            this.btnCovertEuro.Name = "btnCovertEuro";
            this.btnCovertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnCovertEuro.TabIndex = 7;
            this.btnCovertEuro.Text = "->";
            this.btnCovertEuro.UseVisualStyleBackColor = true;
            this.btnCovertEuro.Click += new System.EventHandler(this.btnCovertEuro_Click);
            // 
            // btnCovertDolar
            // 
            this.btnCovertDolar.Location = new System.Drawing.Point(186, 112);
            this.btnCovertDolar.Name = "btnCovertDolar";
            this.btnCovertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnCovertDolar.TabIndex = 8;
            this.btnCovertDolar.Text = "->";
            this.btnCovertDolar.UseVisualStyleBackColor = true;
            this.btnCovertDolar.Click += new System.EventHandler(this.btnCovertDolar_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.Location = new System.Drawing.Point(186, 143);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPeso.TabIndex = 9;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageKey = "abierto.png";
            this.btnLockCotizacion.ImageList = this.Lock;
            this.btnLockCotizacion.Location = new System.Drawing.Point(186, 25);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(75, 23);
            this.btnLockCotizacion.TabIndex = 10;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // Lock
            // 
            this.Lock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Lock.ImageStream")));
            this.Lock.TransparentColor = System.Drawing.Color.Transparent;
            this.Lock.Images.SetKeyName(0, "abierto.png");
            this.Lock.Images.SetKeyName(1, "cerrado.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesoADolar);
            this.panel1.Controls.Add(this.txtPesoAPeso);
            this.panel1.Controls.Add(this.txtDolarAPeso);
            this.panel1.Controls.Add(this.txtEuroAEuro);
            this.panel1.Controls.Add(this.txtEuroAPeso);
            this.panel1.Controls.Add(this.txtDolarADolar);
            this.panel1.Controls.Add(this.txtPesoAEuro);
            this.panel1.Controls.Add(this.txtEuroADolar);
            this.panel1.Controls.Add(this.txtDolarAEuro);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(276, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 100);
            this.panel1.TabIndex = 27;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 190);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnCovertDolar);
            this.Controls.Add(this.btnCovertEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.Button btnCovertEuro;
        private System.Windows.Forms.Button btnCovertDolar;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.ImageList Lock;
        private System.Windows.Forms.Panel panel1;
    }
}

