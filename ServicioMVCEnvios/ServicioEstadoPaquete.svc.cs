using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstadoPaquete" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioEstadoPaquete.svc o ServicioEstadoPaquete.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioEstadoPaquete : IServicioEstadoPaquete
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public List<EstadoPaquete> ListarEstadosPaquete()
        {
            return db.EstadoPaquete.ToList();
        }
    }
}
