
namespace CurriculoVitae
{
    partial class frmCurriculo
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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblMsgCpf = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnder = new System.Windows.Forms.TextBox();
            this.lblMsgTelefone = new System.Windows.Forms.Label();
            this.lblMsgEnder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(112, 87);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(156, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(112, 308);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblMsgCpf
            // 
            this.lblMsgCpf.AutoSize = true;
            this.lblMsgCpf.Location = new System.Drawing.Point(116, 136);
            this.lblMsgCpf.Name = "lblMsgCpf";
            this.lblMsgCpf.Size = new System.Drawing.Size(0, 13);
            this.lblMsgCpf.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(112, 165);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(156, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // txtEnder
            // 
            this.txtEnder.Location = new System.Drawing.Point(112, 243);
            this.txtEnder.Multiline = true;
            this.txtEnder.Name = "txtEnder";
            this.txtEnder.Size = new System.Drawing.Size(156, 29);
            this.txtEnder.TabIndex = 8;
            // 
            // lblMsgTelefone
            // 
            this.lblMsgTelefone.AutoSize = true;
            this.lblMsgTelefone.Location = new System.Drawing.Point(116, 188);
            this.lblMsgTelefone.Name = "lblMsgTelefone";
            this.lblMsgTelefone.Size = new System.Drawing.Size(0, 13);
            this.lblMsgTelefone.TabIndex = 9;
            // 
            // lblMsgEnder
            // 
            this.lblMsgEnder.AutoSize = true;
            this.lblMsgEnder.Location = new System.Drawing.Point(116, 275);
            this.lblMsgEnder.Name = "lblMsgEnder";
            this.lblMsgEnder.Size = new System.Drawing.Size(0, 13);
            this.lblMsgEnder.TabIndex = 10;
            // 
            // frmCurriculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 595);
            this.Controls.Add(this.lblMsgEnder);
            this.Controls.Add(this.lblMsgTelefone);
            this.Controls.Add(this.txtEnder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblMsgCpf);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label1);
            this.Name = "frmCurriculo";
            this.Text = "Curriculo Vitae";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblMsgCpf;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnder;
        private System.Windows.Forms.Label lblMsgTelefone;
        private System.Windows.Forms.Label lblMsgEnder;
    }
}

