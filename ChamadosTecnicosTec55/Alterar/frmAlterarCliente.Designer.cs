namespace ChamadosTecnicosTec55.Alterar
{
    partial class frmAlterarCliente
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbSetor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbObs = new System.Windows.Forms.TextBox();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Cliente";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(17, 88);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(330, 26);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profissão";
            // 
            // txbProf
            // 
            this.txbProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProf.Location = new System.Drawing.Point(17, 150);
            this.txbProf.Name = "txbProf";
            this.txbProf.Size = new System.Drawing.Size(330, 26);
            this.txbProf.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Setor";
            // 
            // TxbSetor
            // 
            this.TxbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbSetor.Location = new System.Drawing.Point(17, 217);
            this.TxbSetor.Name = "TxbSetor";
            this.TxbSetor.Size = new System.Drawing.Size(330, 26);
            this.TxbSetor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Obs";
            // 
            // TxbObs
            // 
            this.TxbObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbObs.Location = new System.Drawing.Point(17, 284);
            this.TxbObs.Multiline = true;
            this.TxbObs.Name = "TxbObs";
            this.TxbObs.Size = new System.Drawing.Size(330, 93);
            this.TxbObs.TabIndex = 7;
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(247, 24);
            this.txbCod.Name = "txbCod";
            this.txbCod.ReadOnly = true;
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(132, 395);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 428);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxbObs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbSetor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterarCliente";
            this.Text = "frmAlterarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbSetor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbObs;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Button btnOk;
    }
}