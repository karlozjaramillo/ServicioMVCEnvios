using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioGuia" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioGuia
    {
        [OperationContract]
        void AgregarGuia(Guia guia);

        [OperationContract]
        List<Guia> ListarGuias();

        [OperationContract]
        void EliminarGuias(long id);

        [OperationContract]
        void EditarGuias(Guia guia);

        [OperationContract]
        Guia BuscarGuias(long id);

        //[OperationContract]
        //List<Guia> Cedula(string cedula);
    }
}
