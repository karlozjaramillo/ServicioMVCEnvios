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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCliente.svc o ServicioCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioCliente : IServicioCliente
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();
        public void AgregarCliente(Cliente cliente)
        {
            db.Cliente.Add(cliente);
            db.SaveChanges();
        }

        public Cliente BuscarCliente(long id)
        {
            return db.Cliente.Find(id);
        }

        public void EditarClientes(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarClientes(long id)
        {
            Cliente cliente = db.Cliente.Find(id);
            db.Cliente.Remove(cliente);
            db.SaveChanges();
        }

        public List<Cliente> ListarClientes()
        {
            return db.Cliente.ToList();
        }
    }
}
