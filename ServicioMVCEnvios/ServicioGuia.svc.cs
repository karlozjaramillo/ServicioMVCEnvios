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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioGuia" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioGuia.svc o ServicioGuia.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioGuia : IServicioGuia
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarGuia(Guia guia)
        {
            db.Guia.Add(guia);
            db.SaveChanges();
        }

        public Guia BuscarGuias(long id)
        {
            return db.Guia.Find(id);
        }

        public void EditarGuias(Guia guia)
        {
            db.Entry(guia).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarGuias(long id)
        {
            Guia guia = db.Guia.Find(id);
            db.Guia.Remove(guia);
            db.SaveChanges();
        }

        public List<Guia> ListarGuias()
        {
            return db.Guia.ToList();
        }
    }
}
