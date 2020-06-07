using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Estudo_Agenda_BDtxt.CONTROLLER;
using Estudo_Agenda_BDtxt.DAL;
using Estudo_Agenda_BDtxt.DTO;

namespace Estudo_Agenda_BDtxt.VIEW
{
    public partial class FRM_Cadastro : Form
    {
        // variavel visivel por toda classe:
        int Indice; // variavel para guardar a indice da linha selecionada

        //Controller da View:
        private CadastroController controller;

        public FRM_Cadastro()
        {
            InitializeComponent();

            //Instacia o Controller da view:
            controller = new CadastroController(this);
            controller.AtualizarListaNaTela();
        }

        //inserir um novo registro na lista:
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            controller.Gravar();
        }

        //=========================================================================================================================================================        
        private void MET_ControiLista() //adicona a lista os contatos registrados no txt
        {
            controller.AtualizarListaNaTela();

            //Impedir edição e eliminação do registro:
            BtnApagar.Enabled = false;
            BtnEditar.Enabled = false;

        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            controller.Excluir(Indice);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            controller.Atualizar(Indice);
        }

        private void ListBListaContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se indice = -1 ou seja nada selecionado:
            if (ListBListaContatos.SelectedIndex == -1) return;

            //seleciona um indic da linha:
            Indice = ListBListaContatos.SelectedIndex; //guarda valor da linha em um indice

            //SO ATIVA OS BOTOES SE TIVEL UMA LINHA SELECIONADA:
            BtnEditar.Enabled = true;
            BtnApagar.Enabled = true;
        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //pergunta se quer fechar:
            if (MessageBox.Show("Fechar tela de Cadastros?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            this.Close();
        }

        //=========================================================================================================================================================
        // Get and Set Campos:
        //=========================================================================================================================================================
        public TextBox getNome()
        {
            return this.TexNome;
        }
        public void setNome(TextBox TexNome)
        {
            this.TexNome = TexNome;
        }

        public TextBox getCel()
        {
            return this.TexCel;
        }
        public void setCel(TextBox TexCel)
        {
            this.TexCel = TexCel;
        }

        public ListBox getListB()
        {
            return this.ListBListaContatos;
        }
        public void setListB(ListBox ListB)
        {
            this.ListBListaContatos = ListB;
        }

        public Label getLblNumReg()
        {
            return this.LBL_NumRegistros;
        }
        public void setLblNumReg(Label label)
        {
            this.LBL_NumRegistros = label;
        }


    }
}
