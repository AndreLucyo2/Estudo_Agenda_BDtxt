using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudo_Agenda_BDtxt.DTO;

namespace Estudo_Agenda_BDtxt.DAL
{
    public static class GeranciaBD
    {
        //Vontrole de versao:
        public static string V_Versao = "v 1.0.0";

        //lista de contatos:
        private static List<Contato> _ListaContatos;

        /// <summary>
        /// Definir o arquivo de banco de dados
        /// </summary>
        /// <returns>caminho completo do aquivo de banco de dados</returns>
        private static string MET_AqruivoContatosBD()
        {
            //determinar a pasta onde criar o arquivo de dados *.txt
            string pastaAplicacao = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string NomeArquivoBD = pastaAplicacao + @"\ContatosBD.txt";
            return NomeArquivoBD;
        }

        public static void MET_CarregarListaContos()
        {          
            //Definir o local do BD:
            string NomeArquivoBD = MET_AqruivoContatosBD();

            //Verificar se o BD existe:
            if (File.Exists(NomeArquivoBD))
            {
                //ler arquivos BD *.txt
                StreamReader ArquivoBD = new StreamReader(NomeArquivoBD, Encoding.Default); // 

                //criar lista de contatos:
                _ListaContatos = new List<Contato>();

                //loop a cada volta carrega duas linhas:
                //faca ate o final do arquivo texto
                while (!ArquivoBD.EndOfStream) 
                {
                    //carregar campo Nome
                    string Nome = ArquivoBD.ReadLine();

                    //carregar campo Numero
                    string Numero = ArquivoBD.ReadLine();//escreve a linha imediatemente a seguir

                    //adicionar a list a de contatos o contado carregado:
                    Contato contato = new Contato();
                    contato.nome = Nome;
                    contato.numero = Numero;
                    _ListaContatos.Add(contato);
                }

                //Liberar o Arquivo
                ArquivoBD.Dispose();
            }
        }

        /// <summary>
        /// Gravar um novo registro no arquivo
        /// </summary>
        public static void MET_GravarNovoRegistro(string nome, string numero)
        {
            //FORMA 1:
            //gravar a lista em apenas uma linha
            _ListaContatos.Add(new Contato() { nome = nome, numero = numero });

            //FORMA 2:
            //gravar a lista instanciando:
            //Contado Novo = new Contado();
            //Novo.Nome = PAR_Nome;
            //Novo.Numero = PAR_Numero;
            //LISTA_CONTATOS.Add(Novo);

            //atualiza o arquivo:
            MET_GravarArquivoTxt();
        }

        /// <summary>
        /// Gravar Arquivo de Dados
        /// Substitui o arquivo existente com os dados carregados na lista da tela
        /// </summary>
        public static void MET_GravarArquivoTxt() //
        {
            //Definir o arquivo de dados:
            string NomeArquivoBD = MET_AqruivoContatosBD();
            StreamWriter V_ArquivoTxt = new StreamWriter(NomeArquivoBD, false, Encoding.Default);
            
            //Carregar a ista no aqruivo:
            foreach (Contato V_Contato in _ListaContatos)
            {
                V_ArquivoTxt.WriteLine(V_Contato.nome); //gravar uma linha com o Nome
                V_ArquivoTxt.WriteLine(V_Contato.numero); //grava outra linha com o Numero ogo abaixo do nome
            }

            //libera oa rquivo:
            V_ArquivoTxt.Dispose();
        }

    }
}
