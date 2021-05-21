
namespace CollatzCount
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCollatz = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.btnRunCollatz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.lblResultSoma = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCollatz.SuspendLayout();
            this.pnlCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCollatz
            // 
            this.pnlCollatz.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCollatz.Controls.Add(this.lblList);
            this.pnlCollatz.Controls.Add(this.lblSequencia);
            this.pnlCollatz.Controls.Add(this.btnRunCollatz);
            this.pnlCollatz.Controls.Add(this.label3);
            this.pnlCollatz.Controls.Add(this.label1);
            this.pnlCollatz.Location = new System.Drawing.Point(41, 36);
            this.pnlCollatz.Name = "pnlCollatz";
            this.pnlCollatz.Size = new System.Drawing.Size(697, 606);
            this.pnlCollatz.TabIndex = 0;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(27, 253);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(492, 32);
            this.lblList.TabIndex = 4;
            this.lblList.Text = "O número que gera a maior sequência é ";
            this.lblList.Visible = false;
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequencia.Location = new System.Drawing.Point(27, 317);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(334, 32);
            this.lblSequencia.TabIndex = 3;
            this.lblSequencia.Text = "O tamanho da sequência é ";
            this.lblSequencia.Visible = false;
            // 
            // btnRunCollatz
            // 
            this.btnRunCollatz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRunCollatz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunCollatz.FlatAppearance.BorderSize = 0;
            this.btnRunCollatz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCollatz.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCollatz.Location = new System.Drawing.Point(114, 143);
            this.btnRunCollatz.Name = "btnRunCollatz";
            this.btnRunCollatz.Size = new System.Drawing.Size(436, 63);
            this.btnRunCollatz.TabIndex = 2;
            this.btnRunCollatz.Text = "Gerar";
            this.btnRunCollatz.UseVisualStyleBackColor = false;
            this.btnRunCollatz.Click += new System.EventHandler(this.btnRunCollatz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "a maior sequência de Collatz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clique em Gerar para descobrir o número que gera ";
            // 
            // pnlCount
            // 
            this.pnlCount.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCount.Controls.Add(this.lblResultSoma);
            this.pnlCount.Controls.Add(this.btnCount);
            this.pnlCount.Controls.Add(this.lblMatriz);
            this.pnlCount.Controls.Add(this.label5);
            this.pnlCount.Controls.Add(this.label2);
            this.pnlCount.Location = new System.Drawing.Point(757, 36);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(736, 606);
            this.pnlCount.TabIndex = 1;
            // 
            // lblResultSoma
            // 
            this.lblResultSoma.AutoSize = true;
            this.lblResultSoma.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultSoma.Location = new System.Drawing.Point(157, 518);
            this.lblResultSoma.Name = "lblResultSoma";
            this.lblResultSoma.Size = new System.Drawing.Size(285, 32);
            this.lblResultSoma.TabIndex = 4;
            this.lblResultSoma.Text = "O resultado da soma é ";
            this.lblResultSoma.Visible = false;
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.FlatAppearance.BorderSize = 0;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(163, 432);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(436, 63);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Somar";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriz.Location = new System.Drawing.Point(159, 116);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(0, 20);
            this.lblMatriz.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "dos números da pirâmide abaixo.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calcule a rota com a maior soma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 725);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Powered by Lucas Cruz";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1592, 766);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlCount);
            this.Controls.Add(this.pnlCollatz);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solução Collatz e Soma Recursiva";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlCollatz.ResumeLayout(false);
            this.pnlCollatz.PerformLayout();
            this.pnlCount.ResumeLayout(false);
            this.pnlCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCollatz;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.Button btnRunCollatz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.Label lblResultSoma;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label label4;
    }
}

