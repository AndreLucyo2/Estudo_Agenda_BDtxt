using Estudo_Agenda_BDtxt.CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_Agenda_BDtxt.VIEW
{
    public partial class FRM_Menu : Form
    {
        //Controller da View:
        private MenuController controller;

        public FRM_Menu()
        {
            InitializeComponent();

            controller = new MenuController(this);
            controller.LerArquivo();

        }

        private void CMD_Inserir_Editar_Click(object sender, EventArgs e)
        {
            FRM_Cadastro cadastro = new FRM_Cadastro();
            cadastro.ShowDialog();

        }

        private void CMD_Pesquisar_Click(object sender, EventArgs e)
        {
            FRM_Pesquisa pesquisa = new FRM_Pesquisa();
            pesquisa.ShowDialog();
        }

        private void CMD_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }


    }
}
