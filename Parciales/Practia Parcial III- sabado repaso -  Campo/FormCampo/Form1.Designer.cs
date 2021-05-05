
namespace FormCampo
{
    partial class FrmPrincipal
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
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(51, 48);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(594, 85);
            this.btnMostrarDatos.TabIndex = 0;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(51, 155);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(607, 261);
            this.rtbSalidaDeTest.TabIndex = 1;
            this.rtbSalidaDeTest.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Controls.Add(this.btnMostrarDatos);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}

