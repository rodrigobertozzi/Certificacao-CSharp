using System;
using System.Windows;
using System.Runtime.InteropServices;

namespace _01._4.IDisposable_Finalizador
{
    partial class FrmMensagem
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensagem.Location = new System.Drawing.Point(24, 77);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(304, 30);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMensagem.Location = new System.Drawing.Point(89, 125);
            this.btnMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(246, 55);
            this.btnMensagem.TabIndex = 1;
            this.btnMensagem.Text = "Enviar para Notepad";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mensagem:";
            // 
            // FrmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMensagem";
            this.Text = "Mensageiro Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Label label1;

    }
}

