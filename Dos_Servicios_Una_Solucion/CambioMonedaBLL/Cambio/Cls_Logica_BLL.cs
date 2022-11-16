using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CambioMonedaDAL.Cambio;

namespace CambioMonedaBLL.Cambio
{
    public class Cls_Logica_BLL
    {
        public void CalcularCambio(ref Cls_Entidades_DAL Obj_Cambio_Dal)
        {
            string s1;

            cr.fi.bccr.gee.wsindicadoreseconomicos cliente = new cr.fi.bccr.gee.wsindicadoreseconomicos();
            DataSet tipocambio = cliente.ObtenerIndicadoresEconomicos("317","26/07/2021","26/07/2021","Alvaro","N","alvarogmadrigal@gmail.com","L7OAOIM2ID");

            switch (Obj_Cambio_Dal.cSimbolo)
            {
                case '$':
                    {
                        Obj_Cambio_Dal.fRes = float.Parse(tipocambio.Tables[0].Rows[0].ItemArray[2].ToString()) / Obj_Cambio_Dal.fMonto;
                        break;
                    }
                case '¢':
                    {
                        Obj_Cambio_Dal.fRes = float.Parse(tipocambio.Tables[0].Rows[0].ItemArray[2].ToString()) * Obj_Cambio_Dal.fMonto;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
