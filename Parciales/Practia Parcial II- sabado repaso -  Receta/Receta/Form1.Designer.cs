﻿
namespace Formulario
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
            this.btnImprimirReceta = new System.Windows.Forms.Button();
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnImprimirReceta
            // 
            this.btnImprimirReceta.Location = new System.Drawing.Point(12, 255);
            this.btnImprimirReceta.Name = "btnImprimirReceta";
            this.btnImprimirReceta.Size = new System.Drawing.Size(641, 57);
            this.btnImprimirReceta.TabIndex = 0;
            this.btnImprimirReceta.Text = "Imprimir Receta";
            this.btnImprimirReceta.UseVisualStyleBackColor = true;
            this.btnImprimirReceta.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(12, 12);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(641, 237);
            this.rtbSalidaDeTest.TabIndex = 1;
            this.rtbSalidaDeTest.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 329);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.Controls.Add(this.btnImprimirReceta);
            this.Name = "FrmPrincipal";
            this.Text = "Receta";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirReceta;
        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
    }
}

