﻿namespace e_aquila.View
{
    partial class Cadastro
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
            this.nometxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpftxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pass2txt = new System.Windows.Forms.TextBox();
            this.pass1txt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(220, 99);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(124, 20);
            this.nometxt.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nome";
            // 
            // cpftxt
            // 
            this.cpftxt.Location = new System.Drawing.Point(220, 48);
            this.cpftxt.Name = "cpftxt";
            this.cpftxt.Size = new System.Drawing.Size(124, 20);
            this.cpftxt.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "CPF";
            // 
            // pass2txt
            // 
            this.pass2txt.Location = new System.Drawing.Point(220, 262);
            this.pass2txt.Name = "pass2txt";
            this.pass2txt.Size = new System.Drawing.Size(124, 20);
            this.pass2txt.TabIndex = 18;
            // 
            // pass1txt
            // 
            this.pass1txt.Location = new System.Drawing.Point(220, 205);
            this.pass1txt.Name = "pass1txt";
            this.pass1txt.Size = new System.Drawing.Size(124, 20);
            this.pass1txt.TabIndex = 17;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(220, 150);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(124, 20);
            this.usertxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirme a senha";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(238, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "User";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 372);
            this.Controls.Add(this.nometxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cpftxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pass2txt);
            this.Controls.Add(this.pass1txt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpftxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass2txt;
        private System.Windows.Forms.TextBox pass1txt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}