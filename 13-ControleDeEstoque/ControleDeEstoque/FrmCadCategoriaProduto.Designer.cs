
namespace ControleDeEstoque
{
    partial class FrmCadCategoriaProduto
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listCategoria = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdeCategorias = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(50, 264);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(266, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(50, 300);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(266, 50);
            this.btnCadastrarCategoria.TabIndex = 2;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastro de Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listCategoria
            // 
            this.listCategoria.HideSelection = false;
            this.listCategoria.Location = new System.Drawing.Point(414, 81);
            this.listCategoria.Name = "listCategoria";
            this.listCategoria.Size = new System.Drawing.Size(455, 375);
            this.listCategoria.TabIndex = 4;
            this.listCategoria.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de categorias: ";
            // 
            // lblQtdeCategorias
            // 
            this.lblQtdeCategorias.AutoSize = true;
            this.lblQtdeCategorias.Location = new System.Drawing.Point(181, 443);
            this.lblQtdeCategorias.Name = "lblQtdeCategorias";
            this.lblQtdeCategorias.Size = new System.Drawing.Size(0, 13);
            this.lblQtdeCategorias.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 173);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID:";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(50, 195);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(266, 20);
            this.txtIdCategoria.TabIndex = 7;
            // 
            // FrmCadCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(881, 540);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdCategoria);
            this.Controls.Add(this.lblQtdeCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadCategoriaProduto";
            this.Text = "Controle de Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtdeCategorias;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdCategoria;
    }
}