using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEstadoSede" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioEstadoSede.svc o ServicioEstadoSede.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioEstadoSede : IServicioEstadoSede
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public List<EstadoSede> ListarEstadoSede()
        {
            return db.EstadoSede.ToList();
        }
    }
}
