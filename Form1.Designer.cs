namespace Sorteador
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumIni = new System.Windows.Forms.TextBox();
            this.txtNumFim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Inicial";
            // 
            // txtNumIni
            // 
            this.txtNumIni.Location = new System.Drawing.Point(191, 29);
            this.txtNumIni.Name = "txtNumIni";
            this.txtNumIni.Size = new System.Drawing.Size(100, 20);
            this.txtNumIni.TabIndex = 1;
            // 
            // txtNumFim
            // 
            this.txtNumFim.Location = new System.Drawing.Point(191, 68);
            this.txtNumFim.Name = "txtNumFim";
            this.txtNumFim.Size = new System.Drawing.Size(100, 20);
            this.txtNumFim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número Final";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(191, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sortear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumIni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "[SORTEADOR]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumIni;
        private System.Windows.Forms.TextBox txtNumFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

