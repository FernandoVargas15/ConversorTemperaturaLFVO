namespace ConversorTemperaturaLFVO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Texto1 = new System.Windows.Forms.Label();
            this.TextoC = new System.Windows.Forms.Label();
            this.TextoF = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.BtFahrenheit = new System.Windows.Forms.Button();
            this.BtCelsius = new System.Windows.Forms.Button();
            this.LimpiarBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.BackColor = System.Drawing.Color.Transparent;
            this.Texto1.Font = new System.Drawing.Font("Roboto Bk", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto1.Location = new System.Drawing.Point(144, 45);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(496, 39);
            this.Texto1.TabIndex = 0;
            this.Texto1.Text = "CONVERSOR DE TEMPERATURA";
            // 
            // TextoC
            // 
            this.TextoC.AutoSize = true;
            this.TextoC.BackColor = System.Drawing.Color.Transparent;
            this.TextoC.Font = new System.Drawing.Font("Roboto Bk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoC.Location = new System.Drawing.Point(131, 141);
            this.TextoC.Name = "TextoC";
            this.TextoC.Size = new System.Drawing.Size(131, 20);
            this.TextoC.TabIndex = 1;
            this.TextoC.Text = "Grados Celsius:";
            // 
            // TextoF
            // 
            this.TextoF.AutoSize = true;
            this.TextoF.BackColor = System.Drawing.Color.Transparent;
            this.TextoF.Font = new System.Drawing.Font("Roboto Bk", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoF.Location = new System.Drawing.Point(519, 141);
            this.TextoF.Name = "TextoF";
            this.TextoF.Size = new System.Drawing.Size(156, 20);
            this.TextoF.TabIndex = 2;
            this.TextoF.Text = "Grados Fahrenheit:";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(116, 171);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(151, 22);
            this.txtCelsius.TabIndex = 3;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(519, 171);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(151, 22);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // BtFahrenheit
            // 
            this.BtFahrenheit.Font = new System.Drawing.Font("Roboto Bk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFahrenheit.Location = new System.Drawing.Point(116, 237);
            this.BtFahrenheit.Name = "BtFahrenheit";
            this.BtFahrenheit.Size = new System.Drawing.Size(151, 63);
            this.BtFahrenheit.TabIndex = 6;
            this.BtFahrenheit.Text = "Cambiar a Farenheit";
            this.BtFahrenheit.UseVisualStyleBackColor = true;
            this.BtFahrenheit.Click += new System.EventHandler(this.BtFahrenheit_Click);
            // 
            // BtCelsius
            // 
            this.BtCelsius.Font = new System.Drawing.Font("Roboto Bk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCelsius.Location = new System.Drawing.Point(519, 237);
            this.BtCelsius.Name = "BtCelsius";
            this.BtCelsius.Size = new System.Drawing.Size(151, 63);
            this.BtCelsius.TabIndex = 7;
            this.BtCelsius.Text = "Cambiar a Celcius";
            this.BtCelsius.UseVisualStyleBackColor = true;
            this.BtCelsius.Click += new System.EventHandler(this.BtCelsius_Click);
            // 
            // LimpiarBT
            // 
            this.LimpiarBT.Font = new System.Drawing.Font("Roboto Bk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBT.Location = new System.Drawing.Point(344, 314);
            this.LimpiarBT.Name = "LimpiarBT";
            this.LimpiarBT.Size = new System.Drawing.Size(102, 32);
            this.LimpiarBT.TabIndex = 8;
            this.LimpiarBT.Text = "LIMPIAR";
            this.LimpiarBT.UseVisualStyleBackColor = true;
            this.LimpiarBT.Click += new System.EventHandler(this.LimpiarBT_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(346, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 60);
            this.label1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(-4, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 122);
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(706, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 101);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarBT);
            this.Controls.Add(this.BtCelsius);
            this.Controls.Add(this.BtFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.TextoF);
            this.Controls.Add(this.TextoC);
            this.Controls.Add(this.Texto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texto1;
        private System.Windows.Forms.Label TextoC;
        private System.Windows.Forms.Label TextoF;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button BtFahrenheit;
        private System.Windows.Forms.Button BtCelsius;
        private System.Windows.Forms.Button LimpiarBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

