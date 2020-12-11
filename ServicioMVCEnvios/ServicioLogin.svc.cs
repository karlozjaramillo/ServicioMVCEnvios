using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLogin" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioLogin.svc o ServicioLogin.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioLogin : IServicioLogin
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public Login Login(string usuario, string password)
        {
            var user = db.Login.Where(l => l.Usuario == usuario && l.Password == password).FirstOrDefault();
            return user;
        }
    }
}
