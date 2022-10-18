namespace Jogo_do_palito__Lucas__bonilha
{
    partial class Form1
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
            this.labelquantidade = new System.Windows.Forms.Label();
            this.nudquantidade = new System.Windows.Forms.NumericUpDown();
            this.btnjogar = new System.Windows.Forms.Button();
            this.labelretirar = new System.Windows.Forms.Label();
            this.mskdretirar = new System.Windows.Forms.MaskedTextBox();
            this.btnretirar = new System.Windows.Forms.Button();
            this.richTextBoxjogo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudquantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelquantidade
            // 
            this.labelquantidade.AutoSize = true;
            this.labelquantidade.Location = new System.Drawing.Point(63, 36);
            this.labelquantidade.Name = "labelquantidade";
            this.labelquantidade.Size = new System.Drawing.Size(161, 13);
            this.labelquantidade.TabIndex = 0;
            this.labelquantidade.Text = "Escolha a quantidade de palitos:";
            // 
            // nudquantidade
            // 
            this.nudquantidade.Location = new System.Drawing.Point(230, 34);
            this.nudquantidade.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudquantidade.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudquantidade.Name = "nudquantidade";
            this.nudquantidade.Size = new System.Drawing.Size(120, 20);
            this.nudquantidade.TabIndex = 1;
            this.nudquantidade.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnjogar
            // 
            this.btnjogar.Location = new System.Drawing.Point(372, 31);
            this.btnjogar.Name = "btnjogar";
            this.btnjogar.Size = new System.Drawing.Size(75, 23);
            this.btnjogar.TabIndex = 2;
            this.btnjogar.Text = "Jogar";
            this.btnjogar.UseVisualStyleBackColor = true;
            this.btnjogar.Click += new System.EventHandler(this.btnjogar_Click);
            // 
            // labelretirar
            // 
            this.labelretirar.AutoSize = true;
            this.labelretirar.Location = new System.Drawing.Point(63, 88);
            this.labelretirar.Name = "labelretirar";
            this.labelretirar.Size = new System.Drawing.Size(149, 13);
            this.labelretirar.TabIndex = 3;
            this.labelretirar.Text = "Quantos palitos deseja retirar?";
            this.labelretirar.Visible = false;
            // 
            // mskdretirar
            // 
            this.mskdretirar.Location = new System.Drawing.Point(230, 85);
            this.mskdretirar.Mask = "0";
            this.mskdretirar.Name = "mskdretirar";
            this.mskdretirar.Size = new System.Drawing.Size(120, 20);
            this.mskdretirar.TabIndex = 4;
            this.mskdretirar.ValidatingType = typeof(int);
            this.mskdretirar.Visible = false;
            // 
            // btnretirar
            // 
            this.btnretirar.Location = new System.Drawing.Point(372, 83);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(75, 23);
            this.btnretirar.TabIndex = 5;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Visible = false;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // richTextBoxjogo
            // 
            this.richTextBoxjogo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxjogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxjogo.Location = new System.Drawing.Point(0, 139);
            this.richTextBoxjogo.Name = "richTextBoxjogo";
            this.richTextBoxjogo.ReadOnly = true;
            this.richTextBoxjogo.Size = new System.Drawing.Size(855, 190);
            this.richTextBoxjogo.TabIndex = 6;
            this.richTextBoxjogo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(855, 329);
            this.Controls.Add(this.richTextBoxjogo);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.mskdretirar);
            this.Controls.Add(this.labelretirar);
            this.Controls.Add(this.btnjogar);
            this.Controls.Add(this.nudquantidade);
            this.Controls.Add(this.labelquantidade);
            this.Name = "Form1";
            this.Text = "Jogo do Palito (Lucas)";
            
            ((System.ComponentModel.ISupportInitialize)(this.nudquantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelquantidade;
        private System.Windows.Forms.NumericUpDown nudquantidade;
        private System.Windows.Forms.Button btnjogar;
        private System.Windows.Forms.Label labelretirar;
        private System.Windows.Forms.MaskedTextBox mskdretirar;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.RichTextBox richTextBoxjogo;
    }
}

