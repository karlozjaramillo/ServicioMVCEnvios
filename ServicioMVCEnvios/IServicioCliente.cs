using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        void AgregarCliente(Cliente cliente);

        [OperationContract]
        List<Cliente> ListarClientes();

        [OperationContract]
        void EliminarClientes(long id);

        [OperationContract]
        void EditarClientes(Cliente cliente);

        [OperationContract]
        Cliente BuscarCliente(long id);
    }
}
