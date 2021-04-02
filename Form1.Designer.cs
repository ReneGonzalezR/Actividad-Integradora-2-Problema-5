
namespace Actividad_Integradora_2_Problema_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenor5 = new System.Windows.Forms.Button();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.btnTodas = new System.Windows.Forms.Button();
            this.btnMenorVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenor5
            // 
            this.btnMenor5.Location = new System.Drawing.Point(175, 60);
            this.btnMenor5.Name = "btnMenor5";
            this.btnMenor5.Size = new System.Drawing.Size(467, 58);
            this.btnMenor5.TabIndex = 0;
            this.btnMenor5.Text = "Ventas Menores a 5K";
            this.btnMenor5.UseVisualStyleBackColor = true;
            this.btnMenor5.Click += new System.EventHandler(this.btnMenor5_Click);
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(184, 316);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(467, 382);
            this.rtbDatos.TabIndex = 1;
            this.rtbDatos.Text = "";
            // 
            // btnTodas
            // 
            this.btnTodas.Location = new System.Drawing.Point(175, 142);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(467, 58);
            this.btnTodas.TabIndex = 2;
            this.btnTodas.Text = "Todas las Ventas de la Semana";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // btnMenorVenta
            // 
            this.btnMenorVenta.Location = new System.Drawing.Point(175, 224);
            this.btnMenorVenta.Name = "btnMenorVenta";
            this.btnMenorVenta.Size = new System.Drawing.Size(467, 58);
            this.btnMenorVenta.TabIndex = 3;
            this.btnMenorVenta.Text = "Dias con menor o ninguna venta";
            this.btnMenorVenta.UseVisualStyleBackColor = true;
            this.btnMenorVenta.Click += new System.EventHandler(this.btnMenorVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 810);
            this.Controls.Add(this.btnMenorVenta);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.btnMenor5);
            this.Name = "Form1";
            this.Text = "Actividad Integradora 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenor5;
        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.Button btnMenorVenta;
    }
}

