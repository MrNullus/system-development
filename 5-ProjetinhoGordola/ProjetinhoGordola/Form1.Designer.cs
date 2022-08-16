
namespace ProjetinhoGordola
{
    partial class Form1
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.imgObesidade2 = new System.Windows.Forms.PictureBox();
            this.imgSobrepeso = new System.Windows.Forms.PictureBox();
            this.imgObesidade1 = new System.Windows.Forms.PictureBox();
            this.imgAbaixoPeso = new System.Windows.Forms.PictureBox();
            this.imgPesoNormal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobrepeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbaixoPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPesoNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(77, 105);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(77, 301);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(77, 226);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // imgObesidade2
            // 
            this.imgObesidade2.Image = global::ProjetinhoGordola.Properties.Resources.quilos_mortais_sean_milliken;
            this.imgObesidade2.Location = new System.Drawing.Point(245, 27);
            this.imgObesidade2.Name = "imgObesidade2";
            this.imgObesidade2.Size = new System.Drawing.Size(521, 373);
            this.imgObesidade2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgObesidade2.TabIndex = 9;
            this.imgObesidade2.TabStop = false;
            this.imgObesidade2.Visible = false;
            // 
            // imgSobrepeso
            // 
            this.imgSobrepeso.Image = global::ProjetinhoGordola.Properties.Resources.tipo3;
            this.imgSobrepeso.Location = new System.Drawing.Point(305, 27);
            this.imgSobrepeso.Name = "imgSobrepeso";
            this.imgSobrepeso.Size = new System.Drawing.Size(446, 297);
            this.imgSobrepeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSobrepeso.TabIndex = 8;
            this.imgSobrepeso.TabStop = false;
            this.imgSobrepeso.Visible = false;
            // 
            // imgObesidade1
            // 
            this.imgObesidade1.Image = global::ProjetinhoGordola.Properties.Resources.tipo4;
            this.imgObesidade1.Location = new System.Drawing.Point(258, 52);
            this.imgObesidade1.Name = "imgObesidade1";
            this.imgObesidade1.Size = new System.Drawing.Size(352, 298);
            this.imgObesidade1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgObesidade1.TabIndex = 7;
            this.imgObesidade1.TabStop = false;
            this.imgObesidade1.Visible = false;
            // 
            // imgAbaixoPeso
            // 
            this.imgAbaixoPeso.Image = global::ProjetinhoGordola.Properties.Resources.tipo1;
            this.imgAbaixoPeso.Location = new System.Drawing.Point(328, 27);
            this.imgAbaixoPeso.Name = "imgAbaixoPeso";
            this.imgAbaixoPeso.Size = new System.Drawing.Size(271, 219);
            this.imgAbaixoPeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAbaixoPeso.TabIndex = 6;
            this.imgAbaixoPeso.TabStop = false;
            this.imgAbaixoPeso.Visible = false;
            this.imgAbaixoPeso.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imgPesoNormal
            // 
            this.imgPesoNormal.Image = global::ProjetinhoGordola.Properties.Resources.tipo2;
            this.imgPesoNormal.Location = new System.Drawing.Point(305, 23);
            this.imgPesoNormal.Name = "imgPesoNormal";
            this.imgPesoNormal.Size = new System.Drawing.Size(286, 188);
            this.imgPesoNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPesoNormal.TabIndex = 2;
            this.imgPesoNormal.TabStop = false;
            this.imgPesoNormal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgObesidade2);
            this.Controls.Add(this.imgSobrepeso);
            this.Controls.Add(this.imgObesidade1);
            this.Controls.Add(this.imgAbaixoPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgPesoNormal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobrepeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgObesidade1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbaixoPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPesoNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox imgPesoNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.PictureBox imgObesidade1;
        private System.Windows.Forms.PictureBox imgSobrepeso;
        private System.Windows.Forms.PictureBox imgObesidade2;
        private System.Windows.Forms.PictureBox imgAbaixoPeso;
    }
}

