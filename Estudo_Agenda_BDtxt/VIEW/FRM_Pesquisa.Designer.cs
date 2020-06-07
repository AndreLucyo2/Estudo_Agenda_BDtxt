namespace Estudo_Agenda_BDtxt.VIEW
{
    partial class FRM_Pesquisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TexPesquisa = new System.Windows.Forms.TextBox();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TexPesquisa);
            this.panel1.Controls.Add(this.BtnPesquisa);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Texto de pesquisa:";
            // 
            // TexPesquisa
            // 
            this.TexPesquisa.Location = new System.Drawing.Point(12, 31);
            this.TexPesquisa.Name = "TexPesquisa";
            this.TexPesquisa.Size = new System.Drawing.Size(216, 20);
            this.TexPesquisa.TabIndex = 4;
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.AllowDrop = true;
            this.BtnPesquisa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnPesquisa.FlatAppearance.BorderSize = 0;
            this.BtnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisa.ForeColor = System.Drawing.Color.White;
            this.BtnPesquisa.Location = new System.Drawing.Point(12, 57);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(105, 35);
            this.BtnPesquisa.TabIndex = 6;
            this.BtnPesquisa.Text = "Pesquisar";
            this.BtnPesquisa.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AllowDrop = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(123, 57);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 35);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FRM_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 118);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pesquisar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TexPesquisa;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCancelar;
    }
}