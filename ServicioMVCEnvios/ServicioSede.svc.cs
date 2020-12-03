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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSede" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioSede.svc o ServicioSede.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioSede : IServicioSede
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarSede(Sede sede)
        {
            db.Sede.Add(sede);
            db.SaveChanges();
        }

        public Sede BuscarSede(long id)
        {
            return db.Sede.Find(id);
        }

        public void EditarSedes(Sede sede)
        {
            db.Entry(sede).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarSedes(long id)
        {
            Sede sede = db.Sede.Find(id);
            db.Sede.Remove(sede);
            db.SaveChanges();
        }

        public List<Sede> ListarSedes()
        {
            return db.Sede.ToList();
        }
    }
}
