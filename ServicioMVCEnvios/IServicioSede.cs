using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSede" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSede
    {
        [OperationContract]
        void AgregarSede(Sede sede);

        [OperationContract]
        List<Sede> ListarSedes();

        [OperationContract]
        void EliminarSedes(long id);

        [OperationContract]
        void EditarSedes(Sede sede);

        [OperationContract]
        Sede BuscarSede(long id);
    }
}
