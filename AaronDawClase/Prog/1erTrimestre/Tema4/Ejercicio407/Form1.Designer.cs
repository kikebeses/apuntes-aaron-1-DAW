﻿namespace Ejercicio407
{
    partial class Form1
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.CNum2 = new System.Windows.Forms.TextBox();
            this.CNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(256, 277);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(269, 109);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Calcular M.C.D";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // CNum2
            // 
            this.CNum2.Location = new System.Drawing.Point(256, 196);
            this.CNum2.Name = "CNum2";
            this.CNum2.Size = new System.Drawing.Size(269, 20);
            this.CNum2.TabIndex = 1;
            // 
            // CNum1
            // 
            this.CNum1.Location = new System.Drawing.Point(256, 121);
            this.CNum1.Name = "CNum1";
            this.CNum1.Size = new System.Drawing.Size(269, 20);
            this.CNum1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CNum1);
            this.Controls.Add(this.CNum2);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.TextBox CNum2;
        private System.Windows.Forms.TextBox CNum1;
    }
}

