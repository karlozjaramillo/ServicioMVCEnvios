using ServicioMVCEnvios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioMVCEnvios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTrazabilidad" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioTrazabilidad.svc o ServicioTrazabilidad.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioTrazabilidad : IServicioTrazabilidad
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarTrazabilidad(Trazabilidad trazabilidad)
        {
            db.Trazabilidad.Add(trazabilidad);
            db.SaveChanges();
        }

        public Trazabilidad BuscarTrazabilidad(long id)
        {
            return db.Trazabilidad.Find(id);
        }

        public void EditarTrazabilidades(Trazabilidad trazabilidad)
        {
            db.Entry(trazabilidad).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarTrazabilidades(long id)
        {
            Trazabilidad trazabilidad = db.Trazabilidad.Find(id);
            db.Trazabilidad.Remove(trazabilidad);
            db.SaveChanges();
        }

        public List<Trazabilidad> ListarTrazabilidades()
        {
            return db.Trazabilidad.ToList();
        }
    }
}
