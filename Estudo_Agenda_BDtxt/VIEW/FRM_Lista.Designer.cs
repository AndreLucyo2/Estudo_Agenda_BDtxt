namespace Estudo_Agenda_BDtxt.VIEW
{
    partial class FRM_Lista
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
            this.LblNumReg = new System.Windows.Forms.Label();
            this.ListLista = new System.Windows.Forms.ListBox();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.LblNumReg);
            this.panel1.Controls.Add(this.ListLista);
            this.panel1.Controls.Add(this.BtnPesquisa);
            this.panel1.Controls.Add(this.BtnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 294);
            this.panel1.TabIndex = 0;
            // 
            // LblNumReg
            // 
            this.LblNumReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumReg.ForeColor = System.Drawing.Color.White;
            this.LblNumReg.Location = new System.Drawing.Point(14, 202);
            this.LblNumReg.Name = "LblNumReg";
            this.LblNumReg.Size = new System.Drawing.Size(208, 23);
            this.LblNumReg.TabIndex = 15;
            this.LblNumReg.Text = "Registros :00000";
            this.LblNumReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListLista
            // 
            this.ListLista.FormattingEnabled = true;
            this.ListLista.Location = new System.Drawing.Point(12, 12);
            this.ListLista.Name = "ListLista";
            this.ListLista.Size = new System.Drawing.Size(380, 186);
            this.ListLista.TabIndex = 14;
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
            this.BtnPesquisa.Location = new System.Drawing.Point(152, 238);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(117, 38);
            this.BtnPesquisa.TabIndex = 13;
            this.BtnPesquisa.Text = "Nova Pesquisa";
            this.BtnPesquisa.UseVisualStyleBackColor = false;
            // 
            // BtnFechar
            // 
            this.BtnFechar.AllowDrop = true;
            this.BtnFechar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(275, 238);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(117, 38);
            this.BtnFechar.TabIndex = 12;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            // 
            // FRM_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 294);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Lista";
            this.Text = "Listagem";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNumReg;
        private System.Windows.Forms.ListBox ListLista;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnFechar;
    }
}