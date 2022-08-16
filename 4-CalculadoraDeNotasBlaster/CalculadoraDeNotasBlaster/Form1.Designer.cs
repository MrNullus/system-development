
namespace CalculadoraDeNotasBlaster
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgReprovado = new System.Windows.Forms.PictureBox();
            this.imgRecuperacao = new System.Windows.Forms.PictureBox();
            this.imgAprovado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgReprovado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecuperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAprovado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nota 1 ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(47, 70);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 5;
            this.txtNota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(48, 218);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(48, 149);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nota 2";
            // 
            // imgReprovado
            // 
            this.imgReprovado.Image = global::CalculadoraDeNotasBlaster.Properties.Resources.GmFqACGAkQ7a1JKLdZDnZQaiZyFVwH0y64ulO0XS;
            this.imgReprovado.Location = new System.Drawing.Point(274, 114);
            this.imgReprovado.Name = "imgReprovado";
            this.imgReprovado.Size = new System.Drawing.Size(306, 237);
            this.imgReprovado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgReprovado.TabIndex = 3;
            this.imgReprovado.TabStop = false;
            this.imgReprovado.Visible = false;
            // 
            // imgRecuperacao
            // 
            this.imgRecuperacao.Image = global::CalculadoraDeNotasBlaster.Properties.Resources.images;
            this.imgRecuperacao.Location = new System.Drawing.Point(257, 114);
            this.imgRecuperacao.Name = "imgRecuperacao";
            this.imgRecuperacao.Size = new System.Drawing.Size(331, 221);
            this.imgRecuperacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRecuperacao.TabIndex = 2;
            this.imgRecuperacao.TabStop = false;
            this.imgRecuperacao.Visible = false;
            this.imgRecuperacao.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imgAprovado
            // 
            this.imgAprovado.Image = global::CalculadoraDeNotasBlaster.Properties.Resources.iran_santana_o_luva_de_pedreiro_1659552598392_v2_450x800;
            this.imgAprovado.Location = new System.Drawing.Point(274, 45);
            this.imgAprovado.Name = "imgAprovado";
            this.imgAprovado.Size = new System.Drawing.Size(290, 330);
            this.imgAprovado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAprovado.TabIndex = 1;
            this.imgAprovado.TabStop = false;
            this.imgAprovado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgReprovado);
            this.Controls.Add(this.imgRecuperacao);
            this.Controls.Add(this.imgAprovado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgReprovado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecuperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAprovado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox imgAprovado;
        private System.Windows.Forms.PictureBox imgRecuperacao;
        private System.Windows.Forms.PictureBox imgReprovado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

