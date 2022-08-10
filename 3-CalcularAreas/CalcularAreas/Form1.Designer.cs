
namespace CalcularAreas
{
    partial class frmCalcularAreas
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
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(403, 200);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(132, 29);
            this.btnRetangulo.TabIndex = 0;
            this.btnRetangulo.Text = "Triangulo";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(577, 162);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 37);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(403, 251);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(132, 29);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "Retangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Location = new System.Drawing.Point(403, 305);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(132, 29);
            this.btnQuadrado.TabIndex = 3;
            this.btnQuadrado.Text = "Quadrado";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(138, 182);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(63, 13);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base/Lado:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(138, 297);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(138, 233);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(141, 327);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(125, 20);
            this.txtResultado.TabIndex = 8;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(207, 179);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(131, 20);
            this.txtBase.TabIndex = 9;
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(181, 233);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(157, 20);
            this.txtAlt.TabIndex = 10;
            // 
            // frmCalcularAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 636);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRetangulo);
            this.Name = "frmCalcularAreas";
            this.Text = "Calcular Áreas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAlt;
    }
}

