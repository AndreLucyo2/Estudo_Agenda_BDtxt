using Estudo_Agenda_BDtxt.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Agenda_BDtxt.DAL
{
    public class DAL_Contato
    {
        //Vontrole de versao:
        public static string V_Versao = "v 1.0.0";

        /// <summary>
        /// Recebe uma lista de conatos e grava o banco:
        /// </summary>
        public static void Gravar(List<DTO_Contato> XListaContatos)
        {
            try
            {
                //Definir o arquivo de dados:
                string NomeArquivoBD = GerenciaBD.NomeArquivoBD;

                //Cria um novo arquivo e sobescreve:
                StreamWriter ArquivoBD = new StreamWriter(NomeArquivoBD, false, Encoding.Default);

                //Carregar a ista no aqruivo:
                foreach (DTO_Contato V_Contato in XListaContatos)
                {
                    ArquivoBD.WriteLine(V_Contato.nome); //gravar uma linha com o Nome
                    ArquivoBD.WriteLine(V_Contato.numero); //grava outra linha com o Numero ogo abaixo do nome
                }

                //libera oa rquivo:
                ArquivoBD.Dispose();
            }
            catch (Exception ex)
            {          
                throw new Exception("Erro ao Gravar contatos! \n" + ex.Message);
            }

        }

    }




}
