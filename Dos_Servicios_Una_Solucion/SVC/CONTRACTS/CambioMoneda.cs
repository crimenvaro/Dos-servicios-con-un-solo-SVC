using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using CambioMonedaBLL.Cambio;
using CambioMonedaDAL.Cambio;

namespace SVC.CONTRACTS
{
    public class CambioMoneda : INTERFACES.ICambioMoneda
    {
        public float CambiarMoneda(float Num, char Simbolo)
        {
            Cls_Entidades_DAL objCambioDAL = new Cls_Entidades_DAL();
            Cls_Logica_BLL objCambioBll = new Cls_Logica_BLL();

            objCambioDAL.fMonto = Num;
            objCambioDAL.cSimbolo = Simbolo;

            objCambioBll.CalcularCambio(ref objCambioDAL);

            return objCambioDAL.fRes;
        }
    }
}
