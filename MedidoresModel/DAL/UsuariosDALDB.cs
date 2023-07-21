using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {

        private MedidoresDBEntities1 medidorDB = new MedidoresDBEntities1 ();

        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorDB.Usuarios.Add (usuario);
            this.medidorDB.SaveChanges ();
        }

        public void EliminarUsuario(int id)
        {
            Usuario usuario = this.medidorDB.Usuarios.Find(id);

            this.medidorDB.Usuarios.Remove(usuario);
            this.medidorDB.SaveChanges ();


        }

        public Usuario Obtener(int id)
        {
            return this.medidorDB.Usuarios.Find(id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorDB.Usuarios.ToList();
        }

        public void Actualizar(Usuario a)
        {
            Usuario aOriginal = this.medidorDB.Usuarios.Find(a.Id);
            aOriginal.Rut = a.Rut;
            aOriginal.Nombre = a.Nombre;
            aOriginal.Correo = a.Correo;
            aOriginal.Contrasena= a.Contrasena;
            this.medidorDB.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios(int id)
        {
            var query = from a in this.medidorDB.Usuarios
            where a.Id == id
            select a;
            return query.ToList();
        }

    }
}
