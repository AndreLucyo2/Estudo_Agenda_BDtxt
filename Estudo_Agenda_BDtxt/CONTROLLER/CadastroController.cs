using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Estudo_Agenda_BDtxt.BLL;
using Estudo_Agenda_BDtxt.DAL;
using Estudo_Agenda_BDtxt.DTO;
using Estudo_Agenda_BDtxt.VIEW;

namespace Estudo_Agenda_BDtxt.CONTROLLER
{
    public class CadastroController
    {
        //Recebe uma view Form:
        private FRM_Cadastro view;

        //public static List<DTO_Contato> XListaContatos;

        public CadastroController(FRM_Cadastro view)
        {
            this.view = view;
        }

        /// <summary>
        /// Carrega a list no listBox
        /// </summary>
        public void AtualizarListaNaTela()
        {
            //limpar memoria da listabox
            view.getListB().Items.Clear(); 

            foreach (DTO_Contato V_Contatos in GerenciaBD.LST_ListaContatos) //para cada contato encontrado na colecao lista
            {
                view.getListB().Items.Add(V_Contatos.nome + " ( " + V_Contatos.numero + " )");
            }

            //Atualizar numero de gegistros:
            view.getLblNumReg().Text = "Registros: " + view.getListB().Items.Count;

        }

        public void Atualizar(int index)
        {

            MessageBox.Show("Parei Aqui");
            
        }



        public void Excluir(int index)
        {
            //Carregar a lista:
            GerenciaBD.LST_ListaContatos = GerenciaBD.CarregarArquivoBDContatos();

            GerenciaBD.LST_ListaContatos.RemoveAt(index);

            //Grava arquivo com a lista nova:
            DAL_Contato.Gravar(GerenciaBD.LST_ListaContatos);

            //atualizar a lista da tela:
            AtualizarListaNaTela();

            //Preparar campos para novo registro: limpar campos e deixar o campo nome ativo - video 072 22:00
            view.getNome().Text = "";
            view.getCel().Text = "";
            view.getNome().Focus();
        }



        public void Gravar()
        {
            DTO_Contato dtoCcontato = new DTO_Contato();
            dtoCcontato.nome = view.getNome().Text;
            dtoCcontato.numero = view.getCel().Text;

            //valida o objeto:
            if(!BLL_Contato.IsValido(dtoCcontato))
            {
               throw new Exception("Todos os campos são obrigatórios!");
            }

            //Carregar a lista:
            GerenciaBD.LST_ListaContatos = GerenciaBD.CarregarArquivoBDContatos();

            //Add novo contato na List:
            GerenciaBD.AddNovoNaList(view.getNome().Text, view.getCel().Text);

            //Grava arquivo com a lista nova:
            DAL_Contato.Gravar(GerenciaBD.LST_ListaContatos);

            //atualizar a lista da tela:
            AtualizarListaNaTela();

            //Preparar campos para novo registro: limpar campos e deixar o campo nome ativo - video 072 22:00
            view.getNome().Text = "";
            view.getCel().Text = "";
            view.getNome().Focus();
        }

    }
}
