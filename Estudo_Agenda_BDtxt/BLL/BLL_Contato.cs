using Estudo_Agenda_BDtxt.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Agenda_BDtxt.BLL
{
    public class BLL_Contato
    {
        /// <summary>
        /// Valida os campos
        /// </summary>
        /// <returns>bool</returns>
        public static bool IsValido(DTO_Contato dtoCcontato)
        {
            //Validar se todos os campos estão preechidos:
            if (String.IsNullOrEmpty(dtoCcontato.nome) || String.IsNullOrEmpty(dtoCcontato.numero))
            {
                return false;
                
            }
            return true;
        }

        /// <summary>
        /// Valida se ja existe:
        /// </summary>
        /// <returns>bool</returns>
        public static bool IsExistente(DTO_Contato dtoCcontato,List<DTO_Contato> XListaContatos)
        {    
            //ercorre a lista:
            foreach (DTO_Contato dtoContato in XListaContatos)
            {
                if (dtoContato.nome == dtoCcontato.nome && dtoContato.numero == dtoCcontato.numero)
                {
                    return true;
                    //MessageBox.Show("Erro!, Este contato ja Existe!");                    
                }
                
            }
            return false;
        }

    }
}
