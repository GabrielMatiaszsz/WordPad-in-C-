
namespace BlocoDeNotas
{
    partial class Localizar
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
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnSubstitui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxLocaliza = new System.Windows.Forms.TextBox();
            this.chckBxCaseSensetive = new System.Windows.Forms.CheckBox();
            this.chckBxPalavraInteira = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(507, 122);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(232, 42);
            this.bttnCancelar.TabIndex = 9;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnSubstitui
            // 
            this.bttnSubstitui.Location = new System.Drawing.Point(507, 54);
            this.bttnSubstitui.Name = "bttnSubstitui";
            this.bttnSubstitui.Size = new System.Drawing.Size(232, 42);
            this.bttnSubstitui.TabIndex = 8;
            this.bttnSubstitui.Text = "Localizar todas...";
            this.bttnSubstitui.UseVisualStyleBackColor = true;
            this.bttnSubstitui.Click += new System.EventHandler(this.bttnSubstitui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Localizar:";
            // 
            // txtBxLocaliza
            // 
            this.txtBxLocaliza.Location = new System.Drawing.Point(163, 60);
            this.txtBxLocaliza.Name = "txtBxLocaliza";
            this.txtBxLocaliza.Size = new System.Drawing.Size(327, 31);
            this.txtBxLocaliza.TabIndex = 6;
            // 
            // chckBxCaseSensetive
            // 
            this.chckBxCaseSensetive.AutoSize = true;
            this.chckBxCaseSensetive.Location = new System.Drawing.Point(57, 112);
            this.chckBxCaseSensetive.Name = "chckBxCaseSensetive";
            this.chckBxCaseSensetive.Size = new System.Drawing.Size(406, 29);
            this.chckBxCaseSensetive.TabIndex = 10;
            this.chckBxCaseSensetive.Text = "Diferenciar maiusculas de minusculas";
            this.chckBxCaseSensetive.UseVisualStyleBackColor = true;
            // 
            // chckBxPalavraInteira
            // 
            this.chckBxPalavraInteira.AutoSize = true;
            this.chckBxPalavraInteira.Location = new System.Drawing.Point(57, 147);
            this.chckBxPalavraInteira.Name = "chckBxPalavraInteira";
            this.chckBxPalavraInteira.Size = new System.Drawing.Size(270, 29);
            this.chckBxPalavraInteira.TabIndex = 11;
            this.chckBxPalavraInteira.Text = "Coincidir palavra inteira";
            this.chckBxPalavraInteira.UseVisualStyleBackColor = true;
            // 
            // Localizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.chckBxPalavraInteira);
            this.Controls.Add(this.chckBxCaseSensetive);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnSubstitui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocaliza);
            this.Name = "Localizar";
            this.Text = "Localizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCancelar;
        public System.Windows.Forms.Button bttnSubstitui;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBxLocaliza;
        private System.Windows.Forms.CheckBox chckBxCaseSensetive;
        private System.Windows.Forms.CheckBox chckBxPalavraInteira;
    }
}