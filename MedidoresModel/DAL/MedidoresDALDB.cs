using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        private MedidoresDBEntities1 medidoresDB = new MedidoresDBEntities1 ();

        public Medidore Obtener(int id)
        {
            return this.medidoresDB.Medidores.Find(id);
        }

        public List<Medidore> ObtenerMedidores()
        {
            return this.medidoresDB.Medidores.ToList ();
        }
    }
}
