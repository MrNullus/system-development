
namespace Calculador
{
    partial class frmCalculador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculador));
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.rdbTriangulo = new System.Windows.Forms.RadioButton();
            this.rdbCirculo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.rdbImc = new System.Windows.Forms.RadioButton();
            this.rdbParOuImpar = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(199, 201);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(132, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(199, 256);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(132, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(199, 311);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(132, 20);
            this.txtValor3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor 3:";
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(384, 222);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(74, 17);
            this.rdbSubtracao.TabIndex = 7;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(384, 245);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(87, 17);
            this.rdbMultiplicacao.TabIndex = 8;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.Location = new System.Drawing.Point(384, 268);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(60, 17);
            this.rdbDivisao.TabIndex = 9;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão";
            this.rdbDivisao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(381, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operações:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(488, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Calcular áreas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(491, 268);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 14;
            this.rdbRetangulo.TabStop = true;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            // 
            // rdbTriangulo
            // 
            this.rdbTriangulo.AutoSize = true;
            this.rdbTriangulo.Location = new System.Drawing.Point(491, 245);
            this.rdbTriangulo.Name = "rdbTriangulo";
            this.rdbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rdbTriangulo.TabIndex = 13;
            this.rdbTriangulo.TabStop = true;
            this.rdbTriangulo.Text = "Triângulo";
            this.rdbTriangulo.UseVisualStyleBackColor = true;
            // 
            // rdbCirculo
            // 
            this.rdbCirculo.AutoSize = true;
            this.rdbCirculo.Location = new System.Drawing.Point(491, 222);
            this.rdbCirculo.Name = "rdbCirculo";
            this.rdbCirculo.Size = new System.Drawing.Size(59, 17);
            this.rdbCirculo.TabIndex = 12;
            this.rdbCirculo.TabStop = true;
            this.rdbCirculo.Text = "Círculo";
            this.rdbCirculo.UseVisualStyleBackColor = true;
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Location = new System.Drawing.Point(491, 199);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rdbQuadrado.TabIndex = 11;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            // 
            // rdbImc
            // 
            this.rdbImc.AutoSize = true;
            this.rdbImc.Location = new System.Drawing.Point(384, 320);
            this.rdbImc.Name = "rdbImc";
            this.rdbImc.Size = new System.Drawing.Size(44, 17);
            this.rdbImc.TabIndex = 16;
            this.rdbImc.TabStop = true;
            this.rdbImc.Text = "IMC";
            this.rdbImc.UseVisualStyleBackColor = true;
            // 
            // rdbParOuImpar
            // 
            this.rdbParOuImpar.AutoSize = true;
            this.rdbParOuImpar.Location = new System.Drawing.Point(491, 317);
            this.rdbParOuImpar.Name = "rdbParOuImpar";
            this.rdbParOuImpar.Size = new System.Drawing.Size(85, 17);
            this.rdbParOuImpar.TabIndex = 21;
            this.rdbParOuImpar.TabStop = true;
            this.rdbParOuImpar.Text = "Par ou Impar";
            this.rdbParOuImpar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(198, 360);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(184, 48);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Outros cálculos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Resultado:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(205, 479);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 25;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(388, 360);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(196, 48);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbSoma.Location = new System.Drawing.Point(384, 199);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(52, 17);
            this.rdbSoma.TabIndex = 6;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // frmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(808, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbParOuImpar);
            this.Controls.Add(this.rdbImc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbRetangulo);
            this.Controls.Add(this.rdbTriangulo);
            this.Controls.Add(this.rdbCirculo);
            this.Controls.Add(this.rdbQuadrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbDivisao);
            this.Controls.Add(this.rdbMultiplicacao);
            this.Controls.Add(this.rdbSubtracao);
            this.Controls.Add(this.rdbSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCalculador";
            this.Text = "Calculador 1000";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbTriangulo;
        private System.Windows.Forms.RadioButton rdbCirculo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.RadioButton rdbImc;
        private System.Windows.Forms.RadioButton rdbParOuImpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbSoma;
    }
}

