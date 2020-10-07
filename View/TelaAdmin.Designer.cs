namespace e_aquila.View
{
    partial class TelaAdmin
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
            this.adicionarP = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionarP
            // 
            this.adicionarP.Location = new System.Drawing.Point(299, 120);
            this.adicionarP.Name = "adicionarP";
            this.adicionarP.Size = new System.Drawing.Size(122, 36);
            this.adicionarP.TabIndex = 31;
            this.adicionarP.Text = "Cadastrar produto";
            this.adicionarP.UseVisualStyleBackColor = true;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(299, 208);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(122, 35);
            this.voltar.TabIndex = 30;
            this.voltar.Text = "Cadastrar Promoção";
            this.voltar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bem vindo administrador :)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cadastrar Familia de produtos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adicionarP);
            this.Controls.Add(this.voltar);
            this.Name = "TelaAdmin";
            this.Text = "TelaAdmin";
            this.Load += new System.EventHandler(this.TelaAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicionarP;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}