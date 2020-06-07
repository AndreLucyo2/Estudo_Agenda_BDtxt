namespace Estudo_Agenda_BDtxt.VIEW
{
    partial class FRM_Menu
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
            this.LBL_Versao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMD_Sair = new System.Windows.Forms.Button();
            this.CMD_Pesquisar = new System.Windows.Forms.Button();
            this.CMD_Inserir_Editar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.LBL_Versao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CMD_Sair);
            this.panel1.Controls.Add(this.CMD_Pesquisar);
            this.panel1.Controls.Add(this.CMD_Inserir_Editar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 287);
            this.panel1.TabIndex = 0;
            // 
            // LBL_Versao
            // 
            this.LBL_Versao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Versao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LBL_Versao.Location = new System.Drawing.Point(3, 245);
            this.LBL_Versao.Name = "LBL_Versao";
            this.LBL_Versao.Size = new System.Drawing.Size(186, 25);
            this.LBL_Versao.TabIndex = 8;
            this.LBL_Versao.Text = "Apresenta versao do sistema";
            this.LBL_Versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(34, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agenda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMD_Sair
            // 
            this.CMD_Sair.AllowDrop = true;
            this.CMD_Sair.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CMD_Sair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Sair.FlatAppearance.BorderSize = 0;
            this.CMD_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Sair.ForeColor = System.Drawing.Color.White;
            this.CMD_Sair.Location = new System.Drawing.Point(15, 181);
            this.CMD_Sair.Name = "CMD_Sair";
            this.CMD_Sair.Size = new System.Drawing.Size(174, 52);
            this.CMD_Sair.TabIndex = 7;
            this.CMD_Sair.Text = "Sair";
            this.CMD_Sair.UseVisualStyleBackColor = false;
            this.CMD_Sair.Click += new System.EventHandler(this.CMD_Sair_Click);
            // 
            // CMD_Pesquisar
            // 
            this.CMD_Pesquisar.AllowDrop = true;
            this.CMD_Pesquisar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CMD_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Pesquisar.FlatAppearance.BorderSize = 0;
            this.CMD_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.CMD_Pesquisar.Location = new System.Drawing.Point(15, 123);
            this.CMD_Pesquisar.Name = "CMD_Pesquisar";
            this.CMD_Pesquisar.Size = new System.Drawing.Size(174, 52);
            this.CMD_Pesquisar.TabIndex = 6;
            this.CMD_Pesquisar.Text = "Pesquisar";
            this.CMD_Pesquisar.UseVisualStyleBackColor = false;
            this.CMD_Pesquisar.Click += new System.EventHandler(this.CMD_Pesquisar_Click);
            // 
            // CMD_Inserir_Editar
            // 
            this.CMD_Inserir_Editar.AllowDrop = true;
            this.CMD_Inserir_Editar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CMD_Inserir_Editar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Inserir_Editar.FlatAppearance.BorderSize = 0;
            this.CMD_Inserir_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CMD_Inserir_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMD_Inserir_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMD_Inserir_Editar.ForeColor = System.Drawing.Color.White;
            this.CMD_Inserir_Editar.Location = new System.Drawing.Point(15, 65);
            this.CMD_Inserir_Editar.Name = "CMD_Inserir_Editar";
            this.CMD_Inserir_Editar.Size = new System.Drawing.Size(174, 52);
            this.CMD_Inserir_Editar.TabIndex = 5;
            this.CMD_Inserir_Editar.Text = "Inserir/Editar";
            this.CMD_Inserir_Editar.UseVisualStyleBackColor = false;
            this.CMD_Inserir_Editar.Click += new System.EventHandler(this.CMD_Inserir_Editar_Click);
            // 
            // FRM_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 287);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Versao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CMD_Sair;
        private System.Windows.Forms.Button CMD_Pesquisar;
        private System.Windows.Forms.Button CMD_Inserir_Editar;
    }
}