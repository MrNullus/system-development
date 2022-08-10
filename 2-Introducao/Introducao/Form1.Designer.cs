
namespace introducaonet
{
    partial class frmCalculadora
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblNumb1 = new System.Windows.Forms.Label();
            this.lblNumb2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtNumb1 = new System.Windows.Forms.TextBox();
            this.txtNumb2 = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(455, 310);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(115, 69);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumb1
            // 
            this.lblNumb1.AutoSize = true;
            this.lblNumb1.Location = new System.Drawing.Point(410, 60);
            this.lblNumb1.Name = "lblNumb1";
            this.lblNumb1.Size = new System.Drawing.Size(92, 13);
            this.lblNumb1.TabIndex = 1;
            this.lblNumb1.Text = "Digite um numero:";
            // 
            // lblNumb2
            // 
            this.lblNumb2.AutoSize = true;
            this.lblNumb2.Location = new System.Drawing.Point(410, 114);
            this.lblNumb2.Name = "lblNumb2";
            this.lblNumb2.Size = new System.Drawing.Size(89, 13);
            this.lblNumb2.TabIndex = 2;
            this.lblNumb2.Text = "Digite um numero";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(538, 192);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado:";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(413, 231);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(314, 20);
            this.txtResult.TabIndex = 4;
            // 
            // txtNumb1
            // 
            this.txtNumb1.Location = new System.Drawing.Point(505, 57);
            this.txtNumb1.Name = "txtNumb1";
            this.txtNumb1.Size = new System.Drawing.Size(222, 20);
            this.txtNumb1.TabIndex = 5;
            // 
            // txtNumb2
            // 
            this.txtNumb2.Location = new System.Drawing.Point(505, 111);
            this.txtNumb2.Name = "txtNumb2";
            this.txtNumb2.Size = new System.Drawing.Size(222, 20);
            this.txtNumb2.TabIndex = 6;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(564, 373);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(121, 64);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSub.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSub.Location = new System.Drawing.Point(568, 310);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(117, 66);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(454, 374);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(115, 64);
            this.btnMult.TabIndex = 10;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // frmCalculadora
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 569);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.txtNumb2);
            this.Controls.Add(this.txtNumb1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNumb2);
            this.Controls.Add(this.lblNumb1);
            this.Controls.Add(this.btnSoma);
            this.Name = "frmCalculadora";
            this.Text = "Calc 2000";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblNumb1;
        private System.Windows.Forms.Label lblNumb2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtNumb1;
        private System.Windows.Forms.TextBox txtNumb2;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
    }
}

