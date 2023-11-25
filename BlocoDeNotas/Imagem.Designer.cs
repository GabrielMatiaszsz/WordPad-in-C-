
namespace BlocoDeNotas
{
    partial class Imagem
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
            this.lblImagem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pctrBxAbrirImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxAbrirImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Location = new System.Drawing.Point(594, 40);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(201, 25);
            this.lblImagem.TabIndex = 1;
            this.lblImagem.Text = "Selecionar Imagem:";
            this.lblImagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imagem 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Imagem 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Imagem 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(599, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "Imagem 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pctrBxAbrirImagem
            // 
            this.pctrBxAbrirImagem.Location = new System.Drawing.Point(92, 40);
            this.pctrBxAbrirImagem.Name = "pctrBxAbrirImagem";
            this.pctrBxAbrirImagem.Size = new System.Drawing.Size(460, 460);
            this.pctrBxAbrirImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrBxAbrirImagem.TabIndex = 0;
            this.pctrBxAbrirImagem.TabStop = false;
            this.pctrBxAbrirImagem.Click += new System.EventHandler(this.pctrBxAbrirImagem_Click);
            // 
            // Imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 568);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.pctrBxAbrirImagem);
            this.Name = "Imagem";
            this.Text = "Imagem";
            this.Load += new System.EventHandler(this.Imagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxAbrirImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblImagem;
        public System.Windows.Forms.PictureBox pctrBxAbrirImagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}