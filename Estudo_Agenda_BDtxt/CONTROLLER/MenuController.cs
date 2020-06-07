using Estudo_Agenda_BDtxt.DAL;
using Estudo_Agenda_BDtxt.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Agenda_BDtxt.CONTROLLER
{
    public class MenuController
    {
        //Recebe uma view Form:
        private FRM_Menu view;

        public MenuController(FRM_Menu view)
        {
            this.view = view;
        }

        /// <summary>
        /// Carrega a o arquivo em memoria:
        /// </summary>
        public void LerArquivo()
        {
            GerenciaBD.CarregarArquivoBDContatos();
        }
    }
}
