
namespace ProjetoParOuImpar
{
    partial class frmParOuImpar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.radioPar = new System.Windows.Forms.RadioButton();
            this.radioImpar = new System.Windows.Forms.RadioButton();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fim:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(251, 168);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(117, 23);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(251, 197);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // radioPar
            // 
            this.radioPar.AutoSize = true;
            this.radioPar.Location = new System.Drawing.Point(278, 91);
            this.radioPar.Name = "radioPar";
            this.radioPar.Size = new System.Drawing.Size(41, 17);
            this.radioPar.TabIndex = 7;
            this.radioPar.TabStop = true;
            this.radioPar.Text = "Par";
            this.radioPar.UseVisualStyleBackColor = true;
            // 
            // radioImpar
            // 
            this.radioImpar.AutoSize = true;
            this.radioImpar.Location = new System.Drawing.Point(278, 129);
            this.radioImpar.Name = "radioImpar";
            this.radioImpar.Size = new System.Drawing.Size(51, 17);
            this.radioImpar.TabIndex = 8;
            this.radioImpar.TabStop = true;
            this.radioImpar.Text = "Impar";
            this.radioImpar.UseVisualStyleBackColor = true;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(91, 79);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(114, 20);
            this.txtInicio.TabIndex = 9;
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(82, 139);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(123, 20);
            this.txtFim.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(53, 242);
            this.lblResultado.Multiline = true;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.ReadOnly = true;
            this.lblResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lblResultado.Size = new System.Drawing.Size(315, 159);
            this.lblResultado.TabIndex = 11;
            // 
            // frmParOuImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 656);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.radioImpar);
            this.Controls.Add(this.radioPar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmParOuImpar";
            this.Text = "Tafareell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton radioPar;
        private System.Windows.Forms.RadioButton radioImpar;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.TextBox lblResultado;
    }
}

