using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioLogin" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioLogin
    {
        [OperationContract]
        Login Login(string usuario, string password);

        [OperationContract]
        void AgregarLogin(Login login);

        [OperationContract]
        List<Login> ListarLogins();

        [OperationContract]
        void EliminarLogins(long id);

        [OperationContract]
        void EditarLogins(Login login);

        [OperationContract]
        Login BuscarLogin(long id);
    }
}
