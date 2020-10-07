namespace e_aquila.View
{
    partial class ProdutoSelec
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
            this.titulo = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.descricao = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.estoque = new System.Windows.Forms.Label();
            this.comprar = new System.Windows.Forms.Button();
            this.aviso = new System.Windows.Forms.Button();
            this.newP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(168, 64);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(35, 13);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "label1";
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(369, 312);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 35);
            this.voltar.TabIndex = 19;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 183);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(266, 64);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(35, 13);
            this.descricao.TabIndex = 21;
            this.descricao.Text = "label2";
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(266, 104);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(35, 13);
            this.preco.TabIndex = 22;
            this.preco.Text = "label3";
            // 
            // estoque
            // 
            this.estoque.AutoSize = true;
            this.estoque.Location = new System.Drawing.Point(266, 143);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(35, 13);
            this.estoque.TabIndex = 23;
            this.estoque.Text = "label4";
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(256, 311);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(75, 36);
            this.comprar.TabIndex = 24;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            // 
            // aviso
            // 
            this.aviso.Location = new System.Drawing.Point(256, 311);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(75, 36);
            this.aviso.TabIndex = 25;
            this.aviso.Text = "Avise-Me";
            this.aviso.UseVisualStyleBackColor = true;
            // 
            // newP
            // 
            this.newP.AutoSize = true;
            this.newP.ForeColor = System.Drawing.Color.Maroon;
            this.newP.Location = new System.Drawing.Point(250, 27);
            this.newP.Name = "newP";
            this.newP.Size = new System.Drawing.Size(81, 13);
            this.newP.TabIndex = 26;
            this.newP.Text = "LANÇAMENTO";
            this.newP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "label2";
            // 
            // addP
            // 
            this.addP.Location = new System.Drawing.Point(482, 311);
            this.addP.Name = "addP";
            this.addP.Size = new System.Drawing.Size(90, 36);
            this.addP.TabIndex = 29;
            this.addP.Text = "Adicionar mais produtos";
            this.addP.UseVisualStyleBackColor = true;
            this.addP.Click += new System.EventHandler(this.addP_Click);
            // 
            // ProdutoSelec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 407);
            this.Controls.Add(this.addP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newP);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.estoque);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.titulo);
            this.Name = "ProdutoSelec";
            this.Text = "ProdutoSelec";
            this.Load += new System.EventHandler(this.ProdutoSelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.Label estoque;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Button aviso;
        private System.Windows.Forms.Label newP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addP;
    }
}