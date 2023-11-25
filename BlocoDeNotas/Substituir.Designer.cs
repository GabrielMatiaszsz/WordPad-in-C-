
namespace BlocoDeNotas
{
    partial class Substituir
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
            this.txtBxLocaliza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSubstituir = new System.Windows.Forms.TextBox();
            this.bttnSubstitui = new System.Windows.Forms.Button();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLocaliza
            // 
            this.txtBxLocaliza.Location = new System.Drawing.Point(164, 39);
            this.txtBxLocaliza.Name = "txtBxLocaliza";
            this.txtBxLocaliza.Size = new System.Drawing.Size(327, 31);
            this.txtBxLocaliza.TabIndex = 0;
            this.txtBxLocaliza.TextChanged += new System.EventHandler(this.txtBxLocaliza_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Substituir por:";
            // 
            // txtBxSubstituir
            // 
            this.txtBxSubstituir.Location = new System.Drawing.Point(164, 101);
            this.txtBxSubstituir.Name = "txtBxSubstituir";
            this.txtBxSubstituir.Size = new System.Drawing.Size(327, 31);
            this.txtBxSubstituir.TabIndex = 3;
            // 
            // bttnSubstitui
            // 
            this.bttnSubstitui.Location = new System.Drawing.Point(508, 33);
            this.bttnSubstitui.Name = "bttnSubstitui";
            this.bttnSubstitui.Size = new System.Drawing.Size(232, 42);
            this.bttnSubstitui.TabIndex = 4;
            this.bttnSubstitui.Text = "Substituir tudo";
            this.bttnSubstitui.UseVisualStyleBackColor = true;
            this.bttnSubstitui.Click += new System.EventHandler(this.bttnSubstitui_Click);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(508, 101);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(232, 42);
            this.bttnCancelar.TabIndex = 5;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // Substituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.bttnCancelar);
            this.Controls.Add(this.bttnSubstitui);
            this.Controls.Add(this.txtBxSubstituir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxLocaliza);
            this.Name = "Substituir";
            this.Text = "Substituir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSubstituir;
        private System.Windows.Forms.Button bttnCancelar;
        public System.Windows.Forms.Button bttnSubstitui;
        public System.Windows.Forms.TextBox txtBxLocaliza;
    }
}