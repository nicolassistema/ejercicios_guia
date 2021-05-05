
namespace Formulario_Jardin
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
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(610, 24);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(75, 23);
            this.btnVerDatos.TabIndex = 0;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(12, 53);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(673, 280);
            this.rtbSalidaDeTest.TabIndex = 1;
            this.rtbSalidaDeTest.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(698, 346);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Controls.Add(this.btnVerDatos);
            this.Name = "FrmPrincipal";
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDatos;
        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}

