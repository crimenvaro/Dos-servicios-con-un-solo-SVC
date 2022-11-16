using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalinCapDAL.PalinCap;

namespace PalinCapBLL.PalinCap
{
    public class Cls_Logica_BLL
    {
        public void Verificar_Palind_y_Capic(ref Cls_Entidades_DAL Obj_Palin_Dal)
        {

            Stack pila = new Stack();

            foreach (var c in Obj_Palin_Dal.sPalabra_I.ToArray())
                pila.Push(c);

            while (pila.Count > 0)
                Obj_Palin_Dal.sPalabra_II += pila.Pop();

            if (Obj_Palin_Dal.sPalabra_II.Equals(Obj_Palin_Dal.sPalabra_I))
                Obj_Palin_Dal.bResult = true;
            else
                Obj_Palin_Dal.bResult = false;

        }
    }
}
