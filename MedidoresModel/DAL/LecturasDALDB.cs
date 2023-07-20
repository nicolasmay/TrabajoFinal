using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        private MedidoresDBEntities1 medidorDB = new MedidoresDBEntities1();

        public void AgregarLectura(Lectura lectura)
        {
            this.medidorDB.Lecturas.Add(lectura);
            this.medidorDB.SaveChanges();
        }

        public void EliminarLectura(int id)
        {
            Lectura lectura = this.medidorDB.Lecturas.Find (id);
            
            this.medidorDB.Lecturas.Remove(lectura);
            this.medidorDB.SaveChanges();
        }

        public Lectura Obtener(int id)
        {
            return this.medidorDB.Lecturas.Find(id);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidorDB.Lecturas.ToList();
        }

        public void Actualizar(Lectura a)
        {
            Lectura aOriginal = this.medidorDB.Lecturas.Find(a.Id);
            aOriginal.Minuto = a.Minuto;
            aOriginal.Fecha = a.Fecha;
            aOriginal.Hora = a.Hora;
            aOriginal.Valorconsumo = a.Valorconsumo;
            this.medidorDB.SaveChanges();

        }

        public List<Lectura> ObtenerLecturas(int id)
        {
            //LINQ
            var query = from a in this.medidorDB.Lecturas
            where a.Id == id
            select a;
            return query.ToList();
                        ;
        }
        
    }
}
