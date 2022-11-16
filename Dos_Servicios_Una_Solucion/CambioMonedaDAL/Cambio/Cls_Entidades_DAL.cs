using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioMonedaDAL.Cambio
{
    public class Cls_Entidades_DAL
    {
        #region Variables_Privadas

        private float _fMonto, _fRes;
        private char _cSimbolo;

        #endregion

        #region Contructores

        public float fMonto { get => _fMonto; set => _fMonto = value; }
        public float fRes { get => _fRes; set => _fRes = value; }
        public char cSimbolo { get => _cSimbolo; set => _cSimbolo = value; }

        #endregion
    }
}
