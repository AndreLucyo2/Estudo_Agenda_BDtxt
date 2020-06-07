using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Estudo_Agenda_BDtxt.DAL;
using Estudo_Agenda_BDtxt.DTO;

namespace Estudo_Agenda_BDtxt.VIEW
{
    public partial class FRM_Cadastro : Form
    {
        public FRM_Cadastro()
        {
            InitializeComponent();

            MET_ControiLista();
        }

        //inserir um novo registro na lista:
        private void BtnGravar_Click(object sender, EventArgs e)
        {            
            //Validar se todos os campos estão preechidos:
            if (String.IsNullOrEmpty(TexNome.Text)  || String.IsNullOrEmpty(TexCel.Text)) 
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }

            // Verificar se registro ja existe:
            foreach (Contato V_Contato in GerenciaBD.XListaContatos)
            {
                if (V_Contato.nome == TexNome.Text && V_Contato.numero == TexCel.Text)
                {
                    MessageBox.Show("Erro!, Este contato ja Existe!");
                    return;
                }
            }

            //gravar novo registro:
            GerenciaBD.MET_GravarNovoRegistro(TexNome.Text, TexCel.Text);

            //atualizar a lista da tela:
            GerenciaBD.MET_CarregarListaContos();

            //Preparar campos para novo registro: limpar campos e deixar o campo nome ativo - video 072 22:00
            TexNome.Text = "";
            TexCel.Text = "";
            TexNome.Focus();
        }

        //=========================================================================================================================================================        
        private void MET_ControiLista() //adicona a lista os contatos registrados no txt
        {
            LSTB_Lista_Contatos.Items.Clear(); //limpar memoria da listabox

            foreach (Contato V_Contatos in GerenciaBD.XListaContatos) //para cada contato encontrado na colecao lista
            {
                LSTB_Lista_Contatos.Items.Add(V_Contatos.nome + " ( " + V_Contatos.numero + " )");
            }

            //Atualizar numero de gegistros:
            LBL_NumRegistros.Text = "Registros: " + LSTB_Lista_Contatos.Items.Count;

            //Impedir edição e eliminação do registro:
            BtnApagar.Enabled = false;
            BtnEditar.Enabled = false;

        }

    }
}
