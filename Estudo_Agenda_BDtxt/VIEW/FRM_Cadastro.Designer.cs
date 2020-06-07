namespace Estudo_Agenda_BDtxt.VIEW
{
    partial class FRM_Cadastro
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
            this.PnlGeral = new System.Windows.Forms.Panel();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LBL_NumRegistros = new System.Windows.Forms.Label();
            this.LblLista = new System.Windows.Forms.Label();
            this.ListBListaContatos = new System.Windows.Forms.ListBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.TexCel = new System.Windows.Forms.TextBox();
            this.LblCel = new System.Windows.Forms.Label();
            this.TexNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.PnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlGeral
            // 
            this.PnlGeral.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PnlGeral.Controls.Add(this.BtnEditar);
            this.PnlGeral.Controls.Add(this.BtnApagar);
            this.PnlGeral.Controls.Add(this.LBL_NumRegistros);
            this.PnlGeral.Controls.Add(this.LblLista);
            this.PnlGeral.Controls.Add(this.ListBListaContatos);
            this.PnlGeral.Controls.Add(this.BtnGravar);
            this.PnlGeral.Controls.Add(this.TexCel);
            this.PnlGeral.Controls.Add(this.LblCel);
            this.PnlGeral.Controls.Add(this.TexNome);
            this.PnlGeral.Controls.Add(this.LblNome);
            this.PnlGeral.Controls.Add(this.BtnFechar);
            this.PnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlGeral.Location = new System.Drawing.Point(0, 0);
            this.PnlGeral.Name = "PnlGeral";
            this.PnlGeral.Size = new System.Drawing.Size(562, 447);
            this.PnlGeral.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.AllowDrop = true;
            this.BtnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(173, 397);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(117, 38);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.AllowDrop = true;
            this.BtnApagar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnApagar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnApagar.FlatAppearance.BorderSize = 0;
            this.BtnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.ForeColor = System.Drawing.Color.White;
            this.BtnApagar.Location = new System.Drawing.Point(296, 397);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(117, 38);
            this.BtnApagar.TabIndex = 15;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = false;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // LBL_NumRegistros
            // 
            this.LBL_NumRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NumRegistros.Location = new System.Drawing.Point(54, 436);
            this.LBL_NumRegistros.Name = "LBL_NumRegistros";
            this.LBL_NumRegistros.Size = new System.Drawing.Size(208, 23);
            this.LBL_NumRegistros.TabIndex = 21;
            this.LBL_NumRegistros.Text = "Registros :00000";
            this.LBL_NumRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblLista
            // 
            this.LblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLista.ForeColor = System.Drawing.Color.White;
            this.LblLista.Location = new System.Drawing.Point(115, 114);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(420, 23);
            this.LblLista.TabIndex = 18;
            this.LblLista.Text = "Lista de contatos registrados:";
            this.LblLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListBListaContatos
            // 
            this.ListBListaContatos.FormattingEnabled = true;
            this.ListBListaContatos.Location = new System.Drawing.Point(118, 140);
            this.ListBListaContatos.Name = "ListBListaContatos";
            this.ListBListaContatos.Size = new System.Drawing.Size(417, 251);
            this.ListBListaContatos.TabIndex = 17;
            this.ListBListaContatos.SelectedIndexChanged += new System.EventHandler(this.ListBListaContatos_SelectedIndexChanged);
            // 
            // BtnGravar
            // 
            this.BtnGravar.AllowDrop = true;
            this.BtnGravar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnGravar.FlatAppearance.BorderSize = 0;
            this.BtnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.ForeColor = System.Drawing.Color.White;
            this.BtnGravar.Location = new System.Drawing.Point(118, 72);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(131, 32);
            this.BtnGravar.TabIndex = 13;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TexCel
            // 
            this.TexCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexCel.Location = new System.Drawing.Point(118, 42);
            this.TexCel.MaxLength = 14;
            this.TexCel.Name = "TexCel";
            this.TexCel.Size = new System.Drawing.Size(131, 24);
            this.TexCel.TabIndex = 12;
            // 
            // LblCel
            // 
            this.LblCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCel.ForeColor = System.Drawing.Color.White;
            this.LblCel.Location = new System.Drawing.Point(11, 42);
            this.LblCel.Name = "LblCel";
            this.LblCel.Size = new System.Drawing.Size(101, 23);
            this.LblCel.TabIndex = 19;
            this.LblCel.Text = "N° Celular:";
            this.LblCel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TexNome
            // 
            this.TexNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexNome.Location = new System.Drawing.Point(118, 12);
            this.TexNome.MaxLength = 50;
            this.TexNome.Name = "TexNome";
            this.TexNome.Size = new System.Drawing.Size(420, 24);
            this.TexNome.TabIndex = 11;
            // 
            // LblNome
            // 
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.ForeColor = System.Drawing.Color.White;
            this.LblNome.Location = new System.Drawing.Point(11, 12);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(101, 23);
            this.LblNome.TabIndex = 20;
            this.LblNome.Text = "Nome:";
            this.LblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BtnFechar.Location = new System.Drawing.Point(419, 397);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(117, 38);
            this.BtnFechar.TabIndex = 14;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FRM_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 447);
            this.Controls.Add(this.PnlGeral);
            this.Name = "FRM_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro/Lista";
            this.PnlGeral.ResumeLayout(false);
            this.PnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlGeral;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LBL_NumRegistros;
        private System.Windows.Forms.Label LblLista;
        private System.Windows.Forms.ListBox ListBListaContatos;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.TextBox TexCel;
        private System.Windows.Forms.Label LblCel;
        private System.Windows.Forms.TextBox TexNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnFechar;
    }
}