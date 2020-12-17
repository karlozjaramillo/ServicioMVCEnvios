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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLogin" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioLogin.svc o ServicioLogin.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioLogin : IServicioLogin
    {
        private MVCEnviosEntities db = new MVCEnviosEntities();

        public void AgregarLogin(Login login)
        {
            db.Login.Add(login);
            db.SaveChanges();
        }

        public Login BuscarLogin(long id)
        {
            return db.Login.Find(id);
        }

        public void EditarLogins(Login login)
        {
            db.Entry(login).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarLogins(long id)
        {
            Login login = db.Login.Find(id);
            db.Login.Remove(login);
            db.SaveChanges();
        }

        public List<Login> ListarLogins()
        {
            return db.Login.ToList();
        }

        public Login Login(string usuario, string password)
        {
            var user = db.Login.Where(l => l.Usuario == usuario && l.Password == password).FirstOrDefault();
            return user;
        }
    }
}
