using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SVC.INTERFACES
{
    [ServiceContract]
    public interface ICambioMoneda
    {
        [OperationContract]
        float CambiarMoneda(float Num, char Simbolo);
    }
}
