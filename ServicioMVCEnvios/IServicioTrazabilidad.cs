using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTrazabilidad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTrazabilidad
    {
        [OperationContract]
        void AgregarTrazabilidad(Trazabilidad trazabilidad);

        [OperationContract]
        List<Trazabilidad> ListarTrazabilidades();

        [OperationContract]
        void EliminarTrazabilidades(long id);

        [OperationContract]
        void EditarTrazabilidades(Trazabilidad trazabilidad);

        [OperationContract]
        Trazabilidad BuscarTrazabilidad(long id);
    }
}
