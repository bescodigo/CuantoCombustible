
namespace CuantoCombustible
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
            this.txtDistanciaKilometros = new System.Windows.Forms.TextBox();
            this.txtConsumoCombustible = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioCombustible = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDistanciaKilometros
            // 
            this.txtDistanciaKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistanciaKilometros.Location = new System.Drawing.Point(198, 139);
            this.txtDistanciaKilometros.Name = "txtDistanciaKilometros";
            this.txtDistanciaKilometros.Size = new System.Drawing.Size(126, 20);
            this.txtDistanciaKilometros.TabIndex = 0;
            // 
            // txtConsumoCombustible
            // 
            this.txtConsumoCombustible.BackColor = System.Drawing.Color.Black;
            this.txtConsumoCombustible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConsumoCombustible.Enabled = false;
            this.txtConsumoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumoCombustible.ForeColor = System.Drawing.Color.Green;
            this.txtConsumoCombustible.Location = new System.Drawing.Point(198, 203);
            this.txtConsumoCombustible.Name = "txtConsumoCombustible";
            this.txtConsumoCombustible.Size = new System.Drawing.Size(126, 20);
            this.txtConsumoCombustible.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Black;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotal.Location = new System.Drawing.Point(198, 256);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Distancia en Kilometros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consumo de combustible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gasto Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Se a introducido un valor aproximado en el precio del combustible, \r\nsi quieres p" +
    "uedes cambiarlo para tener un resultado mas aproximado.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio del combustible:";
            // 
            // txtPrecioCombustible
            // 
            this.txtPrecioCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCombustible.Location = new System.Drawing.Point(198, 85);
            this.txtPrecioCombustible.Name = "txtPrecioCombustible";
            this.txtPrecioCombustible.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioCombustible.TabIndex = 9;
            this.txtPrecioCombustible.Text = "80";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(2, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.SpringGreen;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(198, 305);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 40);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseMnemonic = false;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Lts.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 373);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioCombustible);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtConsumoCombustible);
            this.Controls.Add(this.txtDistanciaKilometros);
            this.Name = "Form1";
            this.Text = "Cuanto Combustible Consumo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistanciaKilometros;
        private System.Windows.Forms.TextBox txtConsumoCombustible;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioCombustible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
    }
}

