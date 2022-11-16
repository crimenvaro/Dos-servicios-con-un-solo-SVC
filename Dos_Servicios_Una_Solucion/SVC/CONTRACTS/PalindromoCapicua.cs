using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using PalinCapBLL.PalinCap;
using PalinCapDAL.PalinCap;

namespace SVC.CONTRACTS
{
    public class PalindromoCapicua : INTERFACES.IPalindromoCapicua
    {
        public bool VerificarCapicua(string Palabra)
        {
            Cls_Entidades_DAL objCapicDAL = new Cls_Entidades_DAL();
            Cls_Logica_BLL objCapicBll = new Cls_Logica_BLL();

            objCapicDAL.sPalabra_I = Palabra.ToLower().Replace(" ", string.Empty);

            objCapicBll.Verificar_Palind_y_Capic(ref objCapicDAL);

            if (objCapicDAL.bResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarPalindromo(string Palabra)
        {
            Cls_Entidades_DAL objPalinDAL = new Cls_Entidades_DAL();
            Cls_Logica_BLL objPalinBll = new Cls_Logica_BLL();

            objPalinDAL.sPalabra_I = Palabra.ToLower().Replace(" ", string.Empty);

            objPalinBll.Verificar_Palind_y_Capic(ref objPalinDAL);

            if (objPalinDAL.bResult == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
