using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_Agenda_BDtxt.DTO;

namespace Estudo_Agenda_BDtxt.DAL
{
    public static class GerenciaBD
    {
        //Vontrole de versao:
        private const string _VERSAO = "v 1.0.0";        
        public static string Versao = _VERSAO;

        //lista de contatos:
        public static List<DTO_Contato> LST_ListaContatos;

        //Definir o caminho do arquivo de BD
        public static string NomeArquivoBD = MET_AqruivoContatosBD();

        /// <summary>
        /// Definir o arquivo de banco de dados
        /// </summary>
        /// <returns>caminho completo do aquivo de banco de dados</returns>
        private static string MET_AqruivoContatosBD()
        {
            //determinar a pasta onde criar o arquivo de dados *.txt
            string pastaAplicacao = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string NomeArquivoBD = pastaAplicacao + "ContatosBD.txt";
            return NomeArquivoBD;
        }

        /// <summary>
        /// Atualiza a List
        /// </summary>
        public static void AddNovoNaList(string nome, string numero)
        {           
            DTO_Contato novoContato = new DTO_Contato();
            novoContato.nome = nome;
            novoContato.nome = numero;

            //FORMA 1:
            //Add. na lista novo contato:
            //LST_ListaContatos.Add(novoContato);
            LST_ListaContatos.Add(new DTO_Contato() { nome = nome, numero = numero });

            //FORMA 2:
            //gravar a lista instanciando:
            //Contado Novo = new Contado();
            //Novo.Nome = PAR_Nome;
            //Novo.Numero = PAR_Numero;
            //LISTA_CONTATOS.Add(Novo);
        }

        /// <summary>
        /// Ler o arquivo e passa para a um lista em momoria
        /// </summary>
        public static List<DTO_Contato> CarregarArquivoBDContatos()
        {
            try
            {
                //Definir arquivo do banco:
                string NomeArquivoBD = GerenciaBD.NomeArquivoBD;

                //Verificar se o BD existe se o arquivo existe cria a lista caso contraior nao faz nada
                if (File.Exists(NomeArquivoBD))
                {
                    //ler arquivos BD *.txt
                    StreamReader ArquivoBD = new StreamReader(NomeArquivoBD, Encoding.Default);

                    //criar lista vazia de contatos independente de ter o arquivoc de dados
                    LST_ListaContatos = new List<DTO_Contato>();

                    //loop a cada volta carrega duas linhas:
                    //faca ate o final do arquivo texto
                    while (!ArquivoBD.EndOfStream)
                    {
                        //carregar campo Nome
                        string Nome = ArquivoBD.ReadLine();

                        //carregar campo Numero
                        string Numero = ArquivoBD.ReadLine();//escreve a linha imediatemente a seguir

                        //adicionar a list a de contatos o contado carregado:
                        DTO_Contato contato = new DTO_Contato();
                        contato.nome = Nome;
                        contato.numero = Numero;
                        LST_ListaContatos.Add(contato);
                    }

                    //Liberar o Arquivo
                    ArquivoBD.Dispose();

                    return LST_ListaContatos;
                }
            }
            catch (Exception ex)
            {
                return LST_ListaContatos = null;
                throw new Exception("Erro ao Ler o Arquivo de Dados! \n" + ex.Message);
            }

            return null;
        }

    }
}
