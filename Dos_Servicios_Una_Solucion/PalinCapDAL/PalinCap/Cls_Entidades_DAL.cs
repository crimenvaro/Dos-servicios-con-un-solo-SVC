using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalinCapDAL.PalinCap
{
    public class Cls_Entidades_DAL
    {
        #region Variables_Privadas

        private string _sPalabra_I, _sPalabra_II;
        private bool _bResult;

        #endregion

        #region Contructores
        public string sPalabra_I { get => _sPalabra_I; set => _sPalabra_I = value; }
        public string sPalabra_II { get => _sPalabra_II; set => _sPalabra_II = value; }
        public bool bResult { get => _bResult; set => _bResult = value; }

        #endregion
    }
}
